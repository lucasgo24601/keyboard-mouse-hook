using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Keyboard_Mouse_Mange {
    public abstract class GlobalHook {
        internal PublicFunction.HookProc HookObject;
        internal int HookType;
        internal int hHook = 0;

        #region 建構子 和 解構子

        internal GlobalHook () {
            IntPtr hInstance = PublicFunction.LoadLibrary ("user32.dll"); // 加載user32.dll動態連結庫 
            Application.ApplicationExit += new EventHandler (HookStop);
        }
        ~GlobalHook () {
            if (hHook != 0)
                PublicFunction.UnhookWindowsHookEx (hHook);
            hHook = 0;
        }

        #endregion

        #region Start 和 Stop

        public bool Start () {
            // 使用SetWindowsHookEx來達成全域狀態下也可獲取資訊方法，針對MOUSE類別
            HookObject = new PublicFunction.HookProc (HookCallbackProcedure);

            if (hHook == 0)
                hHook = PublicFunction.SetWindowsHookEx (HookType, HookObject, Marshal.GetHINSTANCE (Assembly.GetExecutingAssembly ().GetModules () [0]), 0);

            if (hHook == 0)
                return false;

            return true;
        }

        public void Stop () {
            if (hHook != 0)
                PublicFunction.UnhookWindowsHookEx (hHook);
            hHook = 0;
        }

        #endregion

        internal virtual int HookCallbackProcedure (int nCode, IntPtr wParam, IntPtr lParam) {
            // 空函數，等待繼承者重載覆寫
            return 0;
        }

        private void HookStop (object sender, EventArgs e) {
            if (hHook != 0)
                PublicFunction.UnhookWindowsHookEx (hHook);
            hHook = 0;
        }
    }
}