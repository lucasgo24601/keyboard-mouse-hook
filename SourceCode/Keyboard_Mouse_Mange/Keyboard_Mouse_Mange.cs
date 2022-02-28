using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace Keyboard_Mouse_Mange {
    public partial class Keyboard_Mouse_Mange : Form {
        private Manger_KeyboardHook Keyboard;
        private Manger_MouseHook Mouse;
        private List<RecordingAct> MouseKeyboardRecording;

        private bool isRecoder = false;
        private int lastTimeRecorded = 0;

        public Keyboard_Mouse_Mange () {
            InitializeComponent ();
            CheckForIllegalCrossThreadCalls = false;
        }

        #region Mouse Hook 

        private void btnMouseHook_Click (object sender, EventArgs e) {
            if (btnMouseHook.Text == "Mouse Start") {
                Mouse = new Manger_MouseHook ();
                Mouse.Start ();
                Mouse.MouseMove += Mouse_MouseMove;
                Mouse.MouseDown += Mouse_MouseDown;
                Mouse.MouseWheel += Mouse_MouseWheel;
                btnMouseHook.Text = "Mouse Stop";
            } else if (btnMouseHook.Text == "Mouse Stop") {
                Mouse.Stop ();
                btnMouseHook.Text = "Mouse Start";
            }
        }

        private void Mouse_MouseMove (object sender, MouseBtnWheel e) {
            Trace.WriteLine ("Move : " + e.Button + " -- X,Y = " + e.X + " , " + e.Y);
            AddMouseEvent ("MouseMove", e.Button.ToString (), e.X.ToString (), e.Y.ToString ());

            if (isRecoder) {
                MouseKeyboardRecording.Add (new RecordingAct (e, new KeyboardEvent (), Environment.TickCount - lastTimeRecorded));
                lastTimeRecorded = Environment.TickCount;
            }
        }

        private void Mouse_MouseDown (object sender, MouseBtnWheel e) {
            Trace.WriteLine ("Down : " + e.Button + " -- X,Y = " + e.X + " , " + e.Y);
            AddMouseEvent ("MouseDown", e.Button.ToString (), e.X.ToString (), e.Y.ToString ());
            if (isRecoder) {
                MouseKeyboardRecording.Add (new RecordingAct (e, new KeyboardEvent (), Environment.TickCount - lastTimeRecorded));
                lastTimeRecorded = Environment.TickCount;
            }
        }

        private void Mouse_MouseWheel (object sender, MouseBtnWheel e) {
            Trace.WriteLine ("Wheel : " + e.Button + " -- X,Y = " + e.X + " , " + e.Y);
            AddMouseEvent ("MouseWheel", e.Button.ToString (), e.X.ToString (), e.Y.ToString ());
            if (isRecoder) {
                MouseKeyboardRecording.Add (new RecordingAct (e, new KeyboardEvent (), Environment.TickCount - lastTimeRecorded));
                lastTimeRecorded = Environment.TickCount;
            }
        }

        #endregion

        #region CursorPos Button

        private short old_X = -24601;
        private short old_Y = -24601;

        private void btnCursorPos_Click (object sender, EventArgs e) {
            if (btnCursorPos.Text == "CursorPos Start")
                btnCursorPos.Text = "CursorPos Stop";
            else
                btnCursorPos.Text = "CursorPos Start";

            timerCursorPos.Enabled = !timerCursorPos.Enabled;
        }

        private void TimerCursorPos_Tick (object sender, EventArgs e) {
            PublicStruct.POINTFX p;
            if (PublicFunction.GetCursorPos (out p)) {
                if (p.X.fract != old_X | p.Y.fract != old_Y) {
                    old_X = p.X.fract;
                    old_Y = p.Y.fract;
                    AddMouseEvent ("MouseMove", "GetCursorPos", p.X.fract.ToString (), p.Y.fract.ToString ());
                }
                Trace.WriteLine (Convert.ToString (p.X.fract) + ";" + Convert.ToString (p.Y.fract));
            }
        }
        #endregion

        #region Keyboard Hook 

        private void btnKeyboardHook_Click (object sender, EventArgs e) {
            if (btnKeyboardHook.Text == "Keyboard Start") {
                Keyboard = new Manger_KeyboardHook ();
                Keyboard.Start ();
                Keyboard.KeyDown += Keyboard_KeyDown;
                btnKeyboardHook.Text = "Keyboard Stop";
            } else if (btnKeyboardHook.Text == "Keyboard Stop") {
                Keyboard.Stop ();
                btnKeyboardHook.Text = "Keyboard Start";
            }
        }

        private void Keyboard_KeyDown (object sender, KeyboardEvent e) {
            Trace.WriteLine ("Keyboard : " + e.KeyValue);
            Trace.WriteLine ("Alt = " + e.IsAlt);
            Trace.WriteLine ("Control = " + e.IsControl);
            Trace.WriteLine ("Shift = " + e.IsShift);
            Trace.WriteLine ("CapsLock = " + e.IsCapsLock);
            AddKeyboardEvent ("KeyDown", e.KeyCode.ToString (), e.KeyValue, e.IsShift.ToString (), e.IsAlt.ToString (), e.IsControl.ToString ());
            if (isRecoder) {
                MouseKeyboardRecording.Add (new RecordingAct (new MouseBtnWheel (), e, Environment.TickCount - lastTimeRecorded));
                lastTimeRecorded = Environment.TickCount;
            }
        }

        #endregion

        #region UI Updata

        private void AddMouseEvent (string eventType, string button, string x, string y) {
            lvMouse.Items.Insert (0,
                new ListViewItem (
                    new string[] {
                        eventType,
                        button,
                        x,
                        y,
                    }));
        }

        private void AddKeyboardEvent (string eventType, string keyCode, string keyChar, string shift, string alt, string control) {
            if (txtStartKey.Text == keyChar & btnRecording.Text.Contains ("Start"))
                btnRecording_Click (null, null);
            else if (txtStopKey.Text == keyChar & btnRecording.Text.Contains ("Stop"))
                btnRecording_Click (null, null);

            Control nowPoint = GetFocusedControl ();

            if (nowPoint.Name == "txtStartKey") {
                if (cboStartKey.Value & eventType == "KeyDown" & keyChar != "delete" & txtStopKey.Text != keyChar)
                    txtStartKey.Text = keyChar;
            } else {
                if (cboStopKey.Value & eventType == "KeyDown" & keyChar != "delete" & keyChar != txtStartKey.Text)
                    txtStopKey.Text = keyChar;
            }

            lvKeyboard.Items.Insert (0,
                new ListViewItem (
                    new string[] {
                        eventType,
                        keyCode,
                        keyChar,
                        shift,
                        alt,
                        control
                    }));
        }
        #endregion

        private void btnRecording_Click (object sender, EventArgs e) {
            if (btnRecording.Text == "Start") {
                if (btnMouseHook.Text == "Mouse Start")
                    btnMouseHook_Click (null, null);

                if (btnKeyboardHook.Text == "Keyboard Start")
                    btnKeyboardHook_Click (null, null);

                MouseKeyboardRecording = new List<RecordingAct> ();
                lastTimeRecorded = Environment.TickCount;
                isRecoder = true;
                btnRecording.Text = "Stop";
            } else if (btnRecording.Text == "Stop") {
                if (btnMouseHook.Text == "Mouse Stop")
                    btnMouseHook_Click (null, null);

                if (btnKeyboardHook.Text == "Keyboard Stop")
                    btnKeyboardHook_Click (null, null);

                isRecoder = false;
                btnRecording.Text = "Start";
            }
        }

        private void btnPlay_Click (object sender, EventArgs e) {
            isRecoder = false;

            if (btnRecording.Text.Contains ("Stop"))
                btnRecording_Click (null, null);

            Timeout (1);

            if (MouseKeyboardRecording == null) {
                MessageBox.Show ("is not recording yet");
                return;
            }

            foreach (var RecordingPoint in MouseKeyboardRecording) {
                Thread.Sleep (RecordingPoint.SleepTime);
                RecordingPoint.Start ();
            }
        }

        private void cboSwitchKey_CheckedChanged (object sender, EventArgs e) {
            BunifuiOSSwitch temp = (BunifuiOSSwitch) sender;

            if (temp != cboStartKey && temp.Value != cboStartKey.Value)
                cboStartKey.Value = temp.Value;

            if (temp != cboStopKey && temp.Value != cboStopKey.Value)
                cboStopKey.Value = temp.Value;

            lblStartKey.Enabled = temp.Value;
            txtStartKey.Enabled = temp.Value;

            lblStopKey.Enabled = temp.Value;
            txtStopKey.Enabled = temp.Value;

            btnPlay.Enabled = temp.Value;
            btnRecording.Enabled = temp.Value;

            if (temp.Value == true) {
                if (btnKeyboardHook.Text.Contains ("Start"))
                    btnKeyboardHook_Click (null, null);
            } else {
                if (btnKeyboardHook.Text.Contains ("Stop"))
                    btnKeyboardHook_Click (null, null);
            }
        }

        private void txtStartKey_TextChanged (object sender, EventArgs e) {
            TextBox temp = sender as TextBox;

            if (temp.Text.Length == 0)
                btnKeyboardHook.Enabled = true;
        }

        #region Timeout

        private int TimerCount = 0;

        private void Timeout (int count) {
            TimerCount = count + 1;
            AutoResetEvent AutoResetEvent = new AutoResetEvent (false); //«Å§i¤@­Ó°õ¦æÄò¤§¶¡µo°e«H¸¹ªºª«¥ó
            TimerCallback TimerCallback = CheckStatus; //timer°õ¦æªº¨ç¼Æ©e¬£
            System.Threading.Timer Timer = new System.Threading.Timer (TimerCallback, AutoResetEvent, 0, 1000); //©µ¿ð0.5¬í«á¶}©l¨C¤@¬íÄ²µo
            AutoResetEvent.WaitOne (); //hold¦í¥Ø«e¥D°õ¦æºü¡Aª½¨ì°Æ°õ¦æºü(Timer)©e¬£ªº¨Æ¥ó(CheckStatus)¦P·N(AutoResetEvent.Set();)¥D°õ¦æºü¤~¥i¥H¦æ°Ê
            Timer.Dispose (); //¨ú®ø°Æ°õ¦æÄòtimer°Ê§@
        }

        public void CheckStatus (Object stateInfo) {
            AutoResetEvent autoEvent = (AutoResetEvent) stateInfo; //autoEventª«¥ó¥Î©ó¶Ç°e°T®§µ¹¥D°õ¦æÄò((AutoResetEvent)stateInfo)
            if (--TimerCount == 0)
                autoEvent.Set (); //°õ¦æWaitOne°õ¦æºü(Åýµ¥­ÔªºWaitOne°õ¦æºüÄ~Äò°õ¦æ)
        }

        #endregion

        #region DLL import
        [DllImport ("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Winapi)]

        internal static extern IntPtr GetFocus ();
        private Control GetFocusedControl () {
            Control focusedControl = null;
            IntPtr focusedHandle = GetFocus ();

            if (focusedHandle != IntPtr.Zero)
                focusedControl = Control.FromChildHandle (focusedHandle);

            return focusedControl;
        }
        #endregion
    }
}