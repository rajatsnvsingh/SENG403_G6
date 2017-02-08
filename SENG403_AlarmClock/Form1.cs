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
        
        /// <summary>
        /// Initializes Clock Display Window Form
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.currentTimeDisplay.Text = DateTime.Now.ToString("h:mm:ss tt");
            alarmTimePicker.Format = DateTimePickerFormat.Custom;
            alarmTimePicker.CustomFormat = "hh:mm:ss tt    MM/dd/yyyy";
        }

        /// <summary>
        /// Timer tick, updates current time, compares with alarm time (if set) to see if should ring.
        /// If alarm time reached, play alarm and display snooze button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Sets Alarm Clock window form as topmost window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            
    
        }

        /// <summary>
        /// Upon clicking Set Alarm button, turns off any previous alarm sound and sets alarm for specified time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setAlarmButton_Click(object sender, EventArgs e)
        {
            DateTime alarmTime = alarmTimePicker.Value.Date + alarmTimePicker.Value.TimeOfDay;
            if (DateTime.Now.CompareTo(alarmTime) >= 0)
            {
                return;
            }
            alarm.stop();
            alarm.SetTime(alarmTime);
            if (setAlarmButton.Text == "Set Alarm")
            {
                setAlarmButton.Text = "Alarm Set";
            }
        }

        /// <summary>
        /// Upon clicking Cancel button, cancels an alarm that has been set, or turns off currently ringing alarm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Upon clicking Snooze button after alarm rings, will add small delay to alarm time so that it will ring again 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
