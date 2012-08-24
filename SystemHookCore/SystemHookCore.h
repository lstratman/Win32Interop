// /////////////////////////////////////////////////////////////
// File: SystemHookCore.h	Class: none
// Date: 2/25/2004			Author: Michael Kennedy
// Language: C++			Framework: Win32
//
// Copyright: Copyright (c) Michael Kennedy, 2004-2005
// /////////////////////////////////////////////////////////////
// License: See License.txt file included with application.
// Description: See compiled documentation (Managed Hooks.chm)
// /////////////////////////////////////////////////////////////

#pragma once
#include <map>

namespace HookCoreErrors
{
	namespace SetCallBack
	{
		const int SUCCESS = 1;
		const int ALREADY_SET = -2;
		const int NOT_IMPLEMENTED = -3;
		const int ARGUMENT_ERROR = -4;
	}
	namespace FilterMessage
	{
		const int SUCCESS = 1;
		const int FAILED = -2;
		const int NOT_IMPLEMENTED = -3;
	}
}

HHOOK SetUserHookCallback(int hookID, HOOKPROC lpfn, UINT threadID);
bool UninitializeHook(int hookID);
void Dispose(int hookID);

