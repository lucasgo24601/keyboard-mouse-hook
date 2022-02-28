using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace Keyboard_Mouse_Mange {
    class Mouse_Mange {
        private int hHook = 0;

        public delegate int HookProc (int nCode, IntPtr wParam, IntPtr lParam); // 使用Hook必須用委派形式 ， 指定Hook處理函數為MouseHookProc
        public delegate void MouseEventHandler (object sender, MouseBtnWheel e);
        public event MouseEventHandler MouseClick;

        #region Public MouseHookStruct
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
        #endregion

        #region API user32 & kernel32
        [DllImport ("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetWindowsHookEx (int idHook, HookProc lpfn, IntPtr hInstance, uint threadId);

        [DllImport ("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern bool UnhookWindowsHookEx (int idHook);

        [DllImport ("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int CallNextHookEx (int idHook, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport ("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle (string lpModuleName);

        [DllImport ("user32.dll")]
        static extern uint GetWindowThreadProcessId (IntPtr hWnd, IntPtr ProcessId);

        [DllImport ("kernel32.dll")]
        static extern IntPtr LoadLibrary (string lpFileName);
        #endregion

        #region 建構子和解構子
        public Mouse_Mange () {
            IntPtr hInstance = LoadLibrary ("User32");
            // 使用SetWindowsHookEx來達成全域狀態下也可獲取資訊方法，針對MOUSE類別

            Process curProcess = Process.GetCurrentProcess ();
            ProcessModule curModule = curProcess.MainModule;
            hHook = SetWindowsHookEx (APIConstansts.WH_MOUSE_LL, new HookProc (MouseHookProc), GetModuleHandle (curModule.ModuleName), 0);

            curModule.Dispose ();
            curProcess.Dispose ();

        }

        ~Mouse_Mange () {
            bool ret = UnhookWindowsHookEx (hHook);
            hHook = 0;
        }
        #endregion

        [DllImport ("user32.dll", SetLastError = true)]
        [
            return :MarshalAs (UnmanagedType.Bool)
        ]
        static extern bool GetCursorPos (out POINTex lpPoint);

        struct POINTex {
            public FIXED x;
            public FIXED y;
        }

        struct FIXED {
            public short fract;
            public short value;
        }
        private static int m_OldX = 0;
        private static int m_OldY = 0;

        public int MouseHookProc (int nCode, IntPtr wParam, IntPtr lParam) {
            //Marshall the data from the callback.
            if (nCode >= 0) {
                MouseHookStruct MyMouseHookStruct = (MouseHookStruct) Marshal.PtrToStructure (lParam, typeof (MouseHookStruct));

                POINTex temp;
                GetCursorPos (out temp);
                int X = temp.x.fract;
                int Y = temp.y.fract;

                if (m_OldX != MyMouseHookStruct.pt.x || m_OldY != MyMouseHookStruct.pt.y) {
                    m_OldX = X;
                    m_OldY = Y;
                    if (MyMouseHookStruct.hwnd != 0)
                        this.MouseClick (this, new MouseBtnWheel (MyMouseHookStruct.hwnd, 0, X, Y, 0));
                    else
                        this.MouseClick (this, new MouseBtnWheel (wParam.ToInt32 (), 0, X, Y, 0));
                }
            }

            return CallNextHookEx (hHook, nCode, wParam, lParam);
        }
    }

}