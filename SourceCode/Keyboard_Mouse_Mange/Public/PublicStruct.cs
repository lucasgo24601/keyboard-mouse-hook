using System.Runtime.InteropServices;

namespace Keyboard_Mouse_Mange {
    public class PublicStruct {
        [StructLayout (LayoutKind.Sequential)]
        public class MouseHookStruct {
            public POINT pt;
            public int hwnd;
            public int wHitTestCode;
            public int dwExtraInfo;
        }

        [StructLayout (LayoutKind.Sequential)]
        public class POINT {
            public int x;
            public int y;
        }

        [StructLayout (LayoutKind.Sequential)]
        public class KeyboardHookStruct {
            public int vkCode;
            public int scanCode;
            public int flags;
            public int time;
            public int dwExtraInfo;
        }

        public struct POINTFX {
            public FIXED X;
            public FIXED Y;
        }

        public struct FIXED {
            public short fract;
            public short value;
        }
    }
}