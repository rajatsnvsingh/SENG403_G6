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
            this.AlarmActivatedLabel = new System.Windows.Forms.Label();
            this.snoozeButton = new System.Windows.Forms.Button();
            this.alarmsList = new System.Windows.Forms.ToolStripContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.creatAlarmButton = new System.Windows.Forms.Button();
            this.alarmsManagerButton = new System.Windows.Forms.Button();
            this.nonrepeatingAlarmPicker = new System.Windows.Forms.DateTimePicker();
            this.repeatingAlarmPicker = new System.Windows.Forms.DateTimePicker();
            this.repeatAlarmButton = new System.Windows.Forms.Button();
            this.nonrepeatAlarmButton = new System.Windows.Forms.Button();
            this.debugAlarms = new System.Windows.Forms.Button();
            this.Mon = new System.Windows.Forms.RadioButton();
            this.Tue = new System.Windows.Forms.RadioButton();
            this.Wed = new System.Windows.Forms.RadioButton();
            this.setCurrentTime = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Thu = new System.Windows.Forms.RadioButton();
            this.Fri = new System.Windows.Forms.RadioButton();
            this.Sat = new System.Windows.Forms.RadioButton();
            this.Sun = new System.Windows.Forms.RadioButton();
            this.Daily = new System.Windows.Forms.RadioButton();
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
            // AlarmActivatedLabel
            // 
            this.AlarmActivatedLabel.AutoSize = true;
            this.AlarmActivatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmActivatedLabel.Location = new System.Drawing.Point(501, 627);
            this.AlarmActivatedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AlarmActivatedLabel.Name = "AlarmActivatedLabel";
            this.AlarmActivatedLabel.Size = new System.Drawing.Size(722, 69);
            this.AlarmActivatedLabel.TabIndex = 4;
            this.AlarmActivatedLabel.Text = "ALARM HAS GONE OFF!";
            this.AlarmActivatedLabel.Visible = false;
            // 
            // snoozeButton
            // 
            this.snoozeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snoozeButton.Location = new System.Drawing.Point(711, 728);
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
            // repeatingAlarmPicker
            // 
            this.repeatingAlarmPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatingAlarmPicker.Location = new System.Drawing.Point(524, 200);
            this.repeatingAlarmPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.repeatingAlarmPicker.Name = "repeatingAlarmPicker";
            this.repeatingAlarmPicker.Size = new System.Drawing.Size(518, 53);
            this.repeatingAlarmPicker.TabIndex = 11;
            // 
            // repeatAlarmButton
            // 
            this.repeatAlarmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatAlarmButton.Location = new System.Drawing.Point(524, 359);
            this.repeatAlarmButton.Name = "repeatAlarmButton";
            this.repeatAlarmButton.Size = new System.Drawing.Size(289, 46);
            this.repeatAlarmButton.TabIndex = 19;
            this.repeatAlarmButton.Text = "Add Repeating Alarm";
            this.repeatAlarmButton.UseVisualStyleBackColor = true;
            this.repeatAlarmButton.Click += new System.EventHandler(this.repeatAlarmButton_Click);
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
            // Mon
            // 
            this.Mon.AutoSize = true;
            this.Mon.Location = new System.Drawing.Point(540, 280);
            this.Mon.Name = "Mon";
            this.Mon.Size = new System.Drawing.Size(79, 21);
            this.Mon.TabIndex = 22;
            this.Mon.TabStop = true;
            this.Mon.Text = "Monday";
            this.Mon.UseVisualStyleBackColor = true;
            // 
            // Tue
            // 
            this.Tue.AutoSize = true;
            this.Tue.Location = new System.Drawing.Point(664, 280);
            this.Tue.Name = "Tue";
            this.Tue.Size = new System.Drawing.Size(84, 21);
            this.Tue.TabIndex = 23;
            this.Tue.TabStop = true;
            this.Tue.Text = "Tuesday";
            this.Tue.UseVisualStyleBackColor = true;
            // 
            // Wed
            // 
            this.Wed.AutoSize = true;
            this.Wed.Location = new System.Drawing.Point(780, 280);
            this.Wed.Name = "Wed";
            this.Wed.Size = new System.Drawing.Size(104, 21);
            this.Wed.TabIndex = 24;
            this.Wed.TabStop = true;
            this.Wed.Text = "Wednesday";
            this.Wed.UseVisualStyleBackColor = true;
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
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(1123, 538);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(387, 53);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // Thu
            // 
            this.Thu.AutoSize = true;
            this.Thu.Location = new System.Drawing.Point(911, 280);
            this.Thu.Name = "Thu";
            this.Thu.Size = new System.Drawing.Size(89, 21);
            this.Thu.TabIndex = 27;
            this.Thu.TabStop = true;
            this.Thu.Text = "Thursday";
            this.Thu.UseVisualStyleBackColor = true;
            // 
            // Fri
            // 
            this.Fri.AutoSize = true;
            this.Fri.Location = new System.Drawing.Point(540, 323);
            this.Fri.Name = "Fri";
            this.Fri.Size = new System.Drawing.Size(68, 21);
            this.Fri.TabIndex = 28;
            this.Fri.TabStop = true;
            this.Fri.Text = "Friday";
            this.Fri.UseVisualStyleBackColor = true;
            // 
            // Sat
            // 
            this.Sat.AutoSize = true;
            this.Sat.Location = new System.Drawing.Point(664, 323);
            this.Sat.Name = "Sat";
            this.Sat.Size = new System.Drawing.Size(86, 21);
            this.Sat.TabIndex = 29;
            this.Sat.TabStop = true;
            this.Sat.Text = "Saturday";
            this.Sat.UseVisualStyleBackColor = true;
            // 
            // Sun
            // 
            this.Sun.AutoSize = true;
            this.Sun.Location = new System.Drawing.Point(780, 323);
            this.Sun.Name = "Sun";
            this.Sun.Size = new System.Drawing.Size(77, 21);
            this.Sun.TabIndex = 30;
            this.Sun.TabStop = true;
            this.Sun.Text = "Sunday";
            this.Sun.UseVisualStyleBackColor = true;
            // 
            // Daily
            // 
            this.Daily.AutoSize = true;
            this.Daily.Location = new System.Drawing.Point(911, 323);
            this.Daily.Name = "Daily";
            this.Daily.Size = new System.Drawing.Size(60, 21);
            this.Daily.TabIndex = 31;
            this.Daily.TabStop = true;
            this.Daily.Text = "Daily";
            this.Daily.UseVisualStyleBackColor = true;
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1816, 820);
            this.Controls.Add(this.Daily);
            this.Controls.Add(this.Sun);
            this.Controls.Add(this.Sat);
            this.Controls.Add(this.Fri);
            this.Controls.Add(this.Thu);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.setCurrentTime);
            this.Controls.Add(this.Wed);
            this.Controls.Add(this.Tue);
            this.Controls.Add(this.Mon);
            this.Controls.Add(this.debugAlarms);
            this.Controls.Add(this.nonrepeatAlarmButton);
            this.Controls.Add(this.repeatAlarmButton);
            this.Controls.Add(this.repeatingAlarmPicker);
            this.Controls.Add(this.nonrepeatingAlarmPicker);
            this.Controls.Add(this.alarmsManagerButton);
            this.Controls.Add(this.creatAlarmButton);
            this.Controls.Add(this.alarmsList);
            this.Controls.Add(this.snoozeButton);
            this.Controls.Add(this.AlarmActivatedLabel);
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
        private System.Windows.Forms.Label AlarmActivatedLabel;
        private System.Windows.Forms.Button snoozeButton;
        private System.Windows.Forms.ToolStripContainer alarmsList;
        private System.Windows.Forms.Button creatAlarmButton;
        private System.Windows.Forms.Button alarmsManagerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker nonrepeatingAlarmPicker;
        private System.Windows.Forms.DateTimePicker repeatingAlarmPicker;
        private System.Windows.Forms.Button repeatAlarmButton;
        private System.Windows.Forms.Button nonrepeatAlarmButton;
        private System.Windows.Forms.Button debugAlarms;
        private System.Windows.Forms.RadioButton Tue;
        private System.Windows.Forms.RadioButton Mon;
        private System.Windows.Forms.RadioButton Wed;
        private System.Windows.Forms.Button setCurrentTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton Thu;
        private System.Windows.Forms.RadioButton Fri;
        private System.Windows.Forms.RadioButton Sat;
        private System.Windows.Forms.RadioButton Sun;
        private System.Windows.Forms.RadioButton Daily;
    }
}

