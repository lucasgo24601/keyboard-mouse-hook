using System;

namespace Keyboard_Mouse_Mange {
    public class MouseBtnWheel : EventArgs {
        // 因為預設滑鼠事件並沒有滾輪上下的定義，所以自行改一個新Class

        public MouseBtnWheel (MouseButtons button, int x, int y) {
            Button = button;
            X = x;
            Y = y;
        }
        public MouseBtnWheel () { }

        public MouseButtons Button = MouseButtons.None;
        public int X = -24601;
        public int Y = -24601;

        public enum MouseButtons {
            None = 0,
            Move = PublicConstansts.WM_MOUSEMOVE,
            LeftDown = PublicConstansts.WM_LBUTTONDOWN,
            LeftUp = PublicConstansts.WM_LBUTTONUP,
            RightDown = PublicConstansts.WM_RBUTTONDOWN,
            RightUp = PublicConstansts.WM_RBUTTONUP,
            MiddleDown = PublicConstansts.WM_MBUTTONDOWN,
            MiddleUp = PublicConstansts.WM_MBUTTONUP,
            WheelDown = -7864320,
            WheelUp = 7864320,
        }
    }
}