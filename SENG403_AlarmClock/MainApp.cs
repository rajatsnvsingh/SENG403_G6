using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SENG403_AlarmClock
{
    public partial class MainApp : Form
    {
        const int INIT_ALARM_COUNT = 3; //total number of alarms supported
        DateTime currentTime = DateTime.Now; //keep track of the current time to support manually setting the time
        List<Alarm> alarms = new List<Alarm>(); //list of alarms
        double globalSnooze = 0.1 ;  
        /// <summary>
        /// Initializes Clock Display Window Form
        /// </summary>
        public MainApp()
        {
            InitializeComponent();
            currentTimeDisplay.Text = currentTime.ToString("h:mm:ss tt");
            debugDateTimePicker.Format = DateTimePickerFormat.Custom;
            debugDateTimePicker.CustomFormat = " MM/dd/yyyy hh:mm:ss tt";
            for (int i = 0; i < INIT_ALARM_COUNT; i++)
                alarms.Add(new Alarm());
        }

        /// <summary>
        /// Updates Timer tick and curreny time display.
        /// Checks if current time equal to alarm time (if set)
        /// If alarm time equal to current time, will play alarm and display snooze button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainTimerTick(object sender, EventArgs e)
        {
            currentTime = currentTime.AddSeconds(1);
            currentTimeDisplay.Text = currentTime.ToString("h:mm:ss tt");
            foreach (Alarm alarm in alarms)
            {
                if (alarm.isEnabled() && currentTime.CompareTo(alarm.GetTime()) >= 0)
                {
                    dismissAlarmButton.Visible = true;
                    snoozeButton.Visible = true;
                    alarmActivatedLabel.Visible = true;
                }
            }
        }

        /// <summary>
        /// Set Alarm Clock window form as topmost window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //TopMost = true;
        }

        /// <summary>
        /// Upon clicking Snooze button after alarm rings, will add small delay to alarm time so that it will ring again 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void snoozeButton_Click(object sender, EventArgs e)
        {
            alarmActivatedLabel.Visible = false;
            snoozeButton.Visible = false;
            
            foreach (Alarm alarm in alarms) {

                alarm.Snooze(currentTime);
            }
        }

        private int alarm_index = -1; //hacky way to update the alarm at that index

        public void setDailyAlarm(DateTime dt)
        {
            alarms[alarm_index].setDailyAlarm(dt);
        }

        public void setWeeklyAlarm(DayOfWeek day, DateTime dt)
        {
            alarms[alarm_index].setWeeklyAlarm(day, dt);
        }

        public void setOneTimeAlarm(DateTime dt)
        {
            alarms[alarm_index].setOneTimeAlarm(dt);
        }

        private void nonrepeatAlarmButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Alarm a in alarms)
            {
                Console.WriteLine(a);
            }
        }

        private void setCurrentTime_Click(object sender, EventArgs e)
        {
            currentTime = DateTime.Parse(debugDateTimePicker.Text);
            currentTimeDisplay.Text = currentTime.ToString("h:mm:ss tt");
        }

        private void dismissAlarmButton_Click(object sender, EventArgs e)
        {
            //right now, just dismiss all alarms which have gone off
            //will need a better way to deal with multiple alarms next sprint
            dismissAlarmButton.Visible = false;
            snoozeButton.Visible = false;
            alarmActivatedLabel.Visible = false;

            foreach (Alarm alarm in alarms)
            {
                if(alarm != null)
                {
                    if (currentTime.CompareTo(alarm.GetTime()) >= 0 && alarm.isEnabled())
                    {
                        alarm.update();
                    }
                }
               
            }
        }

        /// <summary>
        /// Click Set Snooze button to manually set snooze interval for alarms
        /// First click to show numeric list for values to choose from (min 1, max 60)
        /// Second click to confirm and set snooze to value chosen on numeric list (in minutes)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setSnoozeButton_Click(object sender, EventArgs e)
        {
            //set new snooze interval
            if(setSnoozeButton.Text == "Set Snooze")
            {
                snoozeTimeUpDown.Visible = true; //can also manually type in minutes (1-60)
                snoozeMinutesLabel.Visible = true;

                setSnoozeButton.Text = "Confirm Snooze";
            }


            //confirm new snooze interval
            else if(setSnoozeButton.Text == "Confirm Snooze")
            {
                snoozeTimeUpDown.Visible = false;
                snoozeMinutesLabel.Visible = false;
                
                //set snooze interval in minutes for each alarm
                double newSnooze = Convert.ToDouble(snoozeTimeUpDown.Value);
                globalSnooze = newSnooze;
                
                foreach (Alarm alarm in alarms)
                {
                    alarm.setSnooze(globalSnooze);
                    double changedSnooze = alarm.GetSnoozeTime();
                }
                
                setSnoozeButton.Text = "Set Snooze";
            }
            
        }

        private void cancel0_Click(object sender, EventArgs e)
        {
            alarms[0].disable();
            alarm0_label.Text = "Not set";
        }

        private void cancel1_Click(object sender, EventArgs e)
        {
            alarms[1].disable();
            alarm1_label.Text = "Not set";
        }

        private void cancel2_Click(object sender, EventArgs e)
        {
            alarms[2].disable();
            alarm2_label.Text = "Not set";
        }

        private void edit0_Click(object sender, EventArgs e)
        {
            alarm_index = 0;
            new SetAlarmForm(this).ShowDialog();
            alarm0_label.Text = alarms[0].ToString();
        }

        private void edit1_Click(object sender, EventArgs e)
        {
            alarm_index = 1;
            new SetAlarmForm(this).ShowDialog();
            alarm1_label.Text = alarms[1].ToString();
        }

        private void edit2_Click(object sender, EventArgs e)
        {
            alarm_index = 2;
            new SetAlarmForm(this).ShowDialog();
            alarm2_label.Text = alarms[2].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = !label1.Visible;
            alarm0_label.Visible = !alarm0_label.Visible;
            alarm1_label.Visible = !alarm1_label.Visible;
            alarm2_label.Visible = !alarm2_label.Visible;
            edit0.Visible = !edit0.Visible;
            edit1.Visible = !edit1.Visible;
            edit2.Visible = !edit2.Visible;
            cancel0.Visible = !cancel0.Visible;
            cancel1.Visible = !cancel1.Visible;
            cancel2.Visible = !cancel2.Visible;
        }
    }

}
