﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace SENG403_AlarmClock
{
    public partial class Form1 : Form
    {
        Alarm alarm = new Alarm();
        Form2 popup = new Form2();

        public Form1()
        {
            InitializeComponent();
            this.currentTimeDisplay.Text = DateTime.Now.ToString("h:mm:ss tt");
            this.alarmTimePicker.Format = DateTimePickerFormat.Time;
            this.alarmTimePicker.ShowUpDown = true;
        }

        private void mainTimerTick(object sender, EventArgs e)
        {
            this.currentTimeDisplay.Text = DateTime.Now.ToString("h:mm:ss tt");
            if (alarm.GetTime() != null && DateTime.Now.CompareTo(alarm.GetTime()) > 0)
            {
                alarm.Cancel();
                new Form2(alarm).ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void setAlarmButton_Click(object sender, EventArgs e)
        {
            alarm.SetTime(alarmTimePicker.Value.Date + alarmTimePicker.Value.TimeOfDay);
        }
    }

    public partial class AlarmNotification
    {
        public void ticked()
        {
            new Form2().ShowDialog();
        }
    }

    public static class AlarmMessageBox
    {

    }
}
