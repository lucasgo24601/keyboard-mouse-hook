using System;
using System.Windows.Forms;

namespace Keyboard_Mouse_Mange {
    public class KeyboardEvent : EventArgs {
        // 因為預設滑鼠事件並沒有滾輪上下的定義，所以自行改一個新Class

        public Keys KeyCode;
        public bool IsAlt = false;
        public bool IsControl = false;
        public bool IsShift = false;
        public bool IsCapsLock = false;
        public bool IsKeyboardDown = false;
        public string KeyValue = "";

        public KeyboardEvent (string KeyValue, bool IsAlt, bool IsControl, bool IsShift, bool IsCapsLock) {
            this.KeyValue = KeyValue;
            this.IsAlt = IsAlt;
            this.IsControl = IsControl;
            this.IsShift = IsShift;
            this.IsCapsLock = IsCapsLock;
        }

        public KeyboardEvent () {

        }

    }
}