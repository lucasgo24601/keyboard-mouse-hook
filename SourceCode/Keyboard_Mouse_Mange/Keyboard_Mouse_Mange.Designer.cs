namespace Keyboard_Mouse_Mange
{
	partial class Keyboard_Mouse_Mange {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Keyboard_Mouse_Mange));
            this.timerCursorPos = new System.Windows.Forms.Timer(this.components);
            this.grbHook = new System.Windows.Forms.GroupBox();
            this.btnCursorPos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnKeyboardHook = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMouseHook = new Bunifu.Framework.UI.BunifuFlatButton();
            this.grbRecording = new System.Windows.Forms.GroupBox();
            this.cboStopKey = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.cboStartKey = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.btnPlay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRecording = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtStopKey = new System.Windows.Forms.TextBox();
            this.txtStartKey = new System.Windows.Forms.TextBox();
            this.lblStopKey = new System.Windows.Forms.Label();
            this.lblStartKey = new System.Windows.Forms.Label();
            this.grbRecordingShow = new System.Windows.Forms.GroupBox();
            this.lvKeyboard = new System.Windows.Forms.ListView();
            this.colEvenType_Keyboard = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKeyCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKeyChar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colShift = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAlt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colControl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvMouse = new System.Windows.Forms.ListView();
            this.colEventType_Mouse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colButton = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbHook.SuspendLayout();
            this.grbRecording.SuspendLayout();
            this.grbRecordingShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerCursorPos
            // 
            this.timerCursorPos.Tick += new System.EventHandler(this.TimerCursorPos_Tick);
            // 
            // grbHook
            // 
            this.grbHook.Controls.Add(this.btnCursorPos);
            this.grbHook.Controls.Add(this.btnKeyboardHook);
            this.grbHook.Controls.Add(this.btnMouseHook);
            this.grbHook.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.grbHook.Location = new System.Drawing.Point(12, 12);
            this.grbHook.Name = "grbHook";
            this.grbHook.Size = new System.Drawing.Size(321, 115);
            this.grbHook.TabIndex = 6;
            this.grbHook.TabStop = false;
            this.grbHook.Text = "Hook";
            // 
            // btnCursorPos
            // 
            this.btnCursorPos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCursorPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCursorPos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCursorPos.BorderRadius = 0;
            this.btnCursorPos.ButtonText = "CursorPos Start";
            this.btnCursorPos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCursorPos.DisabledColor = System.Drawing.Color.Gray;
            this.btnCursorPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCursorPos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCursorPos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCursorPos.Iconimage")));
            this.btnCursorPos.Iconimage_right = null;
            this.btnCursorPos.Iconimage_right_Selected = null;
            this.btnCursorPos.Iconimage_Selected = null;
            this.btnCursorPos.IconMarginLeft = 0;
            this.btnCursorPos.IconMarginRight = 0;
            this.btnCursorPos.IconRightVisible = true;
            this.btnCursorPos.IconRightZoom = 0D;
            this.btnCursorPos.IconVisible = false;
            this.btnCursorPos.IconZoom = 90D;
            this.btnCursorPos.IsTab = false;
            this.btnCursorPos.Location = new System.Drawing.Point(7, 73);
            this.btnCursorPos.Margin = new System.Windows.Forms.Padding(4);
            this.btnCursorPos.Name = "btnCursorPos";
            this.btnCursorPos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCursorPos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCursorPos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCursorPos.selected = false;
            this.btnCursorPos.Size = new System.Drawing.Size(308, 35);
            this.btnCursorPos.TabIndex = 11;
            this.btnCursorPos.Text = "CursorPos Start";
            this.btnCursorPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCursorPos.Textcolor = System.Drawing.Color.White;
            this.btnCursorPos.TextFont = new System.Drawing.Font("Consolas", 12.25F);
            this.btnCursorPos.Click += new System.EventHandler(this.btnCursorPos_Click);
            // 
            // btnKeyboardHook
            // 
            this.btnKeyboardHook.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnKeyboardHook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnKeyboardHook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKeyboardHook.BorderRadius = 0;
            this.btnKeyboardHook.ButtonText = "Keyboard Start";
            this.btnKeyboardHook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeyboardHook.DisabledColor = System.Drawing.Color.Gray;
            this.btnKeyboardHook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnKeyboardHook.Iconcolor = System.Drawing.Color.Transparent;
            this.btnKeyboardHook.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnKeyboardHook.Iconimage")));
            this.btnKeyboardHook.Iconimage_right = null;
            this.btnKeyboardHook.Iconimage_right_Selected = null;
            this.btnKeyboardHook.Iconimage_Selected = null;
            this.btnKeyboardHook.IconMarginLeft = 0;
            this.btnKeyboardHook.IconMarginRight = 0;
            this.btnKeyboardHook.IconRightVisible = true;
            this.btnKeyboardHook.IconRightZoom = 0D;
            this.btnKeyboardHook.IconVisible = false;
            this.btnKeyboardHook.IconZoom = 90D;
            this.btnKeyboardHook.IsTab = false;
            this.btnKeyboardHook.Location = new System.Drawing.Point(165, 30);
            this.btnKeyboardHook.Margin = new System.Windows.Forms.Padding(4);
            this.btnKeyboardHook.Name = "btnKeyboardHook";
            this.btnKeyboardHook.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnKeyboardHook.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnKeyboardHook.OnHoverTextColor = System.Drawing.Color.White;
            this.btnKeyboardHook.selected = false;
            this.btnKeyboardHook.Size = new System.Drawing.Size(150, 35);
            this.btnKeyboardHook.TabIndex = 10;
            this.btnKeyboardHook.Text = "Keyboard Start";
            this.btnKeyboardHook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKeyboardHook.Textcolor = System.Drawing.Color.White;
            this.btnKeyboardHook.TextFont = new System.Drawing.Font("Consolas", 12.25F);
            this.btnKeyboardHook.Click += new System.EventHandler(this.btnKeyboardHook_Click);
            // 
            // btnMouseHook
            // 
            this.btnMouseHook.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMouseHook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMouseHook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMouseHook.BorderRadius = 0;
            this.btnMouseHook.ButtonText = "Mouse Start";
            this.btnMouseHook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMouseHook.DisabledColor = System.Drawing.Color.Gray;
            this.btnMouseHook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnMouseHook.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMouseHook.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMouseHook.Iconimage")));
            this.btnMouseHook.Iconimage_right = null;
            this.btnMouseHook.Iconimage_right_Selected = null;
            this.btnMouseHook.Iconimage_Selected = null;
            this.btnMouseHook.IconMarginLeft = 0;
            this.btnMouseHook.IconMarginRight = 0;
            this.btnMouseHook.IconRightVisible = true;
            this.btnMouseHook.IconRightZoom = 0D;
            this.btnMouseHook.IconVisible = false;
            this.btnMouseHook.IconZoom = 90D;
            this.btnMouseHook.IsTab = false;
            this.btnMouseHook.Location = new System.Drawing.Point(7, 30);
            this.btnMouseHook.Margin = new System.Windows.Forms.Padding(4);
            this.btnMouseHook.Name = "btnMouseHook";
            this.btnMouseHook.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMouseHook.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnMouseHook.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMouseHook.selected = false;
            this.btnMouseHook.Size = new System.Drawing.Size(150, 35);
            this.btnMouseHook.TabIndex = 9;
            this.btnMouseHook.Text = "Mouse Start";
            this.btnMouseHook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMouseHook.Textcolor = System.Drawing.Color.White;
            this.btnMouseHook.TextFont = new System.Drawing.Font("Consolas", 12.25F);
            this.btnMouseHook.Click += new System.EventHandler(this.btnMouseHook_Click);
            // 
            // grbRecording
            // 
            this.grbRecording.Controls.Add(this.cboStopKey);
            this.grbRecording.Controls.Add(this.cboStartKey);
            this.grbRecording.Controls.Add(this.btnPlay);
            this.grbRecording.Controls.Add(this.btnRecording);
            this.grbRecording.Controls.Add(this.txtStopKey);
            this.grbRecording.Controls.Add(this.txtStartKey);
            this.grbRecording.Controls.Add(this.lblStopKey);
            this.grbRecording.Controls.Add(this.lblStartKey);
            this.grbRecording.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRecording.Location = new System.Drawing.Point(12, 133);
            this.grbRecording.Name = "grbRecording";
            this.grbRecording.Size = new System.Drawing.Size(322, 166);
            this.grbRecording.TabIndex = 7;
            this.grbRecording.TabStop = false;
            this.grbRecording.Text = "Recording";
            // 
            // cboStopKey
            // 
            this.cboStopKey.BackColor = System.Drawing.Color.Transparent;
            this.cboStopKey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cboStopKey.BackgroundImage")));
            this.cboStopKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cboStopKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboStopKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboStopKey.Location = new System.Drawing.Point(7, 122);
            this.cboStopKey.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cboStopKey.Name = "cboStopKey";
            this.cboStopKey.OffColor = System.Drawing.Color.Gray;
            this.cboStopKey.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.cboStopKey.Size = new System.Drawing.Size(35, 20);
            this.cboStopKey.TabIndex = 14;
            this.cboStopKey.Value = false;
            this.cboStopKey.OnValueChange += new System.EventHandler(this.cboSwitchKey_CheckedChanged);
            // 
            // cboStartKey
            // 
            this.cboStartKey.BackColor = System.Drawing.Color.Transparent;
            this.cboStartKey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cboStartKey.BackgroundImage")));
            this.cboStartKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cboStartKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboStartKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboStartKey.Location = new System.Drawing.Point(7, 90);
            this.cboStartKey.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cboStartKey.Name = "cboStartKey";
            this.cboStartKey.OffColor = System.Drawing.Color.Gray;
            this.cboStartKey.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.cboStartKey.Size = new System.Drawing.Size(35, 20);
            this.cboStartKey.TabIndex = 9;
            this.cboStartKey.Value = false;
            this.cboStartKey.OnValueChange += new System.EventHandler(this.cboSwitchKey_CheckedChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.BorderRadius = 0;
            this.btnPlay.ButtonText = "Play";
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.DisabledColor = System.Drawing.Color.Gray;
            this.btnPlay.Enabled = false;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPlay.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPlay.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPlay.Iconimage")));
            this.btnPlay.Iconimage_right = null;
            this.btnPlay.Iconimage_right_Selected = null;
            this.btnPlay.Iconimage_Selected = null;
            this.btnPlay.IconMarginLeft = 0;
            this.btnPlay.IconMarginRight = 0;
            this.btnPlay.IconRightVisible = true;
            this.btnPlay.IconRightZoom = 0D;
            this.btnPlay.IconVisible = false;
            this.btnPlay.IconZoom = 90D;
            this.btnPlay.IsTab = false;
            this.btnPlay.Location = new System.Drawing.Point(7, 37);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPlay.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPlay.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPlay.selected = false;
            this.btnPlay.Size = new System.Drawing.Size(150, 35);
            this.btnPlay.TabIndex = 13;
            this.btnPlay.Text = "Play";
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPlay.Textcolor = System.Drawing.Color.White;
            this.btnPlay.TextFont = new System.Drawing.Font("Consolas", 12.25F);
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnRecording
            // 
            this.btnRecording.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRecording.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRecording.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecording.BorderRadius = 0;
            this.btnRecording.ButtonText = "Start";
            this.btnRecording.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecording.DisabledColor = System.Drawing.Color.Gray;
            this.btnRecording.Enabled = false;
            this.btnRecording.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnRecording.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRecording.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRecording.Iconimage")));
            this.btnRecording.Iconimage_right = null;
            this.btnRecording.Iconimage_right_Selected = null;
            this.btnRecording.Iconimage_Selected = null;
            this.btnRecording.IconMarginLeft = 0;
            this.btnRecording.IconMarginRight = 0;
            this.btnRecording.IconRightVisible = true;
            this.btnRecording.IconRightZoom = 0D;
            this.btnRecording.IconVisible = false;
            this.btnRecording.IconZoom = 90D;
            this.btnRecording.IsTab = false;
            this.btnRecording.Location = new System.Drawing.Point(165, 37);
            this.btnRecording.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
            this.btnRecording.Name = "btnRecording";
            this.btnRecording.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRecording.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRecording.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRecording.selected = false;
            this.btnRecording.Size = new System.Drawing.Size(150, 35);
            this.btnRecording.TabIndex = 12;
            this.btnRecording.Text = "Start";
            this.btnRecording.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRecording.Textcolor = System.Drawing.Color.White;
            this.btnRecording.TextFont = new System.Drawing.Font("Consolas", 12.25F);
            this.btnRecording.Click += new System.EventHandler(this.btnRecording_Click);
            // 
            // txtStopKey
            // 
            this.txtStopKey.Enabled = false;
            this.txtStopKey.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.txtStopKey.Location = new System.Drawing.Point(173, 121);
            this.txtStopKey.Name = "txtStopKey";
            this.txtStopKey.Size = new System.Drawing.Size(142, 27);
            this.txtStopKey.TabIndex = 8;
            this.txtStopKey.Text = "null";
            this.txtStopKey.TextChanged += new System.EventHandler(this.txtStartKey_TextChanged);
            // 
            // txtStartKey
            // 
            this.txtStartKey.Enabled = false;
            this.txtStartKey.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.txtStartKey.Location = new System.Drawing.Point(173, 87);
            this.txtStartKey.Name = "txtStartKey";
            this.txtStartKey.Size = new System.Drawing.Size(142, 27);
            this.txtStartKey.TabIndex = 7;
            this.txtStartKey.Text = "null";
            this.txtStartKey.TextChanged += new System.EventHandler(this.txtStartKey_TextChanged);
            // 
            // lblStopKey
            // 
            this.lblStopKey.AutoSize = true;
            this.lblStopKey.Enabled = false;
            this.lblStopKey.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.lblStopKey.Location = new System.Drawing.Point(50, 122);
            this.lblStopKey.Name = "lblStopKey";
            this.lblStopKey.Size = new System.Drawing.Size(108, 20);
            this.lblStopKey.TabIndex = 6;
            this.lblStopKey.Text = "Stop Key : ";
            // 
            // lblStartKey
            // 
            this.lblStartKey.AutoSize = true;
            this.lblStartKey.Enabled = false;
            this.lblStartKey.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.lblStartKey.Location = new System.Drawing.Point(50, 90);
            this.lblStartKey.Name = "lblStartKey";
            this.lblStartKey.Size = new System.Drawing.Size(117, 20);
            this.lblStartKey.TabIndex = 5;
            this.lblStartKey.Text = "Start Key : ";
            // 
            // grbRecordingShow
            // 
            this.grbRecordingShow.Controls.Add(this.lvKeyboard);
            this.grbRecordingShow.Controls.Add(this.lvMouse);
            this.grbRecordingShow.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.grbRecordingShow.Location = new System.Drawing.Point(340, 12);
            this.grbRecordingShow.Name = "grbRecordingShow";
            this.grbRecordingShow.Size = new System.Drawing.Size(436, 287);
            this.grbRecordingShow.TabIndex = 8;
            this.grbRecordingShow.TabStop = false;
            this.grbRecordingShow.Text = "Recording";
            // 
            // lvKeyboard
            // 
            this.lvKeyboard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEvenType_Keyboard,
            this.colKeyCode,
            this.colKeyChar,
            this.colShift,
            this.colAlt,
            this.colControl});
            this.lvKeyboard.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvKeyboard.HideSelection = false;
            this.lvKeyboard.Location = new System.Drawing.Point(6, 139);
            this.lvKeyboard.Name = "lvKeyboard";
            this.lvKeyboard.Size = new System.Drawing.Size(424, 140);
            this.lvKeyboard.TabIndex = 10;
            this.lvKeyboard.UseCompatibleStateImageBehavior = false;
            this.lvKeyboard.View = System.Windows.Forms.View.Details;
            // 
            // colEvenType_Keyboard
            // 
            this.colEvenType_Keyboard.Text = "EventType";
            this.colEvenType_Keyboard.Width = 90;
            // 
            // colKeyCode
            // 
            this.colKeyCode.Text = "KeyCode";
            this.colKeyCode.Width = 80;
            // 
            // colKeyChar
            // 
            this.colKeyChar.Text = "KeyChar";
            this.colKeyChar.Width = 79;
            // 
            // colShift
            // 
            this.colShift.Text = "Shift";
            this.colShift.Width = 56;
            // 
            // colAlt
            // 
            this.colAlt.Text = "Alt";
            this.colAlt.Width = 51;
            // 
            // colControl
            // 
            this.colControl.Text = "Control";
            this.colControl.Width = 62;
            // 
            // lvMouse
            // 
            this.lvMouse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEventType_Mouse,
            this.colButton,
            this.colX,
            this.colY});
            this.lvMouse.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMouse.HideSelection = false;
            this.lvMouse.Location = new System.Drawing.Point(6, 21);
            this.lvMouse.Name = "lvMouse";
            this.lvMouse.Size = new System.Drawing.Size(424, 112);
            this.lvMouse.TabIndex = 9;
            this.lvMouse.UseCompatibleStateImageBehavior = false;
            this.lvMouse.View = System.Windows.Forms.View.Details;
            // 
            // colEventType_Mouse
            // 
            this.colEventType_Mouse.Text = "EventType";
            this.colEventType_Mouse.Width = 133;
            // 
            // colButton
            // 
            this.colButton.Text = "Button";
            this.colButton.Width = 123;
            // 
            // colX
            // 
            this.colX.Text = "X";
            this.colX.Width = 81;
            // 
            // colY
            // 
            this.colY.Text = "Y";
            this.colY.Width = 83;
            // 
            // Keyboard_Mouse_Mange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 308);
            this.Controls.Add(this.grbRecordingShow);
            this.Controls.Add(this.grbRecording);
            this.Controls.Add(this.grbHook);
            this.KeyPreview = true;
            this.Name = "Keyboard_Mouse_Mange";
            this.Text = "Menger¡GKeyboard And Mouse Demo";
            this.grbHook.ResumeLayout(false);
            this.grbRecording.ResumeLayout(false);
            this.grbRecording.PerformLayout();
            this.grbRecordingShow.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Timer timerCursorPos;
        private System.Windows.Forms.GroupBox grbHook;
        private System.Windows.Forms.GroupBox grbRecording;
        private System.Windows.Forms.GroupBox grbRecordingShow;
        private System.Windows.Forms.ListView lvKeyboard;
        private System.Windows.Forms.ColumnHeader colEvenType_Keyboard;
        private System.Windows.Forms.ColumnHeader colKeyCode;
        private System.Windows.Forms.ColumnHeader colKeyChar;
        private System.Windows.Forms.ColumnHeader colShift;
        private System.Windows.Forms.ColumnHeader colAlt;
        private System.Windows.Forms.ColumnHeader colControl;
        private System.Windows.Forms.ListView lvMouse;
        private System.Windows.Forms.ColumnHeader colEventType_Mouse;
        private System.Windows.Forms.ColumnHeader colButton;
        private System.Windows.Forms.ColumnHeader colX;
        private System.Windows.Forms.ColumnHeader colY;
        private System.Windows.Forms.TextBox txtStopKey;
        private System.Windows.Forms.TextBox txtStartKey;
        private System.Windows.Forms.Label lblStopKey;
        private System.Windows.Forms.Label lblStartKey;
        private Bunifu.Framework.UI.BunifuFlatButton btnCursorPos;
        private Bunifu.Framework.UI.BunifuFlatButton btnKeyboardHook;
        private Bunifu.Framework.UI.BunifuFlatButton btnMouseHook;
        private Bunifu.Framework.UI.BunifuFlatButton btnPlay;
        private Bunifu.Framework.UI.BunifuFlatButton btnRecording;
        private Bunifu.Framework.UI.BunifuiOSSwitch cboStopKey;
        private Bunifu.Framework.UI.BunifuiOSSwitch cboStartKey;
    }
}

