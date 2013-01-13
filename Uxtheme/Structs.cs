using System;
using System.Runtime.InteropServices;
using Win32Interop.Enums;
using Win32Interop.Methods;

namespace Win32Interop.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DTBGOPTS
    {
        public uint dwSize;           // size of the struct
        public uint dwFlags;          // which options have been specified
        public RECT rcClip;            // clipping rectangle
    }

    [StructLayout((LayoutKind.Sequential))]
    public struct MARGINS
    {
        public int cxLeftWidth;      // width of left border that retains its size
        public int cxRightWidth;     // width of right border that retains its size
        public int cyTopHeight;      // height of top border that retains its size
        public int cyBottomHeight;   // height of bottom border that retains its size
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct INTLIST
    {
        public int iValueCount; // number of values in iValues
        public int[] iValues;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct WTA_OPTIONS
    {
        public WTNCA dwFlags;          // values for each style option specified in the bitmask
        public WTNCA dwMask;           // bitmask for flags that are changing
        // valid options are: WTNCA_NODRAWCAPTION, WTNCA_NODRAWICON, WTNCA_NOSYSMENU
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DTTOPTS
    {
        public uint dwSize;              // size of the struct
        public uint dwFlags;             // which options have been specified
        public COLORREF crText;              // color to use for text fill
        public COLORREF crBorder;            // color to use for text outline
        public COLORREF crShadow;            // color to use for text shadow
        public int iTextShadowType;     // TST_SINGLE or TST_CONTINUOUS
        public POINT ptShadowOffset;      // where shadow is drawn (relative to text)
        public int iBorderSize;         // Border radius around text
        public int iFontPropId;         // Font property to use for the text instead of TMT_FONT
        public int iColorPropId;        // Color property to use for the text instead of TMT_TEXTCOLOR
        public int iStateId;            // Alternate state id
        public bool fApplyOverlay;       // Overlay text on top of any text effect?
        public int iGlowSize;           // Glow radious around text
        public Uxtheme.DTT_CALLBACK_PROC pfnDrawTextCallback; // Callback for DrawText
        public int lParam;              // Parameter for callback
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BP_ANIMATIONPARAMS
    {
        public uint cbSize;
        public uint dwFlags; // BPAF_ flags
        public BP_ANIMATIONSTYLE style;
        public uint dwDuration;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BP_PAINTPARAMS
    {
        public uint cbSize;
        public uint dwFlags; // BPPF_ flags
        public IntPtr prcExclude;
        public IntPtr pBlendFunction;
    }
}
