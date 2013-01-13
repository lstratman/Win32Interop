using System;
using System.Runtime.InteropServices;
using System.Text;
using Win32Interop.Enums;
using Win32Interop.Structs;

namespace Win32Interop.Methods
{
    public partial class Uxtheme
    {
//---------------------------------------------------------------------------
// BeginPanningFeedback - Visual feedback init function related to pan gesture
//   - internally called by DefaultGestureHandler
//   - called by application
//
//  IntPtr IntPtr - The handle to the Target window that will receive feedback
//                                                                                                 
//---------------------------------------------------------------------------
[DllImport("uxtheme.dll", EntryPoint = "BeginPanningFeedback")]
public static extern bool
BeginPanningFeedback(
[In] IntPtr hwnd); 
//---------------------------------------------------------------------------
// UpdatePanningFeedback : Visual feedback function related to pan gesture
// Can Be called only after a BeginPanningFeedback call 
//   - internally called by DefaultGestureHandler
//   - called by application
//
// IntPtr IntPtr                 - The handle to the Target window that will receive feedback                                                
//                             For the method to succeed this must be the same IntPtr as provided in 
//                             BeginPanningFeedback
//  
// long lTotalOverpanOffsetX - The Total displacement that the window has moved in the horizontal direction
//                             since the end of scrollable region was reached. The API would move the window by the distance specified                                                  
//                             A maximum displacement of 30 pixels is allowed
//
// long lTotalOverpanOffsetY - The Total displacement that the window has moved in the horizontal direction
//                             since the end of scrollable
//                             region was reached. The API would move the window by the distance specified                                                
//                             A maximum displacement of 30 pixels is allowed
//           
// bool fInInertia           - Flag dictating whether the Application is handling a WM_GESTURE message with the 
//                             GF_INERTIA FLAG set 
//
//   Incremental calls to UpdatePanningFeedback should make sure they always pass
//   the sum of the increments and not just the increment themselves
//   Eg : If the initial displacement is 10 pixels and the next displacement 10 pixels
//        the second call would be with the parameter as 20 pixels as opposed to 10
//   Eg : UpdatePanningFeedback(hwnd, 10, 10, TRUE)
// 
        [DllImport("uxtheme.dll", EntryPoint = "UpdatePanningFeedback")]
public static extern bool
UpdatePanningFeedback(
	[In] IntPtr hwnd,
	[In] long lTotalOverpanOffsetX, 
	[In] long lTotalOverpanOffsetY, 
	[In] bool fInInertia);

//---------------------------------------------------------------------------
//
// EndPanningFeedback :Visual feedback reset function related to pan gesture
//   - internally called by DefaultGestureHandler
//   - called by application
//   Terminates any existing animation that was in process or set up by BeginPanningFeedback and UpdatePanningFeedback
//   The EndPanningFeedBack needs to be called Prior to calling any BeginPanningFeedBack if we have already
//   called a BeginPanningFeedBack followed by one/ more UpdatePanningFeedback calls
//
//  IntPtr IntPtr         - The handle to the Target window that will receive feedback
//
//  bool fAnimateBack - Flag to indicate whether you wish the displaced window to move back
//                      to the original position via animation or a direct jump.
//                      Either ways the method will try to restore the moved window.
//                      The latter case exists for compatibility with legacy apps. 
//
        [DllImport("uxtheme.dll", EntryPoint = "EndPanningFeedback")]
public static extern bool
EndPanningFeedback(
	[In] IntPtr hwnd, 
	[In] bool fAnimateBack);

//---------------------------------------------------------------------------
// NOTE: PartId's and StateId's used in the theme API are defined in the 
//       hdr file <vssym32.h> using the TM_PART and TM_STATE macros.  For
//       example, "TM_PART(BP, PUSHBUTTON)" defines the PartId "BP_PUSHBUTTON".

//---------------------------------------------------------------------------
//  OpenThemeData()     - Open the theme data for the specified IntPtr and 
//                        semi-colon separated list of class names. 
// 
//                        OpenThemeData() will try each class name, one at 
//                        a time, and use the first matching theme info
//                        found.  If a match is found, a theme handle
//                        to the data is returned.  If no match is found,
//                        a "NULL" handle is returned. 
//
//                        When the window is destroyed or a WM_THEMECHANGED
//                        msg is received, "CloseThemeData()" should be 
//                        called to close the theme handle.
//
//  IntPtr                - window handle of the control/window to be themed
//
//  pszClassList        - class name (or list of names) to match to theme data
//                        section.  if the list contains more than one name, 
//                        the names are tested one at a time for a match.  
//                        If a match is found, OpenThemeData() returns a 
//                        theme handle associated with the matching class. 
//                        This param is a list (instead of just a single 
//                        class name) to provide the class an opportunity 
//                        to get the "best" match between the class and 
//                        the current theme.  For example, a button might
//                        pass L"OkButton, Button" if its ID=ID_OK.  If 
//                        the current theme has an entry for OkButton, 
//                        that will be used.  Otherwise, we fall back on 
//                        the normal Button entry.
//---------------------------------------------------------------------------
[DllImport("uxtheme.dll", CharSet = CharSet.Unicode, EntryPoint = "OpenThemeData")]
public static extern IntPtr
OpenThemeData(
    IntPtr hwnd,
    string pszClassList
    );

//---------------------------------------------------------------------------
//  OpenThemeDataEx     - Open the theme data for the specified IntPtr and 
//                        semi-colon separated list of class names. 
// 
//                        OpenThemeData() will try each class name, one at 
//                        a time, and use the first matching theme info
//                        found.  If a match is found, a theme handle
//                        to the data is returned.  If no match is found,
//                        a "NULL" handle is returned. 
//
//                        When the window is destroyed or a WM_THEMECHANGED
//                        msg is received, "CloseThemeData()" should be 
//                        called to close the theme handle.
//
//  IntPtr                - window handle of the control/window to be themed
//
//  pszClassList        - class name (or list of names) to match to theme data
//                        section.  if the list contains more than one name, 
//                        the names are tested one at a time for a match.  
//                        If a match is found, OpenThemeData() returns a 
//                        theme handle associated with the matching class. 
//                        This param is a list (instead of just a single 
//                        class name) to provide the class an opportunity 
//                        to get the "best" match between the class and 
//                        the current theme.  For example, a button might
//                        pass L"OkButton, Button" if its ID=ID_OK.  If 
//                        the current theme has an entry for OkButton, 
//                        that will be used.  Otherwise, we fall back on 
//                        the normal Button entry.
//
//  dwFlags              - allows certain overrides of std features
//                         (see OTD_XXX defines above)
//---------------------------------------------------------------------------
        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode, EntryPoint = "OpenThemeDataEx")]
        public static extern IntPtr
