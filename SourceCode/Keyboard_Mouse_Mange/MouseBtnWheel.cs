using System;

namespace Keyboard_Mouse_Mange {
    class MouseBtnWheel : EventArgs {
        public MouseBtnWheel (int button, int clicks, int x, int y, int delta) {
            Button = (MouseButtons) button;
            X = x;
            Y = y;
        }
        public MouseButtons Button { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public enum MouseButtons {
            Move = APIConstansts.WM_MOUSEMOVE,
            LeftDown = APIConstansts.WM_LBUTTONDOWN,
            LeftUp = APIConstansts.WM_LBUTTONUP,
            RightDown = APIConstansts.WM_RBUTTONDOWN,
            RightUp = APIConstansts.WM_RBUTTONUP,
            MiddleDown = APIConstansts.WM_MBUTTONDOWN,
            MiddleUp = APIConstansts.WM_MBUTTONUP,
            WheelDown = -7864320,
            WheelUp = 7864320,
        }
    }
}