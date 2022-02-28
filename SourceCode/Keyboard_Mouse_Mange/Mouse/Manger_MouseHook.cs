using System;
using System.Runtime.InteropServices;

namespace Keyboard_Mouse_Mange {
    public class Manger_MouseHook : GlobalHook {
        public delegate void MouseEventHandler (object sender, MouseBtnWheel e);

        public event MouseEventHandler MouseDown;
        public event MouseEventHandler MouseUp;
        public event MouseEventHandler MouseMove;
        public event MouseEventHandler MouseWheel;

        public Manger_MouseHook () {
            HookType = PublicConstansts.WH_MOUSE_LL;
        }

        internal override int HookCallbackProcedure (int nCode, IntPtr wParam, IntPtr lParam) {
            PublicStruct.MouseHookStruct MyMouseHookStruct = (PublicStruct.MouseHookStruct) Marshal.PtrToStructure (lParam, typeof (PublicStruct.MouseHookStruct));

            int X = MyMouseHookStruct.pt.x;
            int Y = MyMouseHookStruct.pt.y;
            int temp;
            if (MyMouseHookStruct.hwnd != 0)
                temp = MyMouseHookStruct.hwnd;
            else
                temp = wParam.ToInt32 ();

            MouseBtnWheel.MouseButtons _MouseClick;

            _MouseClick = (MouseBtnWheel.MouseButtons) temp;

            MouseBtnWheel e = new MouseBtnWheel (_MouseClick, X, Y);

            switch (_MouseClick) {
                case MouseBtnWheel.MouseButtons.LeftDown:
                case MouseBtnWheel.MouseButtons.RightDown:
                case MouseBtnWheel.MouseButtons.MiddleDown:
                    if (MouseDown != null)
                        MouseDown (this, e);
                    break;

                case MouseBtnWheel.MouseButtons.LeftUp:
                case MouseBtnWheel.MouseButtons.RightUp:
                case MouseBtnWheel.MouseButtons.MiddleUp:
                    if (MouseUp != null)
                        MouseUp (this, e);
                    break;

                case MouseBtnWheel.MouseButtons.Move:
                    if (MouseMove != null)
                        MouseMove (this, e);
                    break;

                case MouseBtnWheel.MouseButtons.WheelDown:
                case MouseBtnWheel.MouseButtons.WheelUp:
                    if (MouseWheel != null)
                        MouseWheel (this, e);
                    break;
            }
            return PublicFunction.CallNextHookEx (hHook, nCode, wParam, lParam);
        }
    }
}