OpenThemeDataEx(
    IntPtr hwnd,
    string pszClassList,
    uint dwFlags
    );

//---------------------------------------------------------------------------
//  CloseThemeData()    - closes the theme data handle.  This should be done 
//                        when the window being themed is destroyed or
//                        whenever a WM_THEMECHANGED msg is received 
//                        (followed by an attempt to create a new Theme data 
//                        handle).
//
//  hTheme              - open theme data handle (returned from prior call
//                        to OpenThemeData() API).
//---------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "CloseThemeData")]
public static extern int
CloseThemeData(
    IntPtr hTheme
    );

//---------------------------------------------------------------------------
//    functions for basic drawing support 
//---------------------------------------------------------------------------
// The following methods are the theme-aware drawing services.
// Controls/Windows are defined in drawable "parts" by their author: a 
// parent part and 0 or more child parts.  Each of the parts can be 
// described in "states" (ex: disabled, hot, pressed).  
//---------------------------------------------------------------------------
// For the list of all themed classes and the definition of all
// parts and states, see the file "tmschmea.h".
//---------------------------------------------------------------------------
// Each of the below methods takes a "iPartId" param to specify the 
// part and a "iStateId" to specify the state of the part.  
// "iStateId=0" refers to the root part.  "iPartId" = "0" refers to 
// the root class.  
//-----------------------------------------------------------------------
// Note: draw operations are always scaled to fit (and not to exceed)  
// the specified "Rect".
//-----------------------------------------------------------------------

//------------------------------------------------------------------------
//  DrawThemeBackground()   
//                      - draws the theme-specified border and fill for 
//                        the "iPartId" and "iStateId".  This could be 
//                        based on a bitmap file, a border and fill, or 
//                        other image description.  
//
//  hTheme              - theme data handle
//  hdc                 - IntPtr to draw into
//  iPartId             - part number to draw
//  iStateId            - state number (of the part) to draw
//  pRect               - defines the size/location of the part
//  pClipRect           - optional clipping rect (don't draw outside it)
//------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "DrawThemeBackground")]
public static extern int
DrawThemeBackground(
    IntPtr hTheme,
    IntPtr hdc,
    int iPartId,
    int iStateId,
    ref RECT pRect,
    ref RECT pClipRect
    );

//------------------------------------------------------------------------
//  DrawThemeBackgroundEx()   
//                      - draws the theme-specified border and fill for 
//                        the "iPartId" and "iStateId".  This could be 
//                        based on a bitmap file, a border and fill, or 
//                        other image description.  NOTE: This will be
//                        merged back into DrawThemeBackground() after 
//                        BETA 2.
//
//  hTheme              - theme data handle
//  hdc                 - IntPtr to draw into
//  iPartId             - part number to draw
//  iStateId            - state number (of the part) to draw
//  pRect               - defines the size/location of the part
//  pOptions            - ptr to optional params
//------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "DrawThemeBackgroundEx")]
public static extern int
DrawThemeBackgroundEx(
    IntPtr hTheme,
    IntPtr hdc,
    int iPartId,
    int iStateId,
    ref RECT pRect,
    ref DTBGOPTS pOptions
    );

//-------------------------------------------------------------------------
//  DrawThemeText()     - draws the text using the theme-specified 
//                        color and font for the "iPartId" and 
//                        "iStateId".  
//
//  hTheme              - theme data handle
//  hdc                 - IntPtr to draw into
//  iPartId             - part number to draw
//  iStateId            - state number (of the part) to draw
//  pszText             - actual text to draw
//  dwCharCount         - number of chars to draw (-1 for all)
//  dwTextFlags         - same as DrawText() "uFormat" param
//  dwTextFlags2        - additional drawing options 
//  pRect               - defines the size/location of the part
//-------------------------------------------------------------------------
        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode, EntryPoint = "DrawThemeText")]
public static extern int
DrawThemeText(
    IntPtr hTheme,
    IntPtr hdc,
    int iPartId,
    int iStateId,
    string pszText,
    int cchText,
    uint dwTextFlags,
    uint dwTextFlags2,
    ref RECT pRect
    );

//-------------------------------------------------------------------------
//  GetThemeBackgroundContentRect()
//                      - gets the size of the content for the theme-defined 
//                        background.  This is usually the area inside
//                        the borders or Margins.  
//
//      hTheme          - theme data handle
//      hdc             - (optional) device content to be used for drawing
//      iPartId         - part number to draw
//      iStateId        - state number (of the part) to draw
//      pBoundingRect   - the outer RECT of the part being drawn
//      pContentRect    - RECT to receive the content area
//-------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "GetThemeBackgroundContentRect")]
public static extern int
GetThemeBackgroundContentRect(
    IntPtr hTheme,
    IntPtr hdc,
    int iPartId,
    int iStateId,
    ref RECT pBoundingRect,
    out RECT pContentRect
    );

//-------------------------------------------------------------------------
//  GetThemeBackgroundExtent() - calculates the size/location of the theme-
//                               specified background based on the 
//                               "pContentRect".
//
//      hTheme          - theme data handle
//      hdc             - (optional) device content to be used for drawing
//      iPartId         - part number to draw
//      iStateId        - state number (of the part) to draw
//      pContentRect    - RECT that defines the content area
//      pBoundingRect   - RECT to receive the overall size/location of part
//-------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "GetThemeBackgroundExtent")]
public static extern int
GetThemeBackgroundExtent(
    IntPtr hTheme,
    IntPtr hdc,
    int iPartId,
    int iStateId,
    ref RECT pContentRect,
    out RECT pExtentRect
    );

