// /////////////////////////////////////////////////////////////
// File: SystemHookCore.cpp  Class: none
// Date: 2/25/2004			 Author: Michael Kennedy
// Language: C++			 Framework: Win32
//
// Copyright: Copyright (c) Michael Kennedy, 2004-2005
// /////////////////////////////////////////////////////////////
// License: See License.txt file included with application.
// Description: See compiled documentation (Managed Hooks.chm)
// /////////////////////////////////////////////////////////////

#include "stdafx.h"
#include <windows.h>
#include "SystemHookCore.h"
#include "MessageFilter.h"

using namespace std;

map<int, HOOKPROC> callbacks;
map<int, HHOOK> hooks;

//
// Store the application instance of this module to pass to
// hook initialization. This is set in DLLMain().
//
HINSTANCE g_appInstance = NULL;

static LRESULT CALLBACK InternalMouseHookCallback(int code, WPARAM wparam, LPARAM lparam)
{
	map <int, HHOOK> :: const_iterator hook = hooks.find(WH_MOUSE_LL);

	if (code >= 0)
	{
		map <int, HOOKPROC> :: const_iterator callback = callbacks.find(WH_MOUSE_LL);

		if (callback != callbacks.end())
			((HOOKPROC)callback->second)(code, wparam, lparam);
	}

	else if (hook != hooks.end())
		return CallNextHookEx(hook->second, code, wparam, lparam);
}

static LRESULT CALLBACK InternalKeyboardHookCallback(int code, WPARAM wparam, LPARAM lparam)
{
	map <int, HHOOK> :: const_iterator hook = hooks.find(WH_KEYBOARD_LL);

	if (code >= 0)
	{
		map <int, HOOKPROC> :: const_iterator callback = callbacks.find(WH_KEYBOARD_LL);

		if (callback != callbacks.end())
			((HOOKPROC)callback->second)(code, wparam, lparam);
	}

	else if (hook != hooks.end())
		return CallNextHookEx(hook->second, code, wparam, lparam);
}

static LRESULT CALLBACK InternalGetMessageHookCallback(int code, WPARAM wparam, LPARAM lparam)
{
	map <int, HHOOK> :: const_iterator hook = hooks.find(WH_GETMESSAGE);

	if (code >= 0)
	{
		map <int, HOOKPROC> :: const_iterator callback = callbacks.find(WH_GETMESSAGE);

		if (callback != callbacks.end())
			((HOOKPROC)callback->second)(code, wparam, lparam);
	}

	else if (hook != hooks.end())
		return CallNextHookEx(hook->second, code, wparam, lparam);
}

bool UninitializeHook(int hookID)
{
	map <int, HHOOK> :: const_iterator hook = hooks.find(hookID);
	map <int, HOOKPROC> :: const_iterator callback = callbacks.find(hookID);

	if (hook != hooks.end())
	{
		UnhookWindowsHookEx(hook->second);
		hooks.erase(hook);
		callbacks.erase(callback);

		return true;
	}

	return false;
}

void Dispose(int hookID)
{
	UninitializeHook(hookID);
}

HHOOK SetUserHookCallback(int hookID, HOOKPROC lpfn, UINT threadID)
{	
	if (lpfn == NULL)
		return NULL;

	map <int, HOOKPROC> :: const_iterator callback = callbacks.find(hookID);

	if (callback != callbacks.end())
		return NULL;

	HOOKPROC callbackProc = NULL;

	switch (hookID)
	{
		case WH_GETMESSAGE:
			callbackProc = InternalMouseHookCallback;
			break;

		case WH_KEYBOARD_LL:
			callbackProc = InternalKeyboardHookCallback;
			break;

		case WH_MOUSE_LL:
			callbackProc = InternalMouseHookCallback;
			break;
	}

	HHOOK hook = SetWindowsHookEx(hookID, callbackProc, g_appInstance, threadID);

	callbacks.insert(pair<int, HOOKPROC>(hookID, lpfn));
	hooks.insert(pair<int, HHOOK>(hookID, hook));

	return hook;
}
