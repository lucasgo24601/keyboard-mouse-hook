using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Keyboard_Mouse_Mange {
    class Manger_KeyboardHook : GlobalHook {
        public delegate void KeyEventHandler (object sender, KeyboardEvent e);

        public event KeyEventHandler KeyDown;
        public event KeyEventHandler KeyUp;

        public Manger_KeyboardHook () {
            HookType = PublicConstansts.WH_KEYBOARD_LL;
        }

        internal override int HookCallbackProcedure (int nCode, IntPtr wParam, IntPtr lParam) {
            PublicStruct.KeyboardHookStruct keyboardHookStruct = (PublicStruct.KeyboardHookStruct) Marshal.PtrToStructure (lParam, typeof (PublicStruct.KeyboardHookStruct));

            bool IsControl = ((PublicFunction.GetKeyState (PublicConstansts.VK_LSHIFT) & 0x80) != 0) ||
                ((PublicFunction.GetKeyState (PublicConstansts.VK_RCONTROL) & 0x80) != 0);

            bool IsShift = ((PublicFunction.GetKeyState (PublicConstansts.VK_LSHIFT) & 0x80) != 0) ||
                ((PublicFunction.GetKeyState (PublicConstansts.VK_RSHIFT) & 0x80) != 0);

            bool IsAlt = ((PublicFunction.GetKeyState (PublicConstansts.VK_LALT) & 0x80) != 0) ||
                ((PublicFunction.GetKeyState (PublicConstansts.VK_RALT) & 0x80) != 0);

            bool IsCapsLock = (PublicFunction.GetKeyState (PublicConstansts.VK_CAPITAL) != 0);

            KeyboardEvent e = new KeyboardEvent ();
            e.IsAlt = IsAlt;
            e.IsShift = IsShift;
            e.IsControl = IsControl;
            e.IsCapsLock = IsCapsLock;
            Keys key = (Keys) keyboardHookStruct.vkCode; // key = ���e��������
            e.KeyCode = key;

            if (IsCapsLock)
                e.KeyValue = key.ToString ().ToUpper ();
            else
                e.KeyValue = key.ToString ().ToLower ();

            if ((wParam.ToInt32 () == PublicConstansts.WM_KEYDOWN || wParam.ToInt32 () == PublicConstansts.WM_SYSKEYDOWN) & KeyDown != null) {
                e.IsKeyboardDown = true;
                KeyDown (this, e);
            } else if ((wParam.ToInt32 () == PublicConstansts.WM_KEYUP || wParam.ToInt32 () == PublicConstansts.WM_SYSKEYUP) & KeyUp != null) {
                e.IsKeyboardDown = false;
                KeyUp (this, e);
            }

            return PublicFunction.CallNextHookEx (hHook, nCode, wParam, lParam);
        }
    }
}