//-------------------------------------------------------------------------
//  GetThemeBackgroundRegion()
//                      - computes the region for a regular or partially 
//                        transparent theme-specified background that is 
//                        bound by the specified "pRect".
//                        If the rectangle is empty, sets the HRGN to NULL 
//                        and return S_FALSE.
//
//  hTheme              - theme data handle
//  hdc                 - optional IntPtr to draw into (DPI scaling)
//  iPartId             - part number to draw
//  iStateId            - state number (of the part) 
//  pRect               - the RECT used to draw the part
//  pRegion             - receives handle to calculated region
//-------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "GetThemeBackgroundRegion")]
public static extern int
GetThemeBackgroundRegion(
    IntPtr hTheme,
    IntPtr hdc,
    int iPartId,
    int iStateId,
    ref RECT pRect,
    out IntPtr pRegion
    );

//-------------------------------------------------------------------------
//  GetThemePartSize() - returns the specified size of the theme part
//
//  hTheme              - theme data handle
//  hdc                 - IntPtr to select font into & measure against
//  iPartId             - part number to retrieve size for
//  iStateId            - state number (of the part) 
//  prc                 - (optional) rect for part drawing destination
//  eSize               - the type of size to be retreived
//  psz                 - receives the specified size of the part 
//-------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "GetThemePartSize")]
public static extern int
GetThemePartSize(
    IntPtr hTheme,
    IntPtr hdc,
    int iPartId,
    int iStateId,
    ref RECT prc,
    THEMESIZE eSize,
    out SIZE psz
    );

//-------------------------------------------------------------------------
//  GetThemeTextExtent() - calculates the size/location of the specified 
//                         text when rendered in the Theme Font. 
//
//  hTheme              - theme data handle
//  hdc                 - IntPtr to select font & measure into
//  iPartId             - part number to draw
//  iStateId            - state number (of the part) 
//  pszText             - the text to be measured
//  dwCharCount         - number of chars to draw (-1 for all)
//  dwTextFlags         - same as DrawText() "uFormat" param
//  pszBoundingRect     - optional: to control layout of text
//  pszExtentRect       - receives the RECT for text size/location
//-------------------------------------------------------------------------
        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode, EntryPoint = "GetThemeTextExtent")]
        public static extern int
GetThemeTextExtent(
    IntPtr hTheme,
    IntPtr hdc,
    int iPartId,
    int iStateId,
    string pszText,
    int cchCharCount,
    uint dwTextFlags,
    ref RECT pBoundingRect,
    out RECT pExtentRect
    );

//-------------------------------------------------------------------------
//  GetThemeTextMetrics()
//                      - returns info about the theme-specified font
//                        for the part/state passed in.
//
//  hTheme              - theme data handle
//  hdc                 - optional: IntPtr for screen context
//  iPartId             - part number to draw
//  iStateId            - state number (of the part) 
//  ptm                 - receives the font info
//-------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "GetThemeTextMetrics")]
public static extern int
GetThemeTextMetrics(
    IntPtr hTheme,
    IntPtr hdc,
    int iPartId,
    int iStateId,
    out TEXTMETRIC ptm
    );

//-------------------------------------------------------------------------
//  HitTestThemeBackground()
//                      - returns a HitTestCode (a subset of the values 
//                        returned by WM_NCHITTEST) for the point "ptTest" 
//                        within the theme-specified background
//                        (bound by pRect).  "pRect" and "ptTest" should 
//                        both be in the same coordinate system 
//                        (client, screen, etc).
//
//      hTheme          - theme data handle
//      hdc             - IntPtr to draw into
//      iPartId         - part number to test against
//      iStateId        - state number (of the part) 
//      pRect           - the RECT used to draw the part
//      hrgn            - optional region to use; must be in same coordinates as
//                      -    pRect and pTest.
//      ptTest          - the hit point to be tested
//      dwOptions       - HTTB_xxx constants
//      pwHitTestCode   - receives the returned hit test code - one of:
//  
//                        HTNOWHERE, HTLEFT, HTTOPLEFT, HTBOTTOMLEFT,
//                        HTRIGHT, HTTOPRIGHT, HTBOTTOMRIGHT,
//                        HTTOP, HTBOTTOM, HTCLIENT
//-------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "HitTestThemeBackground")]
public static extern int
HitTestThemeBackground(
    IntPtr hTheme,
    IntPtr hdc,
    int iPartId,
    int iStateId,
    uint dwOptions,
    ref RECT pRect,
    IntPtr hrgn,
    POINT ptTest,
    [Out] ushort pwHitTestCode
    );

//------------------------------------------------------------------------
//  DrawThemeEdge()     - Similar to the DrawEdge() API, but uses part colors
//                        and is high-DPI aware
//  hTheme              - theme data handle
//  hdc                 - IntPtr to draw into
//  iPartId             - part number to draw
//  iStateId            - state number of part
//  pDestRect           - the RECT used to draw the line(s)
//  uEdge               - Same as DrawEdge() API
//  uFlags              - Same as DrawEdge() API
//  pContentRect        - Receives the interior rect if (uFlags & BF_ADJUST)
//------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "DrawThemeEdge")]
public static extern int
DrawThemeEdge(
    IntPtr hTheme,
    IntPtr hdc,
    int iPartId,
    int iStateId,
    ref RECT pDestRect,
    uint uEdge,
    uint uFlags,
    out RECT pContentRect
    );

//------------------------------------------------------------------------
//  DrawThemeIcon()     - draws an image within an imagelist based on 
//                        a (possible) theme-defined effect. 
//
//  hTheme              - theme data handle
//  hdc                 - IntPtr to draw into
//  iPartId             - part number to draw
//  iStateId            - state number of part
//  pRect               - the RECT to draw the image within
//  himl                - handle to IMAGELIST 
//  iImageIndex         - index into IMAGELIST (which icon to draw)
//------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "DrawThemeIcon")]
public static extern int
DrawThemeIcon(
    IntPtr hTheme,
    IntPtr hdc,
    int iPartId,
    int iStateId,
    ref RECT pRect,
    IntPtr himl,
    int iImageIndex
    );

//---------------------------------------------------------------------------
//  IsThemePartDefined() - returns TRUE if the theme has defined parameters
//                         for the specified "iPartId" and "iStateId".
//
//  hTheme              - theme data handle
//  iPartId             - part number to find definition for
//  iStateId            - state number of part
//---------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "IsThemePartDefined")]
public static extern bool
IsThemePartDefined(
    IntPtr hTheme,
    int iPartId,
    int iStateId
    );

