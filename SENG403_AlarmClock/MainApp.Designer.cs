namespace SENG403_AlarmClock
{
    partial class MainApp
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
            this.currentTimeDisplay = new System.Windows.Forms.Label();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.alarmActivatedLabel = new System.Windows.Forms.Label();
            this.snoozeButton = new System.Windows.Forms.Button();
            this.debugAlarms = new System.Windows.Forms.Button();
            this.setCurrentTime = new System.Windows.Forms.Button();
            this.debugDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dismissAlarmButton = new System.Windows.Forms.Button();
            this.setSnoozeButton = new System.Windows.Forms.Button();
            this.snoozeTimeUpDown = new System.Windows.Forms.NumericUpDown();
            this.snoozeMinutesLabel = new System.Windows.Forms.Label();
            this.edit0 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.alarm0_label = new System.Windows.Forms.Label();
            this.alarm1_label = new System.Windows.Forms.Label();
            this.alarm2_label = new System.Windows.Forms.Label();
            this.cancel0 = new System.Windows.Forms.Button();
            this.cancel1 = new System.Windows.Forms.Button();
            this.edit1 = new System.Windows.Forms.Button();
            this.cancel2 = new System.Windows.Forms.Button();
            this.edit2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.snoozeTimeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // currentTimeDisplay
            // 
            this.currentTimeDisplay.AutoSize = true;
            this.currentTimeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTimeDisplay.Location = new System.Drawing.Point(497, 157);
            this.currentTimeDisplay.Name = "currentTimeDisplay";
            this.currentTimeDisplay.Size = new System.Drawing.Size(458, 135);
            this.currentTimeDisplay.TabIndex = 0;
            this.currentTimeDisplay.Text = "4:30pm";
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimerTick);
            // 
            // alarmActivatedLabel
            // 
            this.alarmActivatedLabel.AutoSize = true;
            this.alarmActivatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmActivatedLabel.Location = new System.Drawing.Point(428, 574);
            this.alarmActivatedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.alarmActivatedLabel.Name = "alarmActivatedLabel";
            this.alarmActivatedLabel.Size = new System.Drawing.Size(722, 69);
            this.alarmActivatedLabel.TabIndex = 4;
            this.alarmActivatedLabel.Text = "ALARM HAS GONE OFF!";
            this.alarmActivatedLabel.Visible = false;
            // 
            // snoozeButton
            // 
            this.snoozeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snoozeButton.Location = new System.Drawing.Point(496, 676);
            this.snoozeButton.Margin = new System.Windows.Forms.Padding(4);
            this.snoozeButton.Name = "snoozeButton";
            this.snoozeButton.Size = new System.Drawing.Size(249, 81);
            this.snoozeButton.TabIndex = 5;
            this.snoozeButton.Text = "SNOOZE";
            this.snoozeButton.UseVisualStyleBackColor = true;
            this.snoozeButton.Visible = false;
            this.snoozeButton.Click += new System.EventHandler(this.snoozeButton_Click);
            // 
            // debugAlarms
            // 
            this.debugAlarms.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugAlarms.Location = new System.Drawing.Point(1234, 299);
            this.debugAlarms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.debugAlarms.Name = "debugAlarms";
            this.debugAlarms.Size = new System.Drawing.Size(273, 87);
            this.debugAlarms.TabIndex = 21;
            this.debugAlarms.Text = "Debug (print alarms info to console)";
            this.debugAlarms.UseVisualStyleBackColor = true;
            this.debugAlarms.Click += new System.EventHandler(this.button1_Click);
            // 
            // setCurrentTime
            // 
            this.setCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setCurrentTime.Location = new System.Drawing.Point(1234, 421);
            this.setCurrentTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setCurrentTime.Name = "setCurrentTime";
            this.setCurrentTime.Size = new System.Drawing.Size(273, 87);
            this.setCurrentTime.TabIndex = 25;
            this.setCurrentTime.Text = "Set Current Time (testing/demo)";
            this.setCurrentTime.UseVisualStyleBackColor = true;
            this.setCurrentTime.Click += new System.EventHandler(this.setCurrentTime_Click);
            // 
            // debugDateTimePicker
            // 
            this.debugDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugDateTimePicker.Location = new System.Drawing.Point(1234, 538);
            this.debugDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.debugDateTimePicker.Name = "debugDateTimePicker";
            this.debugDateTimePicker.Size = new System.Drawing.Size(553, 53);
            this.debugDateTimePicker.TabIndex = 26;
            // 
            // dismissAlarmButton
            // 
            this.dismissAlarmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dismissAlarmButton.Location = new System.Drawing.Point(797, 676);
            this.dismissAlarmButton.Margin = new System.Windows.Forms.Padding(4);
            this.dismissAlarmButton.Name = "dismissAlarmButton";
            this.dismissAlarmButton.Size = new System.Drawing.Size(249, 81);
            this.dismissAlarmButton.TabIndex = 27;
            this.dismissAlarmButton.Text = "DISMISS";
            this.dismissAlarmButton.UseVisualStyleBackColor = true;
            this.dismissAlarmButton.Visible = false;
            this.dismissAlarmButton.Click += new System.EventHandler(this.dismissAlarmButton_Click);
            // 
            // setSnoozeButton
            // 
            this.setSnoozeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setSnoozeButton.Location = new System.Drawing.Point(496, 319);
            this.setSnoozeButton.Margin = new System.Windows.Forms.Padding(4);
            this.setSnoozeButton.Name = "setSnoozeButton";
            this.setSnoozeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.setSnoozeButton.Size = new System.Drawing.Size(243, 46);
            this.setSnoozeButton.TabIndex = 28;
            this.setSnoozeButton.Text = "Set Snooze";
            this.setSnoozeButton.UseVisualStyleBackColor = true;
            this.setSnoozeButton.Click += new System.EventHandler(this.setSnoozeButton_Click);
            // 
            // snoozeTimeUpDown
            // 
            this.snoozeTimeUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snoozeTimeUpDown.Location = new System.Drawing.Point(766, 319);
            this.snoozeTimeUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.snoozeTimeUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.snoozeTimeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.snoozeTimeUpDown.Name = "snoozeTimeUpDown";
            this.snoozeTimeUpDown.Size = new System.Drawing.Size(68, 34);
            this.snoozeTimeUpDown.TabIndex = 29;
            this.snoozeTimeUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.snoozeTimeUpDown.Visible = false;
            // 
            // snoozeMinutesLabel
            // 
            this.snoozeMinutesLabel.AutoSize = true;
            this.snoozeMinutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snoozeMinutesLabel.Location = new System.Drawing.Point(842, 321);
            this.snoozeMinutesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.snoozeMinutesLabel.Name = "snoozeMinutesLabel";
            this.snoozeMinutesLabel.Size = new System.Drawing.Size(113, 29);
            this.snoozeMinutesLabel.TabIndex = 30;
            this.snoozeMinutesLabel.Text = "Minute(s)";
            this.snoozeMinutesLabel.Visible = false;
            // 
            // edit0
            // 
            this.edit0.Location = new System.Drawing.Point(27, 91);
            this.edit0.Name = "edit0";
            this.edit0.Size = new System.Drawing.Size(61, 23);
            this.edit0.TabIndex = 33;
            this.edit0.Text = "Edit";
            this.edit0.UseVisualStyleBackColor = true;
            this.edit0.Click += new System.EventHandler(this.edit0_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 32);
            this.label1.TabIndex = 34;
            this.label1.Text = "Alarms";
            // 
            // alarm0_label
            // 
            this.alarm0_label.AutoSize = true;
            this.alarm0_label.Location = new System.Drawing.Point(25, 71);
            this.alarm0_label.Name = "alarm0_label";
            this.alarm0_label.Size = new System.Drawing.Size(55, 17);
            this.alarm0_label.TabIndex = 35;
            this.alarm0_label.Text = "Not Set";
            // 
            // alarm1_label
            // 
            this.alarm1_label.AutoSize = true;
            this.alarm1_label.Location = new System.Drawing.Point(25, 157);
            this.alarm1_label.Name = "alarm1_label";
            this.alarm1_label.Size = new System.Drawing.Size(55, 17);
            this.alarm1_label.TabIndex = 37;
            this.alarm1_label.Text = "Not Set";
            // 
            // alarm2_label
            // 
            this.alarm2_label.AutoSize = true;
            this.alarm2_label.Location = new System.Drawing.Point(25, 249);
            this.alarm2_label.Name = "alarm2_label";
            this.alarm2_label.Size = new System.Drawing.Size(55, 17);
            this.alarm2_label.TabIndex = 39;
            this.alarm2_label.Text = "Not Set";
            // 
            // cancel0
            // 
            this.cancel0.Location = new System.Drawing.Point(109, 91);
            this.cancel0.Name = "cancel0";
            this.cancel0.Size = new System.Drawing.Size(73, 23);
            this.cancel0.TabIndex = 40;
            this.cancel0.Text = "Cancel";
            this.cancel0.UseVisualStyleBackColor = true;
            this.cancel0.Click += new System.EventHandler(this.cancel0_Click);
            // 
            // cancel1
            // 
            this.cancel1.Location = new System.Drawing.Point(110, 178);
            this.cancel1.Name = "cancel1";
            this.cancel1.Size = new System.Drawing.Size(73, 23);
            this.cancel1.TabIndex = 42;
            this.cancel1.Text = "Cancel";
            this.cancel1.UseVisualStyleBackColor = true;
            this.cancel1.Click += new System.EventHandler(this.cancel1_Click);
            // 
            // edit1
            // 
            this.edit1.Location = new System.Drawing.Point(28, 178);
            this.edit1.Name = "edit1";
            this.edit1.Size = new System.Drawing.Size(61, 23);
            this.edit1.TabIndex = 41;
            this.edit1.Text = "Edit";
            this.edit1.UseVisualStyleBackColor = true;
            this.edit1.Click += new System.EventHandler(this.edit1_Click);
            // 
            // cancel2
            // 
            this.cancel2.Location = new System.Drawing.Point(110, 269);
            this.cancel2.Name = "cancel2";
            this.cancel2.Size = new System.Drawing.Size(73, 23);
            this.cancel2.TabIndex = 44;
            this.cancel2.Text = "Cancel";
            this.cancel2.UseVisualStyleBackColor = true;
            this.cancel2.Click += new System.EventHandler(this.cancel2_Click);
            // 
            // edit2
            // 
            this.edit2.Location = new System.Drawing.Point(28, 269);
            this.edit2.Name = "edit2";
            this.edit2.Size = new System.Drawing.Size(61, 23);
            this.edit2.TabIndex = 43;
            this.edit2.Text = "Edit";
            this.edit2.UseVisualStyleBackColor = true;
            this.edit2.Click += new System.EventHandler(this.edit2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "Add Alarm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1765, 912);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cancel2);
            this.Controls.Add(this.edit2);
            this.Controls.Add(this.cancel1);
            this.Controls.Add(this.edit1);
            this.Controls.Add(this.cancel0);
            this.Controls.Add(this.alarm2_label);
            this.Controls.Add(this.alarm1_label);
            this.Controls.Add(this.alarm0_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edit0);
            this.Controls.Add(this.snoozeMinutesLabel);
            this.Controls.Add(this.snoozeTimeUpDown);
            this.Controls.Add(this.setSnoozeButton);
            this.Controls.Add(this.dismissAlarmButton);
            this.Controls.Add(this.debugDateTimePicker);
            this.Controls.Add(this.setCurrentTime);
            this.Controls.Add(this.debugAlarms);
            this.Controls.Add(this.snoozeButton);
            this.Controls.Add(this.alarmActivatedLabel);
            this.Controls.Add(this.currentTimeDisplay);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainApp";
            this.Text = "SENG 401 G6 Alarm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.snoozeTimeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentTimeDisplay;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Label alarmActivatedLabel;
        private System.Windows.Forms.Button snoozeButton;
        private System.Windows.Forms.Button debugAlarms;
        private System.Windows.Forms.Button setCurrentTime;
        private System.Windows.Forms.DateTimePicker debugDateTimePicker;
        private System.Windows.Forms.Button dismissAlarmButton;
        private System.Windows.Forms.Button setSnoozeButton;
        private System.Windows.Forms.NumericUpDown snoozeTimeUpDown;
        private System.Windows.Forms.Label snoozeMinutesLabel;
        private System.Windows.Forms.Button edit0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label alarm0_label;
        private System.Windows.Forms.Label alarm1_label;
        private System.Windows.Forms.Label alarm2_label;
        private System.Windows.Forms.Button cancel0;
        private System.Windows.Forms.Button cancel1;
        private System.Windows.Forms.Button edit1;
        private System.Windows.Forms.Button cancel2;
        private System.Windows.Forms.Button edit2;
        private System.Windows.Forms.Button button1;
    }
}

