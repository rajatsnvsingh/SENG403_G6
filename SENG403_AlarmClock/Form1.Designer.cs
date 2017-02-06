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
            this.SuspendLayout();
            // 
            // currentTimeDisplay
            // 
            this.currentTimeDisplay.AutoSize = true;
            this.currentTimeDisplay.Location = new System.Drawing.Point(0, 0);
            this.currentTimeDisplay.Name = "currentTimeDisplay";
            this.currentTimeDisplay.Size = new System.Drawing.Size(46, 17);
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
            this.alarmTimePicker.Location = new System.Drawing.Point(3, 37);
            this.alarmTimePicker.Name = "alarmTimePicker";
            this.alarmTimePicker.Size = new System.Drawing.Size(200, 22);
            this.alarmTimePicker.TabIndex = 1;
            // 
            // setAlarmButton
            // 
            this.setAlarmButton.Location = new System.Drawing.Point(12, 76);
            this.setAlarmButton.Name = "setAlarmButton";
            this.setAlarmButton.Size = new System.Drawing.Size(75, 23);
            this.setAlarmButton.TabIndex = 2;
            this.setAlarmButton.Text = "OK";
            this.setAlarmButton.UseVisualStyleBackColor = true;
            this.setAlarmButton.Click += new System.EventHandler(this.setAlarmButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 254);
            this.Controls.Add(this.setAlarmButton);
            this.Controls.Add(this.alarmTimePicker);
            this.Controls.Add(this.currentTimeDisplay);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}

