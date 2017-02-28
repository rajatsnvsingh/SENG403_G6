﻿namespace SENG403_AlarmClock
{
    partial class SetAlarmForm
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
            this.setAlarmButton = new System.Windows.Forms.Button();
            this.repeatingAlarmPicker = new System.Windows.Forms.DateTimePicker();
            this.Sun = new System.Windows.Forms.RadioButton();
            this.Sat = new System.Windows.Forms.RadioButton();
            this.Fri = new System.Windows.Forms.RadioButton();
            this.Thu = new System.Windows.Forms.RadioButton();
            this.Wed = new System.Windows.Forms.RadioButton();
            this.Tue = new System.Windows.Forms.RadioButton();
            this.Mon = new System.Windows.Forms.RadioButton();
            this.Daily = new System.Windows.Forms.RadioButton();
            this.repeatCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // setAlarmButton
            // 
            this.setAlarmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setAlarmButton.Location = new System.Drawing.Point(185, 219);
            this.setAlarmButton.Name = "setAlarmButton";
            this.setAlarmButton.Size = new System.Drawing.Size(191, 46);
            this.setAlarmButton.TabIndex = 28;
            this.setAlarmButton.Text = "Set";
            this.setAlarmButton.UseVisualStyleBackColor = true;
            this.setAlarmButton.Click += new System.EventHandler(this.setAlarmButton_Click);
            // 
            // repeatingAlarmPicker
            // 
            this.repeatingAlarmPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatingAlarmPicker.Location = new System.Drawing.Point(37, 55);
            this.repeatingAlarmPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.repeatingAlarmPicker.Name = "repeatingAlarmPicker";
            this.repeatingAlarmPicker.Size = new System.Drawing.Size(518, 53);
            this.repeatingAlarmPicker.TabIndex = 20;
            // 
            // Sun
            // 
            this.Sun.AutoSize = true;
            this.Sun.Location = new System.Drawing.Point(297, 169);
            this.Sun.Name = "Sun";
            this.Sun.Size = new System.Drawing.Size(77, 21);
            this.Sun.TabIndex = 37;
            this.Sun.TabStop = true;
            this.Sun.Text = "Sunday";
            this.Sun.UseVisualStyleBackColor = true;
            this.Sun.Visible = false;
            // 
            // Sat
            // 
            this.Sat.AutoSize = true;
            this.Sat.Location = new System.Drawing.Point(181, 169);
            this.Sat.Name = "Sat";
            this.Sat.Size = new System.Drawing.Size(86, 21);
            this.Sat.TabIndex = 36;
            this.Sat.TabStop = true;
            this.Sat.Text = "Saturday";
            this.Sat.UseVisualStyleBackColor = true;
            this.Sat.Visible = false;
            // 
            // Fri
            // 
            this.Fri.AutoSize = true;
            this.Fri.Location = new System.Drawing.Point(57, 169);
            this.Fri.Name = "Fri";
            this.Fri.Size = new System.Drawing.Size(68, 21);
            this.Fri.TabIndex = 35;
            this.Fri.TabStop = true;
            this.Fri.Text = "Friday";
            this.Fri.UseVisualStyleBackColor = true;
            this.Fri.Visible = false;
            // 
            // Thu
            // 
            this.Thu.AutoSize = true;
            this.Thu.Location = new System.Drawing.Point(428, 126);
            this.Thu.Name = "Thu";
            this.Thu.Size = new System.Drawing.Size(89, 21);
            this.Thu.TabIndex = 34;
            this.Thu.TabStop = true;
            this.Thu.Text = "Thursday";
            this.Thu.UseVisualStyleBackColor = true;
            this.Thu.Visible = false;
            // 
            // Wed
            // 
            this.Wed.AutoSize = true;
            this.Wed.Location = new System.Drawing.Point(297, 126);
            this.Wed.Name = "Wed";
            this.Wed.Size = new System.Drawing.Size(104, 21);
            this.Wed.TabIndex = 33;
            this.Wed.TabStop = true;
            this.Wed.Text = "Wednesday";
            this.Wed.UseVisualStyleBackColor = true;
            this.Wed.Visible = false;
            // 
            // Tue
            // 
            this.Tue.AutoSize = true;
            this.Tue.Location = new System.Drawing.Point(181, 126);
            this.Tue.Name = "Tue";
            this.Tue.Size = new System.Drawing.Size(84, 21);
            this.Tue.TabIndex = 32;
            this.Tue.TabStop = true;
            this.Tue.Text = "Tuesday";
            this.Tue.UseVisualStyleBackColor = true;
            this.Tue.Visible = false;
            // 
            // Mon
            // 
            this.Mon.AutoSize = true;
            this.Mon.Location = new System.Drawing.Point(57, 126);
            this.Mon.Name = "Mon";
            this.Mon.Size = new System.Drawing.Size(79, 21);
            this.Mon.TabIndex = 31;
            this.Mon.TabStop = true;
            this.Mon.Text = "Monday";
            this.Mon.UseVisualStyleBackColor = true;
            this.Mon.Visible = false;
            // 
            // Daily
            // 
            this.Daily.AutoSize = true;
            this.Daily.Location = new System.Drawing.Point(428, 169);
            this.Daily.Name = "Daily";
            this.Daily.Size = new System.Drawing.Size(60, 21);
            this.Daily.TabIndex = 38;
            this.Daily.TabStop = true;
            this.Daily.Text = "Daily";
            this.Daily.UseVisualStyleBackColor = true;
            this.Daily.Visible = false;
            // 
            // repeatCheckbox
            // 
            this.repeatCheckbox.AutoSize = true;
            this.repeatCheckbox.Location = new System.Drawing.Point(37, 12);
            this.repeatCheckbox.Name = "repeatCheckbox";
            this.repeatCheckbox.Size = new System.Drawing.Size(76, 21);
            this.repeatCheckbox.TabIndex = 39;
            this.repeatCheckbox.Text = "Repeat";
            this.repeatCheckbox.UseVisualStyleBackColor = true;
            this.repeatCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SetAlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 488);
            this.Controls.Add(this.repeatCheckbox);
            this.Controls.Add(this.Daily);
            this.Controls.Add(this.Sun);
            this.Controls.Add(this.Sat);
            this.Controls.Add(this.Fri);
            this.Controls.Add(this.Thu);
            this.Controls.Add(this.Wed);
            this.Controls.Add(this.Tue);
            this.Controls.Add(this.Mon);
            this.Controls.Add(this.setAlarmButton);
            this.Controls.Add(this.repeatingAlarmPicker);
            this.Name = "SetAlarmForm";
            this.Text = "Repeating Alarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setAlarmButton;
        private System.Windows.Forms.DateTimePicker repeatingAlarmPicker;
        private System.Windows.Forms.RadioButton Sun;
        private System.Windows.Forms.RadioButton Sat;
        private System.Windows.Forms.RadioButton Fri;
        private System.Windows.Forms.RadioButton Thu;
        private System.Windows.Forms.RadioButton Wed;
        private System.Windows.Forms.RadioButton Tue;
        private System.Windows.Forms.RadioButton Mon;
        private System.Windows.Forms.RadioButton Daily;
        private System.Windows.Forms.CheckBox repeatCheckbox;
    }
}