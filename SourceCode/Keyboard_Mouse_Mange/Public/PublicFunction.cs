using System;
using System.Runtime.InteropServices;

namespace Keyboard_Mouse_Mange {
    public class PublicFunction {
        public delegate int HookProc (int nCode, IntPtr wParam, IntPtr lParam); // 使用Hook必須用委派形式 ， 指定Hook處理函數為MouseHookProc

        [DllImport ("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetWindowsHookEx (int idHook, HookProc lpfn, IntPtr hInstance, uint threadId);

        [DllImport ("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern bool UnhookWindowsHookEx (int idHook);

        [DllImport ("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int CallNextHookEx (int idHook, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport ("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetModuleHandle (string lpModuleName);

        [DllImport ("user32.dll")]
        public static extern uint GetWindowThreadProcessId (IntPtr hWnd, IntPtr ProcessId);

        [DllImport ("kernel32.dll")]
        public static extern IntPtr LoadLibrary (string lpFileName);

        [DllImport ("user32.dll")]
        public static extern void mouse_event (uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        [DllImport ("user32.dll")]
        public static extern void keybd_event (byte key, byte scan, int flags, int extraInfo);

        [DllImport ("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern short GetKeyState (int vKey);

        [DllImport ("user32.dll", SetLastError = true)]
        [
            return :MarshalAs (UnmanagedType.Bool)
        ]
        public static extern bool GetCursorPos (out PublicStruct.POINTFX lpPoint);

    }
}