//---------------------------------------------------------------------------
//  IsThemeBackgroundPartiallyTransparent()
//                      - returns TRUE if the theme specified background for 
//                        the part/state has transparent pieces or 
//                        alpha-blended pieces.
//
//  hTheme              - theme data handle
//  iPartId             - part number 
//  iStateId            - state number of part
//---------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "IsThemeBackgroundPartiallyTransparent")]
public static extern bool
IsThemeBackgroundPartiallyTransparent(
    IntPtr hTheme,
    int iPartId,
    int iStateId
    );

//---------------------------------------------------------------------------
//    lower-level theme information services
//---------------------------------------------------------------------------
// The following methods are getter routines for each of the Theme Data types.
// Controls/Windows are defined in drawable "parts" by their author: a 
// parent part and 0 or more child parts.  Each of the parts can be 
// described in "states" (ex: disabled, hot, pressed).  
//---------------------------------------------------------------------------
// Each of the below methods takes a "iPartId" param to specify the 
// part and a "iStateId" to specify the state of the part.  
// "iStateId=0" refers to the root part.  "iPartId" = "0" refers to 
// the root class.  
//-----------------------------------------------------------------------
// Each method also take a "iPropId" param because multiple instances of 
// the same primitive type can be defined in the theme schema.
//-----------------------------------------------------------------------

//-----------------------------------------------------------------------
//  GetThemeColor()     - Get the value for the specified COLOR property
//
//  hTheme              - theme data handle
//  iPartId             - part number 
//  iStateId            - state number of part
//  iPropId             - the property number to get the value for
//  pColor              - receives the value of the property
//-----------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "GetThemeColor")]
public static extern int
GetThemeColor(
    IntPtr hTheme,
    int iPartId,
    int iStateId,
    int iPropId,
    out COLORREF pColor
    );

//-----------------------------------------------------------------------
//  GetThemeMetric()    - Get the value for the specified metric/size
//                        property
//
//  hTheme              - theme data handle
//  hdc                 - (optional) hdc to be drawn into (DPI scaling)
//  iPartId             - part number 
//  iStateId            - state number of part
//  iPropId             - the property number to get the value for
//  piVal               - receives the value of the property
//-----------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "GetThemeMetric")]
public static extern int
GetThemeMetric(
    IntPtr hTheme,
    IntPtr hdc,
    int iPartId,
    int iStateId,
    int iPropId,
    [Out] int piVal
    );

//-----------------------------------------------------------------------
//  GetThemeString()    - Get the value for the specified string property
//
//  hTheme              - theme data handle
//  iPartId             - part number 
//  iStateId            - state number of part
//  iPropId             - the property number to get the value for
//  pszBuff             - receives the string property value
//  cchMaxBuffChars     - max. number of chars allowed in pszBuff
//-----------------------------------------------------------------------
[DllImport("uxtheme.dll", CharSet = CharSet.Unicode, EntryPoint = "GetThemeString")]
public static extern int
GetThemeString(
    IntPtr hTheme,
    int iPartId,
    int iStateId,
    int iPropId,
    out StringBuilder pszBuff,
    int cchMaxBuffChars
    );

//-----------------------------------------------------------------------
//  GetThemeBool()      - Get the value for the specified bool property
//
//  hTheme              - theme data handle
//  iPartId             - part number 
//  iStateId            - state number of part
//  iPropId             - the property number to get the value for
//  pfVal               - receives the value of the property
//-----------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "GetThemeBool")]
public static extern int
GetThemeBool(
    IntPtr hTheme,
    int iPartId,
    int iStateId,
    int iPropId,
    out bool pfVal
    );

//-----------------------------------------------------------------------
//  GetThemeInt()       - Get the value for the specified int property
//
//  hTheme              - theme data handle
//  iPartId             - part number 
//  iStateId            - state number of part
//  iPropId             - the property number to get the value for
//  piVal               - receives the value of the property
//-----------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "GetThemeInt")]
public static extern int
GetThemeInt(
    IntPtr hTheme,
    int iPartId,
    int iStateId,
    int iPropId,
    out int piVal
    );

//-----------------------------------------------------------------------
//  GetThemeEnumValue() - Get the value for the specified ENUM property
//
//  hTheme              - theme data handle
//  iPartId             - part number 
//  iStateId            - state number of part
//  iPropId             - the property number to get the value for
//  piVal               - receives the value of the enum (cast to int*)
//-----------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "GetThemeEnumValue")]
public static extern int
GetThemeEnumValue(
    IntPtr hTheme,
    int iPartId,
    int iStateId,
    int iPropId,
    out int piVal
    );

//-----------------------------------------------------------------------
//  GetThemePosition()  - Get the value for the specified position
//                        property
//
//  hTheme              - theme data handle
//  iPartId             - part number 
//  iStateId            - state number of part
//  iPropId             - the property number to get the value for
//  pPoint              - receives the value of the position property
//-----------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "GetThemePosition")]
public static extern int
GetThemePosition(
    IntPtr hTheme,
    int iPartId,
    int iStateId,
    int iPropId,
    out POINT pPoint
    );

//-----------------------------------------------------------------------
//  GetThemeFont()      - Get the value for the specified font property
//
//  hTheme              - theme data handle
//  hdc                 - (optional) hdc to be drawn to (DPI scaling)
//  iPartId             - part number 
//  iStateId            - state number of part
//  iPropId             - the property number to get the value for
//  pFont               - receives the value of the LOGFONT property
//                        (scaled for the current logical screen dpi) 
//-----------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "GetThemeFont")]
public static extern int
GetThemeFont(
    IntPtr hTheme,
    IntPtr hdc,
    int iPartId,
    int iStateId,
    int iPropId,
    out LOGFONT pFont
    );

//-----------------------------------------------------------------------
//  GetThemeRect()      - Get the value for the specified RECT property
//
//  hTheme              - theme data handle
//  iPartId             - part number 
//  iStateId            - state number of part
//  iPropId             - the property number to get the value for
//  pRect               - receives the value of the RECT property
//-----------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "GetThemeRect")]
public static extern int
GetThemeRect(
    IntPtr hTheme,
    int iPartId,
    int iStateId,
    int iPropId,
    out RECT pRect
    );

