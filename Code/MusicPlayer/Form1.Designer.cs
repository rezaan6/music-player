namespace MusicPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.playbtn = new System.Windows.Forms.Button();
            this.pausebtn = new System.Windows.Forms.Button();
            this.stopbtn = new System.Windows.Forms.Button();
            this.resumebtn = new System.Windows.Forms.Button();
            this.fastforwardbtn = new System.Windows.Forms.Button();
            this.startbtn = new System.Windows.Forms.Button();
            this.previousbtn = new System.Windows.Forms.Button();
            this.nextbtn = new System.Windows.Forms.Button();
            this.endbtn = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.lbl_duration = new System.Windows.Forms.Label();
            this.lblduration = new System.Windows.Forms.Label();
            this.TimerTick = new System.Windows.Forms.CheckBox();
            this.volumeScroll = new System.Windows.Forms.TrackBar();
            this.addbtn = new System.Windows.Forms.Button();
            this.Ltb_Musics = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.sortbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.newbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.searchtxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeScroll)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(37, 221);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(356, 45);
            this.Player.TabIndex = 0;
            this.Player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Player_PlayStateChange);
            this.Player.Enter += new System.EventHandler(this.Player_Enter);
            // 
            // playbtn
            // 
            this.playbtn.Location = new System.Drawing.Point(62, 108);
            this.playbtn.Name = "playbtn";
            this.playbtn.Size = new System.Drawing.Size(75, 23);
            this.playbtn.TabIndex = 1;
            this.playbtn.Text = "Play";
            this.playbtn.UseVisualStyleBackColor = true;
            this.playbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pausebtn
            // 
            this.pausebtn.Location = new System.Drawing.Point(170, 108);
            this.pausebtn.Name = "pausebtn";
            this.pausebtn.Size = new System.Drawing.Size(75, 23);
            this.pausebtn.TabIndex = 2;
            this.pausebtn.Text = "Pause";
            this.pausebtn.UseVisualStyleBackColor = true;
            this.pausebtn.Click += new System.EventHandler(this.pausebtn_Click);
            // 
            // stopbtn
            // 
            this.stopbtn.Location = new System.Drawing.Point(274, 108);
            this.stopbtn.Name = "stopbtn";
            this.stopbtn.Size = new System.Drawing.Size(75, 23);
            this.stopbtn.TabIndex = 3;
            this.stopbtn.Text = "Stop";
            this.stopbtn.UseVisualStyleBackColor = true;
            this.stopbtn.Click += new System.EventHandler(this.stopbtn_Click);
            // 
            // resumebtn
            // 
            this.resumebtn.Location = new System.Drawing.Point(105, 176);
            this.resumebtn.Name = "resumebtn";
            this.resumebtn.Size = new System.Drawing.Size(75, 23);
            this.resumebtn.TabIndex = 4;
            this.resumebtn.Text = "Resume";
            this.resumebtn.UseVisualStyleBackColor = true;
            this.resumebtn.Click += new System.EventHandler(this.resumebtn_Click);
            // 
            // fastforwardbtn
            // 
            this.fastforwardbtn.Location = new System.Drawing.Point(234, 176);
            this.fastforwardbtn.Name = "fastforwardbtn";
            this.fastforwardbtn.Size = new System.Drawing.Size(75, 23);
            this.fastforwardbtn.TabIndex = 5;
            this.fastforwardbtn.Text = "FastForward";
            this.fastforwardbtn.UseVisualStyleBackColor = true;
            this.fastforwardbtn.Click += new System.EventHandler(this.fastforwardbtn_Click);
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(12, 257);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(75, 23);
            this.startbtn.TabIndex = 6;
            this.startbtn.Text = "<<";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // previousbtn
            // 
            this.previousbtn.Location = new System.Drawing.Point(105, 257);
            this.previousbtn.Name = "previousbtn";
            this.previousbtn.Size = new System.Drawing.Size(75, 23);
            this.previousbtn.TabIndex = 7;
            this.previousbtn.Text = "<";
            this.previousbtn.UseVisualStyleBackColor = true;
            this.previousbtn.Click += new System.EventHandler(this.previousbtn_Click);
            // 
            // nextbtn
            // 
            this.nextbtn.Location = new System.Drawing.Point(234, 257);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(75, 23);
            this.nextbtn.TabIndex = 8;
            this.nextbtn.Text = ">";
            this.nextbtn.UseVisualStyleBackColor = true;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // endbtn
            // 
            this.endbtn.Location = new System.Drawing.Point(330, 257);
            this.endbtn.Name = "endbtn";
            this.endbtn.Size = new System.Drawing.Size(75, 23);
            this.endbtn.TabIndex = 9;
            this.endbtn.Text = ">>";
            this.endbtn.UseVisualStyleBackColor = true;
            this.endbtn.Click += new System.EventHandler(this.endbtn_Click);
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Location = new System.Drawing.Point(77, 298);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(30, 13);
            this.Timer.TabIndex = 10;
            this.Timer.Text = "Time";
            this.Timer.Click += new System.EventHandler(this.Timer_Click);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(146, 298);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(34, 13);
            this.lbltime.TabIndex = 11;
            this.lbltime.Text = "00:00";
            // 
            // lbl_duration
            // 
            this.lbl_duration.AutoSize = true;
            this.lbl_duration.Location = new System.Drawing.Point(77, 339);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Size = new System.Drawing.Size(47, 13);
            this.lbl_duration.TabIndex = 12;
            this.lbl_duration.Text = "Duration";
            this.lbl_duration.Click += new System.EventHandler(this.lbl_duration_Click);
            // 
            // lblduration
            // 
            this.lblduration.AutoSize = true;
            this.lblduration.Location = new System.Drawing.Point(146, 339);
            this.lblduration.Name = "lblduration";
            this.lblduration.Size = new System.Drawing.Size(34, 13);
            this.lblduration.TabIndex = 13;
            this.lblduration.Text = "00:00";
            this.lblduration.Click += new System.EventHandler(this.lblduration_Click);
            // 
            // TimerTick
            // 
            this.TimerTick.AutoSize = true;
            this.TimerTick.Location = new System.Drawing.Point(80, 382);
            this.TimerTick.Name = "TimerTick";
            this.TimerTick.Size = new System.Drawing.Size(59, 17);
            this.TimerTick.TabIndex = 14;
            this.TimerTick.Text = "Shuffle";
            this.TimerTick.UseVisualStyleBackColor = true;
            this.TimerTick.CheckedChanged += new System.EventHandler(this.Timer_Tick);
            // 
            // volumeScroll
            // 
            this.volumeScroll.Location = new System.Drawing.Point(264, 298);
            this.volumeScroll.Maximum = 100;
            this.volumeScroll.Name = "volumeScroll";
            this.volumeScroll.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volumeScroll.Size = new System.Drawing.Size(45, 104);
            this.volumeScroll.TabIndex = 17;
            this.volumeScroll.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(117, 33);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 19;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // Ltb_Musics
            // 
            this.Ltb_Musics.FormattingEnabled = true;
            this.Ltb_Musics.Location = new System.Drawing.Point(432, 12);
            this.Ltb_Musics.Name = "Ltb_Musics";
            this.Ltb_Musics.Size = new System.Drawing.Size(356, 329);
            this.Ltb_Musics.TabIndex = 20;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(37, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 32);
            this.panel1.TabIndex = 21;
            // 
            // sortbtn
            // 
            this.sortbtn.Location = new System.Drawing.Point(616, 361);
            this.sortbtn.Name = "sortbtn";
            this.sortbtn.Size = new System.Drawing.Size(75, 23);
            this.sortbtn.TabIndex = 22;
            this.sortbtn.Text = "Descending";
            this.sortbtn.UseVisualStyleBackColor = true;
            this.sortbtn.Click += new System.EventHandler(this.sortbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Sort by:";
            // 
            // newbtn
            // 
            this.newbtn.Location = new System.Drawing.Point(234, 33);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(75, 23);
            this.newbtn.TabIndex = 24;
            this.newbtn.Text = "New";
            this.newbtn.UseVisualStyleBackColor = true;
            this.newbtn.Click += new System.EventHandler(this.newbtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Ascending";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Filter by Search:";
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(518, 407);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(256, 20);
            this.searchtxt.TabIndex = 27;
            this.searchtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sortbtn);
            this.Controls.Add(this.Ltb_Musics);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.volumeScroll);
            this.Controls.Add(this.TimerTick);
            this.Controls.Add(this.lblduration);
            this.Controls.Add(this.lbl_duration);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.endbtn);
            this.Controls.Add(this.nextbtn);
            this.Controls.Add(this.previousbtn);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.fastforwardbtn);
            this.Controls.Add(this.resumebtn);
            this.Controls.Add(this.stopbtn);
            this.Controls.Add(this.pausebtn);
            this.Controls.Add(this.playbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Player);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeScroll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button playbtn;
        private System.Windows.Forms.Button pausebtn;
        private System.Windows.Forms.Button stopbtn;
        private System.Windows.Forms.Button resumebtn;
        private System.Windows.Forms.Button fastforwardbtn;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Button previousbtn;
        private System.Windows.Forms.Button nextbtn;
        private System.Windows.Forms.Button endbtn;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lbl_duration;
        private System.Windows.Forms.Label lblduration;
        private System.Windows.Forms.CheckBox TimerTick;
        private System.Windows.Forms.TrackBar volumeScroll;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.ListBox Ltb_Musics;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.Button sortbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchtxt;
    }
}

