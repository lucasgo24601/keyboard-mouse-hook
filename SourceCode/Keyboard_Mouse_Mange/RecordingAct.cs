using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Keyboard_Mouse_Mange {
    public class RecordingAct {
        public MouseBtnWheel MouseControl = new MouseBtnWheel ();
        public KeyboardEvent KeyboardControl = new KeyboardEvent ();
        public int SleepTime;

        public RecordingAct (MouseBtnWheel MouseControl, KeyboardEvent KeyboardControl, int time) {
            this.MouseControl = MouseControl;
            this.KeyboardControl = KeyboardControl;
            this.SleepTime = time;
        }
        public RecordingAct () {

        }

        public void Start () {
            if (MouseControl != null) {
                Cursor.Position = new Point (MouseControl.X, MouseControl.Y);
                switch (MouseControl.Button) {
                    case MouseBtnWheel.MouseButtons.LeftDown:
                        PublicFunction.mouse_event ((uint) PublicConstansts.MouseEventFlags.LEFTDOWN, 0, 0, 0, 0);
                        break;
                    case MouseBtnWheel.MouseButtons.LeftUp:
                        PublicFunction.mouse_event ((uint) PublicConstansts.MouseEventFlags.LEFTUP, 0, 0, 0, 0);
                        break;
                    case MouseBtnWheel.MouseButtons.RightDown:
                        PublicFunction.mouse_event ((uint) PublicConstansts.MouseEventFlags.RIGHTDOWN, 0, 0, 0, 0);
                        break;
                    case MouseBtnWheel.MouseButtons.RightUp:
                        PublicFunction.mouse_event ((uint) PublicConstansts.MouseEventFlags.RIGHTUP, 0, 0, 0, 0);
                        break;
                    case MouseBtnWheel.MouseButtons.MiddleDown:
                        PublicFunction.mouse_event ((uint) PublicConstansts.MouseEventFlags.MIDDLEDOWN, 0, 0, 0, 0);
                        break;
                    case MouseBtnWheel.MouseButtons.MiddleUp:
                        PublicFunction.mouse_event ((uint) PublicConstansts.MouseEventFlags.MIDDLEUP, 0, 0, 0, 0);
                        break;
                    default:

                        break;
                }
            }

            if (KeyboardControl != null)
                switch (KeyboardControl.IsKeyboardDown) {
                    case true:
                        PublicFunction.keybd_event (ParseKey (KeyboardControl.KeyCode), 0, 0, 0);
                        break;
                    case false:
                        PublicFunction.keybd_event (ParseKey (KeyboardControl.KeyCode), 0, 0x2, 0);
                        break;
                    default:
                        break;
                }
        }

        private byte ParseKey (Keys key) {
            switch (key) {
                case Keys.Alt:
                    return (byte) 18;
                case Keys.Control:
                    return (byte) 17;
                case Keys.Shift:
                    return (byte) 16;
                default:
                    return (byte) key;
            }
        }
    }
}