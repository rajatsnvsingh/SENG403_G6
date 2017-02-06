using System;
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
        Alarm alarm = new Alarm("../../alarm.wav");
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
            if (alarm.GetTime() != null && DateTime.Now.CompareTo(alarm.GetTime()) >= 0)
            {
                alarm.Cancel();
                alarm.play();
                AlarmActivatedLabel.Visible = true;
                snoozeButton.Visible = true;
                if (setAlarmButton.Text == "Alarm Set")
                {
                    setAlarmButton.Text = "Set Alarm";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            
            

        }

        private void setAlarmButton_Click(object sender, EventArgs e)
        {
            alarm.SetTime(alarmTimePicker.Value.Date + alarmTimePicker.Value.TimeOfDay);
            if (setAlarmButton.Text == "Set Alarm")
            {
                setAlarmButton.Text = "Alarm Set";
            }
        }

        private void cancelAlarmButton_Click(object sender, EventArgs e)
        {
            alarm.Cancel();
            AlarmActivatedLabel.Visible = false;
            snoozeButton.Visible = false;
            alarm.stop();
            if (setAlarmButton.Text == "Alarm Set")
            {
                setAlarmButton.Text = "Set Alarm";
            }
        }

        private void snoozeButton_Click(object sender, EventArgs e)
        {
            AlarmActivatedLabel.Visible = false;
            snoozeButton.Visible = false;
            alarm.Snooze(DateTime.Now);
            alarm.stop();
        }
    }

    public partial class AlarmNotification
    {
        public void ticked()
        {
           // new Form2().ShowDialog();
        }
    }

    public static class AlarmMessageBox
    {

    }
}