//-----------------------------------------------------------------------
//  GetThemeMargins()   - Get the value for the specified MARGINS property
//
//      hTheme          - theme data handle
//      hdc             - (optional) hdc to be used for drawing
//      iPartId         - part number 
//      iStateId        - state number of part
//      iPropId         - the property number to get the value for
//      prc             - RECT for area to be drawn into
//      pMargins        - receives the value of the MARGINS property
//-----------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "GetThemeMargins")]
public static extern int
GetThemeMargins(
    IntPtr hTheme,
    IntPtr hdc,
    int iPartId,
    int iStateId,
    int iPropId,
    ref RECT prc,
    out MARGINS pMargins
    );

//-----------------------------------------------------------------------
//  GetThemeIntList()   - Get the value for the specified INTLIST struct
//
//      hTheme          - theme data handle
//      iPartId         - part number 
//      iStateId        - state number of part
//      iPropId         - the property number to get the value for
//      pIntList        - receives the value of the INTLIST property
//-----------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "GetThemeIntList")]
public static extern int
GetThemeIntList(
    IntPtr hTheme,
    int iPartId,
    int iStateId,
    int iPropId,
    out INTLIST pIntList
    );

//-----------------------------------------------------------------------
//  GetThemePropertyOrigin()
//                      - searches for the specified theme property
//                        and sets "pOrigin" to indicate where it was 
//                        found (or not found)
//
//  hTheme              - theme data handle
//  iPartId             - part number 
//  iStateId            - state number of part
//  iPropId             - the property number to search for
//  pOrigin             - receives the value of the property origin
//-----------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "GetThemePropertyOrigin")]
public static extern int
GetThemePropertyOrigin(
    IntPtr hTheme,
    int iPartId,
    int iStateId,
    int iPropId,
    out PROPERTYORIGIN pOrigin
    );

//---------------------------------------------------------------------------
//  SetWindowTheme()
//                      - redirects an existing Window to use a different 
//                        section of the current theme information than its 
//                        class normally asks for.
//
//  IntPtr                - the handle of the window (cannot be NULL)
//
//  pszSubAppName       - app (group) name to use in place of the calling
//                        app's name.  If NULL, the actual calling app 
//                        name will be used.
//
//  pszSubIdList        - semicolon separated list of class Id names to 
//                        use in place of actual list passed by the 
//                        window's class.  if NULL, the id list from the 
//                        calling class is used.
//---------------------------------------------------------------------------
// The Theme Manager will remember the "pszSubAppName" and the
// "pszSubIdList" associations thru the lifetime of the window (even 
// if themes are subsequently changed).  The window is sent a 
// "WM_THEMECHANGED" msg at the end of this call, so that the new
// theme can be found and applied.
//---------------------------------------------------------------------------
// When "pszSubAppName" or "pszSubIdList" are NULL, the Theme Manager 
// removes the previously remember association.  To turn off theme-ing for 
// the specified window, you can pass an empty string (L"") so it 
// won't match any section entries.
//---------------------------------------------------------------------------
[DllImport("uxtheme.dll", CharSet = CharSet.Unicode, EntryPoint = "SetWindowTheme")]
public static extern int
SetWindowTheme(
    IntPtr hwnd,
    string pszSubAppName,
    string pszSubIdList
    );


//---------------------------------------------------------------------------
//  GetThemeFilename()  - Get the value for the specified FILENAME property.
//
//  hTheme              - theme data handle
//  iPartId             - part number 
//  iStateId            - state number of part
//  iPropId             - the property number to search for
//  pszThemeFileName    - output buffer to receive the filename
//  cchMaxBuffChars     - the size of the return buffer, in chars
//---------------------------------------------------------------------------
[DllImport("uxtheme.dll", CharSet = CharSet.Unicode, EntryPoint = "GetThemeFilename")]
public static extern int
GetThemeFilename(
    IntPtr hTheme,
    int iPartId,
    int iStateId,
    int iPropId,
    StringBuilder pszThemeFileName,
    int cchMaxBuffChars
    );

//---------------------------------------------------------------------------
//  GetThemeSysColor()  - Get the value of the specified System color. 
//
//  hTheme              - the theme data handle.  if non-NULL, will return
//                        color from [SysMetrics] section of theme.
//                        if NULL, will return the global system color.
//
//  iColorId            - the system color index defined in winuser.h
//---------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "GetThemeSysColor")]
public static extern COLORREF
GetThemeSysColor(
    IntPtr hTheme,
    int iColorId
    );

//---------------------------------------------------------------------------
//  GetThemeSysColorBrush() 
//                      - Get the brush for the specified System color. 
//
//  hTheme              - the theme data handle.  if non-NULL, will return
//                        brush matching color from [SysMetrics] section of 
//                        theme.  if NULL, will return the brush matching
//                        global system color.
//
//  iColorId            - the system color index defined in winuser.h
//---------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "GetThemeSysColorBrush")]
public static extern IntPtr
GetThemeSysColorBrush(
    IntPtr hTheme,
    int iColorId
    );

//---------------------------------------------------------------------------
//  GetThemeSysBool()   - Get the boolean value of specified System metric. 
//
//  hTheme              - the theme data handle.  if non-NULL, will return
//                        bool from [SysMetrics] section of theme.
//                        if NULL, will return the specified system boolean.
//
//  iBoolId             - the TMT_XXX bool number (first BOOL
//                        is TMT_FLATMENUS)
//---------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "GetThemeSysBool")]
public static extern bool
GetThemeSysBool(
    IntPtr hTheme,
    int iBoolId
    );

//---------------------------------------------------------------------------
//  GetThemeSysSize()   - Get the value of the specified System size metric. 
//                        (scaled for the current logical screen dpi) 
//
//  hTheme              - the theme data handle.  if non-NULL, will return
//                        size from [SysMetrics] section of theme.
//                        if NULL, will return the global system metric.
//
//  iSizeId             - the following values are supported when 
//                        hTheme is non-NULL:
//
//                          SM_CXBORDER       (border width)
//                          SM_CXVSCROLL      (scrollbar width)
//                          SM_CYHSCROLL      (scrollbar height)
//                          SM_CXSIZE         (caption width)
//                          SM_CYSIZE         (caption height)
//                          SM_CXSMSIZE       (small caption width)
//                          SM_CYSMSIZE       (small caption height)
//                          SM_CXMENUSIZE     (menubar width)
//                          SM_CYMENUSIZE     (menubar height)
//                          SM_CXPADDEDBORDER (padded border width)
//
//                        when hTheme is NULL, iSizeId is passed directly
//                        to the GetSystemMetrics() function
//---------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "GetThemeSysSize")]
public static extern int
GetThemeSysSize(
    IntPtr hTheme,
    int iSizeId
    );

