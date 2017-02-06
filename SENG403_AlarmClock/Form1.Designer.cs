namespace SENG403_AlarmClock
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
            this.currentTimeDisplay = new System.Windows.Forms.Label();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.alarmTimePicker = new System.Windows.Forms.DateTimePicker();
            this.setAlarmButton = new System.Windows.Forms.Button();
            this.cancelAlarmButton = new System.Windows.Forms.Button();
            this.AlarmActivatedLabel = new System.Windows.Forms.Label();
            this.snoozeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currentTimeDisplay
            // 
            this.currentTimeDisplay.AutoSize = true;
            this.currentTimeDisplay.Location = new System.Drawing.Point(0, 0);
            this.currentTimeDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentTimeDisplay.Name = "currentTimeDisplay";
            this.currentTimeDisplay.Size = new System.Drawing.Size(35, 13);
            this.currentTimeDisplay.TabIndex = 0;
            this.currentTimeDisplay.Text = "label1";
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimerTick);
            // 
            // alarmTimePicker
            // 
            this.alarmTimePicker.Location = new System.Drawing.Point(2, 30);
            this.alarmTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.alarmTimePicker.Name = "alarmTimePicker";
            this.alarmTimePicker.Size = new System.Drawing.Size(151, 20);
            this.alarmTimePicker.TabIndex = 1;
            // 
            // setAlarmButton
            // 
            this.setAlarmButton.Location = new System.Drawing.Point(9, 62);
            this.setAlarmButton.Margin = new System.Windows.Forms.Padding(2);
            this.setAlarmButton.Name = "setAlarmButton";
            this.setAlarmButton.Size = new System.Drawing.Size(83, 19);
            this.setAlarmButton.TabIndex = 2;
            this.setAlarmButton.Text = "Set Alarm";
            this.setAlarmButton.UseVisualStyleBackColor = true;
            this.setAlarmButton.Click += new System.EventHandler(this.setAlarmButton_Click);
            // 
            // cancelAlarmButton
            // 
            this.cancelAlarmButton.Location = new System.Drawing.Point(9, 86);
            this.cancelAlarmButton.Name = "cancelAlarmButton";
            this.cancelAlarmButton.Size = new System.Drawing.Size(83, 23);
            this.cancelAlarmButton.TabIndex = 3;
            this.cancelAlarmButton.Text = "Cancel Alarm";
            this.cancelAlarmButton.UseVisualStyleBackColor = true;
            this.cancelAlarmButton.Click += new System.EventHandler(this.cancelAlarmButton_Click);
            // 
            // AlarmActivatedLabel
            // 
            this.AlarmActivatedLabel.AutoSize = true;
            this.AlarmActivatedLabel.Location = new System.Drawing.Point(36, 131);
            this.AlarmActivatedLabel.Name = "AlarmActivatedLabel";
            this.AlarmActivatedLabel.Size = new System.Drawing.Size(129, 13);
            this.AlarmActivatedLabel.TabIndex = 4;
            this.AlarmActivatedLabel.Text = "ALARM HAS GONE OFF!";
            this.AlarmActivatedLabel.Visible = false;
            // 
            // snoozeButton
            // 
            this.snoozeButton.Location = new System.Drawing.Point(17, 171);
            this.snoozeButton.Name = "snoozeButton";
            this.snoozeButton.Size = new System.Drawing.Size(75, 23);
            this.snoozeButton.TabIndex = 5;
            this.snoozeButton.Text = "SNOOZE";
            this.snoozeButton.UseVisualStyleBackColor = true;
            this.snoozeButton.Visible = false;
            this.snoozeButton.Click += new System.EventHandler(this.snoozeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 206);
            this.Controls.Add(this.snoozeButton);
            this.Controls.Add(this.AlarmActivatedLabel);
            this.Controls.Add(this.cancelAlarmButton);
            this.Controls.Add(this.setAlarmButton);
            this.Controls.Add(this.alarmTimePicker);
            this.Controls.Add(this.currentTimeDisplay);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentTimeDisplay;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.DateTimePicker alarmTimePicker;
        private System.Windows.Forms.Button setAlarmButton;
        private System.Windows.Forms.Button cancelAlarmButton;
        private System.Windows.Forms.Label AlarmActivatedLabel;
        private System.Windows.Forms.Button snoozeButton;
    }
}

