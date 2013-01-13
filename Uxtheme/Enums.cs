using System;

namespace Win32Interop.Enums
{
    public enum THEMESIZE
    {
        TS_MIN,             // minimum size
        TS_TRUE,            // size without stretching
        TS_DRAW             // size that theme mgr will use to draw part
    };

    public enum PROPERTYORIGIN
    {
        PO_STATE,           // property was found in the state section
        PO_PART,            // property was found in the part section
        PO_CLASS,           // property was found in the class section
        PO_GLOBAL,          // property was found in [globals] section
        PO_NOTFOUND         // property was not found
    };

    public enum WINDOWTHEMEATTRIBUTETYPE
    {
        WTA_NONCLIENT = 1
    };

    public enum BP_BUFFERFORMAT
    {
        BPBF_COMPATIBLEBITMAP,    // Compatible bitmap
        BPBF_DIB,                 // Device-independent bitmap
        BPBF_TOPDOWNDIB,          // Top-down device-independent bitmap
        BPBF_TOPDOWNMONODIB       // Top-down monochrome device-independent bitmap
    }

    public enum BP_ANIMATIONSTYLE
    {
        BPAS_NONE,                // No animation
        BPAS_LINEAR,              // Linear fade animation
        BPAS_CUBIC,               // Cubic fade animation
        BPAS_SINE                 // Sinusoid fade animation
    }

    [Flags]
    public enum WTNCA : uint
    {
        /// <summary>
        /// Prevents the window caption from being drawn.
        /// </summary>
        NODRAWCAPTION = 1,

        /// <summary>
        /// Prevents the system icon from being drawn.
        /// </summary>
        NODRAWICON = 2,

        /// <summary>
        /// Prevents the system icon menu from appearing.
        /// </summary>
        NOSYSMENU = 4,

        /// <summary>
        /// Prevents mirroring of the question mark, even in right-to-left (RTL) layout.
        /// </summary>
        NOMIRRORHELP = 8,

        /// <summary>
        /// A mask that contains all the valid bits.
        /// </summary>
        VALIDBITS = NODRAWCAPTION | NODRAWICON | NOSYSMENU | NOMIRRORHELP
    }
}