//---------------------------------------------------------------------------
//  GetThemeSysFont()   - Get the LOGFONT for the specified System font. 
//
//  hTheme              - the theme data handle.  if non-NULL, will return
//                        font from [SysMetrics] section of theme.
//                        if NULL, will return the specified system font.
//
//  iFontId             - the TMT_XXX font number (first font
//                        is TMT_CAPTIONFONT)
//
//  plf                 - ptr to LOGFONT to receive the font value.
//                        (scaled for the current logical screen dpi) 
//---------------------------------------------------------------------------
[DllImport("uxtheme.dll", CharSet = CharSet.Unicode, EntryPoint = "GetThemeSysFont")]
public static extern int
GetThemeSysFont(
    IntPtr hTheme,
    int iFontId,
    out LOGFONT plf
    );

//---------------------------------------------------------------------------
//  GetThemeSysString() - Get the value of specified System string metric. 
//
//  hTheme              - the theme data handle (required)
//
//  iStringId           - must be one of the following values:
//
//                          TMT_CSSNAME
//                          TMT_XMLNAME
//
//  pszStringBuff       - the buffer to receive the string value
//
//  cchMaxStringChars   - max. number of chars that pszStringBuff can hold
//---------------------------------------------------------------------------
[DllImport("uxtheme.dll", CharSet = CharSet.Unicode, EntryPoint = "GetThemeSysString")]
public static extern int
GetThemeSysString(
    IntPtr hTheme,
    int iStringId,
    StringBuilder pszStringBuff,
    int cchMaxStringChars
    );

//---------------------------------------------------------------------------
//  GetThemeSysInt() - Get the value of specified System int.
//
//  hTheme              - the theme data handle (required)
//
//  iIntId              - must be one of the following values:
//
//                          TMT_DPIX
//                          TMT_DPIY
//                          TMT_MINCOLORDEPTH
//
//  piValue             - ptr to int to receive value
//---------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "GetThemeSysInt")]
public static extern int
GetThemeSysInt(
    IntPtr hTheme,
    int iIntId,
    out int piValue
    );

//---------------------------------------------------------------------------
//  IsThemeActive()     - can be used to test if a system theme is active
//                        for the current user session.  
//
//                        use the API "IsAppThemed()" to test if a theme is
//                        active for the calling process.
//---------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "IsThemeActive")]
public static extern bool
IsThemeActive();

//---------------------------------------------------------------------------
//  IsAppThemed()       - returns TRUE if a theme is active and available to
//                        the current process
//---------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "IsAppThemed")]
public static extern bool
IsAppThemed();

//---------------------------------------------------------------------------
//  GetWindowTheme()    - if window is themed, returns its most recent
//                        IntPtr from OpenThemeData() - otherwise, returns
//                        NULL.
//
//      IntPtr            - the window to get the IntPtr of
//---------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "GetWindowTheme")]
public static extern IntPtr
GetWindowTheme(
    IntPtr hwnd
    );

//---------------------------------------------------------------------------
//  EnableThemeDialogTexture() 
//
//  - Enables/disables dialog background theme.  This method can be used to 
//    tailor dialog compatibility with child windows and controls that 
//    may or may not coordinate the rendering of their client area backgrounds 
//    with that of their parent dialog in a manner that supports seamless 
//    background texturing.
//
//      hdlg         - the window handle of the target dialog
//      dwFlags      - ETDT_ENABLE to enable the theme-defined dialog background texturing,
//                     ETDT_DISABLE to disable background texturing,
//                     ETDT_ENABLETAB to enable the theme-defined background 
//                          texturing using the Tab texture
//---------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "EnableThemeDialogTexture")]
public static extern int
EnableThemeDialogTexture(
    [In] IntPtr hwnd,
    [In] uint dwFlags
    );

//---------------------------------------------------------------------------
//  IsThemeDialogTextureEnabled() 
//
//  - Reports whether the dialog supports background texturing.
//
//      hdlg         - the window handle of the target dialog
//---------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "IsThemeDialogTextureEnabled")]
public static extern bool
IsThemeDialogTextureEnabled(
    [In] IntPtr hwnd
    );

//---------------------------------------------------------------------------
//  GetThemeAppProperties()
//                      - returns the app property flags that control theming
//---------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "GetThemeAppProperties")]
public static extern uint
GetThemeAppProperties();

//---------------------------------------------------------------------------
//  SetThemeAppProperties()
//                      - sets the flags that control theming within the app
//
//      dwFlags         - the flag values to be set
//---------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "SetThemeAppProperties")]
public static extern void
SetThemeAppProperties(
    uint dwFlags
    );

//---------------------------------------------------------------------------
//  GetCurrentThemeName()
//                      - Get the name of the current theme in-use.  
//                        Optionally, return the ColorScheme name and the 
//                        Size name of the theme.
//
//  pszThemeFileName    - receives the theme path & filename
//  cchMaxNameChars     - max chars allowed in pszNameBuff
//
//  pszColorBuff        - (optional) receives the canonical color scheme name
//                        (not the display name)
//  cchMaxColorChars    - max chars allowed in pszColorBuff
//
//  pszSizeBuff         - (optional) receives the canonical size name 
//                        (not the display name)
//  cchMaxSizeChars     - max chars allowed in pszSizeBuff
//---------------------------------------------------------------------------
[DllImport("uxtheme.dll", CharSet = CharSet.Unicode, EntryPoint = "GetCurrentThemeName")]
public static extern int GetCurrentThemeName(
    StringBuilder pszThemeFileName,
    int cchMaxNameChars,
    StringBuilder pszColorBuff,
    int cchMaxColorChars,
    StringBuilder pszSizeBuff,
    int cchMaxSizeChars
    );

[DllImport("uxtheme.dll", CharSet = CharSet.Unicode, EntryPoint = "GetThemeDocumentationProperty")]
public static extern int
GetThemeDocumentationProperty(
    string pszThemeName,
    string pszPropertyName,
    StringBuilder pszValueBuff,
    int cchMaxValChars
    );

//---------------------------------------------------------------------------
//  Theme API Error Handling
//
//      All functions in the Theme API not returning an HRESULT (public static extern int_) 
//      use the WIN32 function "SetLastError()" to record any call failures.  
//
//      To retreive the error code of the last failure on the
//      current thread for these type of API's, use the WIN32 function 
//      "GetLastError()".
//
//      All Theme API error codes (HRESULT's and GetLastError() values)
//      should be normal win32 errors which can be formatted into
//      strings using the Win32 API FormatMessage().
//---------------------------------------------------------------------------

