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
            this.alarmsList = new System.Windows.Forms.ToolStripContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.creatAlarmButton = new System.Windows.Forms.Button();
            this.alarmsManagerButton = new System.Windows.Forms.Button();
            this.nonrepeatingAlarmPicker = new System.Windows.Forms.DateTimePicker();
            this.nonrepeatAlarmButton = new System.Windows.Forms.Button();
            this.debugAlarms = new System.Windows.Forms.Button();
            this.setCurrentTime = new System.Windows.Forms.Button();
            this.debugDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dismissAlarmButton = new System.Windows.Forms.Button();
            this.alarmsList.ContentPanel.SuspendLayout();
            this.alarmsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentTimeDisplay
            // 
            this.currentTimeDisplay.AutoSize = true;
            this.currentTimeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTimeDisplay.Location = new System.Drawing.Point(501, 15);
            this.currentTimeDisplay.Name = "currentTimeDisplay";
            this.currentTimeDisplay.Size = new System.Drawing.Size(379, 135);
            this.currentTimeDisplay.TabIndex = 0;
            this.currentTimeDisplay.Text = "label1";
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
            this.alarmActivatedLabel.Location = new System.Drawing.Point(501, 627);
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
            this.snoozeButton.Location = new System.Drawing.Point(618, 726);
            this.snoozeButton.Margin = new System.Windows.Forms.Padding(4);
            this.snoozeButton.Name = "snoozeButton";
            this.snoozeButton.Size = new System.Drawing.Size(249, 81);
            this.snoozeButton.TabIndex = 5;
            this.snoozeButton.Text = "SNOOZE";
            this.snoozeButton.UseVisualStyleBackColor = true;
            this.snoozeButton.Visible = false;
            this.snoozeButton.Click += new System.EventHandler(this.snoozeButton_Click);
            // 
            // alarmsList
            // 
            // 
            // alarmsList.ContentPanel
            // 
            this.alarmsList.ContentPanel.AllowDrop = true;
            this.alarmsList.ContentPanel.Controls.Add(this.label1);
            this.alarmsList.ContentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.alarmsList.ContentPanel.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.alarmsList.ContentPanel.Size = new System.Drawing.Size(295, 608);
            this.alarmsList.Location = new System.Drawing.Point(16, 121);
            this.alarmsList.Margin = new System.Windows.Forms.Padding(4);
            this.alarmsList.Name = "alarmsList";
            this.alarmsList.Size = new System.Drawing.Size(295, 633);
            this.alarmsList.TabIndex = 6;
            this.alarmsList.Text = "toolStripContainer1";
            // 
            // alarmsList.TopToolStripPanel
            // 
            this.alarmsList.TopToolStripPanel.BackColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // creatAlarmButton
            // 
            this.creatAlarmButton.Location = new System.Drawing.Point(97, 761);
            this.creatAlarmButton.Margin = new System.Windows.Forms.Padding(4);
            this.creatAlarmButton.Name = "creatAlarmButton";
            this.creatAlarmButton.Size = new System.Drawing.Size(100, 28);
            this.creatAlarmButton.TabIndex = 7;
            this.creatAlarmButton.Text = "Add Alarm";
            this.creatAlarmButton.UseVisualStyleBackColor = true;
            this.creatAlarmButton.Visible = false;
            this.creatAlarmButton.Click += new System.EventHandler(this.creatAlarmButton_Click);
            // 
            // alarmsManagerButton
            // 
            this.alarmsManagerButton.Location = new System.Drawing.Point(16, 15);
            this.alarmsManagerButton.Margin = new System.Windows.Forms.Padding(4);
            this.alarmsManagerButton.Name = "alarmsManagerButton";
            this.alarmsManagerButton.Size = new System.Drawing.Size(100, 28);
            this.alarmsManagerButton.TabIndex = 8;
            this.alarmsManagerButton.Text = "+";
            this.alarmsManagerButton.UseVisualStyleBackColor = true;
            this.alarmsManagerButton.Click += new System.EventHandler(this.alarmsManagerButton_Click);
            // 
            // nonrepeatingAlarmPicker
            // 
            this.nonrepeatingAlarmPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonrepeatingAlarmPicker.Location = new System.Drawing.Point(524, 460);
            this.nonrepeatingAlarmPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nonrepeatingAlarmPicker.Name = "nonrepeatingAlarmPicker";
            this.nonrepeatingAlarmPicker.Size = new System.Drawing.Size(518, 53);
            this.nonrepeatingAlarmPicker.TabIndex = 10;
            // 
            // nonrepeatAlarmButton
            // 
            this.nonrepeatAlarmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonrepeatAlarmButton.Location = new System.Drawing.Point(524, 538);
            this.nonrepeatAlarmButton.Name = "nonrepeatAlarmButton";
            this.nonrepeatAlarmButton.Size = new System.Drawing.Size(289, 46);
            this.nonrepeatAlarmButton.TabIndex = 20;
            this.nonrepeatAlarmButton.Text = "Add Nonrepeating Alarm";
            this.nonrepeatAlarmButton.UseVisualStyleBackColor = true;
            this.nonrepeatAlarmButton.Click += new System.EventHandler(this.nonrepeatAlarmButton_Click);
            // 
            // debugAlarms
            // 
            this.debugAlarms.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugAlarms.Location = new System.Drawing.Point(1123, 268);
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
            this.setCurrentTime.Location = new System.Drawing.Point(1123, 426);
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
            this.debugDateTimePicker.Location = new System.Drawing.Point(1123, 538);
            this.debugDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.debugDateTimePicker.Name = "debugDateTimePicker";
            this.debugDateTimePicker.Size = new System.Drawing.Size(554, 53);
            this.debugDateTimePicker.TabIndex = 26;
            // 
            // dismissAlarmButton
            // 
            this.dismissAlarmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dismissAlarmButton.Location = new System.Drawing.Point(916, 726);
            this.dismissAlarmButton.Margin = new System.Windows.Forms.Padding(4);
            this.dismissAlarmButton.Name = "dismissAlarmButton";
            this.dismissAlarmButton.Size = new System.Drawing.Size(249, 81);
            this.dismissAlarmButton.TabIndex = 27;
            this.dismissAlarmButton.Text = "DISMISS";
            this.dismissAlarmButton.UseVisualStyleBackColor = true;
            this.dismissAlarmButton.Visible = false;
            this.dismissAlarmButton.Click += new System.EventHandler(this.dismissAlarmButton_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1816, 820);
            this.Controls.Add(this.dismissAlarmButton);
            this.Controls.Add(this.debugDateTimePicker);
            this.Controls.Add(this.setCurrentTime);
            this.Controls.Add(this.debugAlarms);
            this.Controls.Add(this.nonrepeatAlarmButton);
            this.Controls.Add(this.nonrepeatingAlarmPicker);
            this.Controls.Add(this.alarmsManagerButton);
            this.Controls.Add(this.creatAlarmButton);
            this.Controls.Add(this.alarmsList);
            this.Controls.Add(this.snoozeButton);
            this.Controls.Add(this.alarmActivatedLabel);
            this.Controls.Add(this.currentTimeDisplay);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainApp";
            this.Text = "SENG 401 G6 Alarm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.alarmsList.ContentPanel.ResumeLayout(false);
            this.alarmsList.ContentPanel.PerformLayout();
            this.alarmsList.ResumeLayout(false);
            this.alarmsList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentTimeDisplay;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Label alarmActivatedLabel;
        private System.Windows.Forms.Button snoozeButton;
        private System.Windows.Forms.ToolStripContainer alarmsList;
        private System.Windows.Forms.Button creatAlarmButton;
        private System.Windows.Forms.Button alarmsManagerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker nonrepeatingAlarmPicker;
        private System.Windows.Forms.Button nonrepeatAlarmButton;
        private System.Windows.Forms.Button debugAlarms;
        private System.Windows.Forms.Button setCurrentTime;
        private System.Windows.Forms.DateTimePicker debugDateTimePicker;
        private System.Windows.Forms.Button dismissAlarmButton;
    }
}