//---------------------------------------------------------------------------
// DrawThemeParentBackground()
//                      - used by partially-transparent or alpha-blended
//                        child controls to draw the part of their parent
//                        that they appear in front of.
//
//  IntPtr                - handle of the child control
//
//  hdc                 - hdc of the child control
//
//  prc                 - (optional) rect that defines the area to be 
//                        drawn (CHILD coordinates)
//---------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "DrawThemeParentBackground")]
public static extern int
DrawThemeParentBackground(
    IntPtr hwnd,
    IntPtr hdc,
    ref RECT prc
    );


//---------------------------------------------------------------------------
//  EnableTheming()     - enables or disables themeing for the current user
//                        in the current and future sessions.
//
//  fEnable             - if FALSE, disable theming & turn themes off.
//                      - if TRUE, enable themeing and, if user previously
//                        had a theme active, make it active now.
//---------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "EnableTheming")]
public static extern int
EnableTheming(
    bool fEnable
    );

//---------------------------------------------------------------------------
// DrawThemeParentBackgroundEx()
//                      - used by partially-transparent or alpha-blended
//                        child controls to draw the part of their parent
//                        that they appear in front of.
//                        Sends a WM_ERASEBKGND message followed by a WM_PRINTCLIENT.
//
//  IntPtr                - handle of the child control
//
//  hdc                 - hdc of the child control
//
//  dwFlags             - if 0, only returns S_OK if the parent handled 
//                        WM_PRINTCLIENT.
//                      - if DTPB_WINDOWDC is set, hdc is assumed to be a window DC,
//                        not a client DC.
//                      - if DTPB_USEERASEBKGND is set, the function will return S_OK 
//                        without sending a WM_CTLCOLORSTATIC message if the parent 
//                        actually painted on WM_ERASEBKGND.
//                      - if DTPB_CTLCOLORSTATIC is set, the function will send
//                        a WM_CTLCOLORSTATIC message to the parent and use the 
//                        brush if one is provided, else COLOR_BTNFACE.
//
//  prc                 - (optional) rect that defines the area to be 
//                        drawn (CHILD coordinates)
//
//  Return value        - S_OK if something was painted, S_FALSE if not.
//---------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "DrawThemeParentBackgroundEx")]
public static extern int
DrawThemeParentBackgroundEx(
    IntPtr hwnd,
    IntPtr hdc,
    uint dwFlags,
    ref RECT prc
    );

        [DllImport("uxtheme.dll", EntryPoint = "SetWindowThemeAttribute")]
public static extern int
SetWindowThemeAttribute(
    IntPtr hwnd,
    WINDOWTHEMEATTRIBUTETYPE eAttribute,
    ref WTA_OPTIONS pvAttribute,
    uint cbAttribute
    );

        [DllImport("uxtheme.dll", EntryPoint = "SetWindowThemeNonClientAttributes")]
        public static extern int SetWindowThemeNonClientAttributes(IntPtr hwnd, uint dwMask, uint dwAttributes);

//---------------------------------------------------------------------------
//
// DrawThemeTextEx
//
// Note: DrawThemeTextEx only exists on Windows Vista and higher, but the 
// following declarations are provided to enable declaring its prototype when
// compiling for all platforms.

// Callback function used by DrawThemeTextEx, instead of DrawText
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
public delegate int DTT_CALLBACK_PROC
(
    IntPtr hdc,
    string pszText,
    int cchText,
    out RECT prc,
    uint dwFlags,
    int lParam);

[DllImport("uxtheme.dll", CharSet = CharSet.Unicode, EntryPoint = "DrawThemeTextEx")]
public static extern int
DrawThemeTextEx(
    IntPtr hTheme,
    IntPtr hdc,
    int iPartId,
    int iStateId,
    string pszText,
    int cchText,
    uint dwTextFlags,
    out RECT pRect,
    ref DTTOPTS pOptions
    );


//-----------------------------------------------------------------------
//  GetThemeStream() - Get the value for the specified STREAM property
//
//      hTheme      - theme data handle
//      iPartId     - part number 
//      iStateId    - state number of part
//      iPropId     - the property number to get the value for
//      ppvStream   - if non-null receives the value of the STREAM property (not to be freed)
//      pcbStream   - if non-null receives the size of the STREAM property
//      hInst       - NULL when iPropId==TMT_STREAM, HINSTANCE of a loaded msstyles 
//                    file when iPropId==TMT_DISKSTREAM (use GetCurrentThemeName 
//                    and LoadLibraryEx(LOAD_LIBRARY_AS_DATAFILE)
//-----------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "GetThemeBitmap")]
public static extern int
GetThemeBitmap(
    IntPtr hTheme,
    int iPartId,
    int iStateId,
    int iPropId,
    ulong dwFlags,
    out IntPtr phBitmap
    );

//-----------------------------------------------------------------------
//  GetThemeStream() - Get the value for the specified STREAM property
//
//      hTheme      - theme data handle
//      iPartId     - part number 
//      iStateId    - state number of part
//      iPropId     - the property number to get the value for
//      ppvStream   - if non-null receives the value of the STREAM property (not to be freed)
//      pcbStream   - if non-null receives the size of the STREAM property
//      hInst       - NULL when iPropId==TMT_STREAM, HINSTANCE of a loaded msstyles 
//                    file when iPropId==TMT_DISKSTREAM (use GetCurrentThemeName 
//                    and LoadLibraryEx(LOAD_LIBRARY_AS_DATAFILE)
//-----------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "GetThemeStream")]
public static extern int
GetThemeStream(
    IntPtr hTheme,
    int iPartId,
    int iStateId,
    int iPropId,
    out IntPtr ppvStream,
    out uint pcbStream,
    IntPtr hInst
    );


//------------------------------------------------------------------------
//  BufferedPaintInit() - Initialize the Buffered Paint API.
//                        Should be called prior to BeginBufferedPaint,
//                        and should have a matching BufferedPaintUnInit.
//------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "BufferedPaintInit")]
public static extern int
BufferedPaintInit(
    );

//------------------------------------------------------------------------
//  BufferedPaintUnInit() - Uninitialize the Buffered Paint API.
//                          Should be called once for each call to BufferedPaintInit,
//                          when calls to BeginBufferedPaint are no longer needed.
//------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "BufferedPaintUnInit")]
public static extern int
BufferedPaintUnInit(
    );

//------------------------------------------------------------------------
//  BeginBufferedPaint() - Begins a buffered paint operation.
//
//    hdcTarget          - Target DC on which the buffer will be painted
//    rcTarget           - Rectangle specifying the area of the target DC to paint to
//    dwFormat           - Format of the buffer (see BP_BUFFERFORMAT)
//    pPaintParams       - Paint operation parameters (see BP_PAINTPARAMS)
//    phBufferedPaint    - Pointer to receive handle to new buffered paint context
//------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "BeginBufferedPaint")]
public static extern IntPtr
BeginBufferedPaint(
    IntPtr hdcTarget,
    ref RECT prcTarget,
    BP_BUFFERFORMAT dwFormat,
    ref BP_PAINTPARAMS pPaintParams,
    out IntPtr phdc
    );


//------------------------------------------------------------------------
//  EndBufferedPaint() - Ends a buffered paint operation.
//
//    hBufferedPaint   - handle to buffered paint context
//    fUpdateTarget    - update target DC
//------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "EndBufferedPaint")]
public static extern int
EndBufferedPaint(
    IntPtr hBufferedPaint,
    bool fUpdateTarget
    );

//------------------------------------------------------------------------
//  GetBufferedPaintTargetRect() - Returns the target rectangle specified during BeginBufferedPaint
//
//    hBufferedPaint             - handle to buffered paint context
//    prc                        - pointer to receive target rectangle
//------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "GetBufferedPaintTargetRect")]
public static extern int
GetBufferedPaintTargetRect(
    IntPtr hBufferedPaint,
    out RECT prc
    );

//------------------------------------------------------------------------
//  GetBufferedPaintTargetDC() - Returns the target DC specified during BeginBufferedPaint
//
//    hBufferedPaint           - handle to buffered paint context
//------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "GetBufferedPaintTargetDC")]
public static extern IntPtr
GetBufferedPaintTargetDC(
    IntPtr hBufferedPaint
    );

//------------------------------------------------------------------------
//  GetBufferedPaintDC() - Returns the same paint DC returned by BeginBufferedPaint
//
//    hBufferedPaint     - handle to buffered paint context
//------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "GetBufferedPaintDC")]
public static extern IntPtr
GetBufferedPaintDC(
    IntPtr hBufferedPaint
    );

//------------------------------------------------------------------------
//  GetBufferedPaintBits() - Obtains a pointer to the buffer bitmap, if the buffer is a DIB
//
//    hBufferedPaint       - handle to buffered paint context
//    ppbBuffer            - pointer to receive pointer to buffer bitmap pixels
//    pcxRow               - pointer to receive width of buffer bitmap, in pixels;
//                           this value may not necessarily be equal to the buffer width
//------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "GetBufferedPaintBits")]
public static extern int
GetBufferedPaintBits(
    IntPtr hBufferedPaint,
    out RGBQUAD ppbBuffer,
    out int pcxRow
    );

//------------------------------------------------------------------------
//  BufferedPaintClear() - Clears given rectangle to ARGB = {0, 0, 0, 0}
//
//    hBufferedPaint     - handle to buffered paint context
//    prc                - rectangle to clear; NULL specifies entire buffer
//------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "BufferedPaintClear")]
public static extern int
BufferedPaintClear(
    IntPtr hBufferedPaint,
    ref RECT prc
    );

//------------------------------------------------------------------------
//  BufferedPaintSetAlpha() - Set alpha to given value in given rectangle
//
//    hBufferedPaint        - handle to buffered paint context
//    prc                   - rectangle to set alpha in; NULL specifies entire buffer
//    alpha                 - alpha value to set in the given rectangle
//------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "BufferedPaintSetAlpha")]
public static extern int
BufferedPaintSetAlpha(
    IntPtr hBufferedPaint,
    ref RECT prc,
    byte alpha
    );

//------------------------------------------------------------------------
//  BufferedPaintStopAllAnimations() - Stop all buffer animations for the given window
//
//    IntPtr                           - window on which to stop all animations
//------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "BufferedPaintStopAllAnimations")]
public static extern int
BufferedPaintStopAllAnimations(
    IntPtr hwnd
    );

        [DllImport("uxtheme.dll", EntryPoint = "BeginBufferedAnimation")]
public static extern IntPtr
BeginBufferedAnimation(
    IntPtr hwnd,
    IntPtr hdcTarget,
    ref RECT prcTarget,
    BP_BUFFERFORMAT dwFormat,
    ref BP_PAINTPARAMS pPaintParams,
    ref BP_ANIMATIONPARAMS pAnimationParams,
    out IntPtr phdcFrom,
    out IntPtr phdcTo
    );

        [DllImport("uxtheme.dll", EntryPoint = "EndBufferedAnimation")]
public static extern int
EndBufferedAnimation(
    IntPtr hbpAnimation,
    bool fUpdateTarget
    );

        [DllImport("uxtheme.dll", EntryPoint = "BufferedPaintRenderAnimation")]
public static extern bool
BufferedPaintRenderAnimation(
    IntPtr hwnd,
    IntPtr hdcTarget
    );
    
//----------------------------------------------------------------------------
// Tells if the DWM is running, and composition effects are possible for this 
// process (themes are active). 
// Roughly equivalent to "DwmIsCompositionEnabled() && IsAppthemed()"
//----------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "IsCompositionActive")]
public static extern bool IsCompositionActive();

//------------------------------------------------------------------------
//  GetThemeTransitionDuration()
//                      - Gets the duration for the specified transition
//
//  hTheme              - theme data handle
//  iPartId             - part number 
//  iStateIdFrom        - starting state number of part
//  iStateIdTo          - ending state number of part
//  iPropId             - property id 
//  pdwDuration         - receives the transition duration
//------------------------------------------------------------------------
        [DllImport("uxtheme.dll", EntryPoint = "GetThemeTransitionDuration")]
public static extern int
GetThemeTransitionDuration(
    IntPtr hTheme,
    int iPartId,
    int iStateIdFrom,
    int iStateIdTo,
    int iPropId,
    out uint pdwDuration
    );  

    }
}
