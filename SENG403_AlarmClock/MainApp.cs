using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SENG403_AlarmClock
{
    public partial class MainApp : Form
    {
        List<ToolStrip> alarmStrips = new List<ToolStrip>();
        DateTime currentTime = DateTime.Now; //keep track of the current time to support manually setting the time
        List<Alarm> alarms = new List<Alarm>();

        /// <summary>
        /// Initializes Clock Display Window Form
        /// </summary>
        public MainApp()
        {
            InitializeComponent();
            currentTimeDisplay.Text = currentTime.ToString("h:mm:ss tt");
            nonrepeatingAlarmPicker.Format = DateTimePickerFormat.Custom;
            nonrepeatingAlarmPicker.CustomFormat = " MM/dd/yyyy  hh:mm:ss tt";
            debugDateTimePicker.Format = DateTimePickerFormat.Custom;
            debugDateTimePicker.CustomFormat = " MM/dd/yyyy hh:mm:ss tt";
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
                if(alarm != null)
                {
                    Console.WriteLine(alarm.GetTime() + " " + currentTime);
                    if (currentTime.CompareTo(alarm.GetTime()) >= 0)
                    {
                        Console.WriteLine("An alarm has gone off!");
                        dismissAlarmButton.Visible = true;
                        snoozeButton.Visible = true;
                        alarmActivatedLabel.Visible = true;
                    }
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
        }

        private void creatAlarmButton_Click(object sender, EventArgs e)
        {
            ToolStripItem[] dummyItems = new ToolStripItem[4];
            dummyItems[0] = new ToolStripLabel("00:00:00");
            dummyItems[1] = new ToolStripButton("Set No-Repeat");
            dummyItems[2] = new ToolStripButton("Set Repeat");
            dummyItems[3] = new ToolStripButton("Cancel");
            dummyItems[2].Click += (snd, evt) =>
            {
                new RepeatAlarmForm(this).ShowDialog(this);
            };
            dummyItems[3].Click += (snd, evt) =>
            {
                alarms.RemoveAt(alarmStrips.Count);
            };
            ToolStrip dummyStrip = new ToolStrip(dummyItems);
            dummyStrip.GripStyle = ToolStripGripStyle.Hidden;
            alarmStrips.Add(dummyStrip);
            alarmsList.TopToolStripPanel.Join(alarmStrips[alarmStrips.Count-1],alarmStrips.Count-1);
        }

        public void addDailyAlarm(DateTime dt)
        {
            alarms.Add(Alarm.createDailyAlarm(dt));
        }

        public void addWeeklyAlarm(DayOfWeek day, DateTime dt)
        {
            alarms.Add(Alarm.createWeeklyAlarm(day, dt));
        }

        private void alarmsManagerButton_Click(object sender, EventArgs e)
        {
            if (alarmsList.TopToolStripPanel.Controls.Count == 0)
            {
                for (int i = 0; i < alarmStrips.Count; i++)
                {
                    alarmsList.TopToolStripPanel.Join(alarmStrips[i], i);
                }
            }else { alarmsList.TopToolStripPanel.Controls.Clear(); }
            
            creatAlarmButton.Visible = !creatAlarmButton.Visible;
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
                    if (DateTime.Now.CompareTo(alarm.GetTime()) >= 0)
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
                
                foreach (Alarm alarm in alarms)
                {
                    alarm.setSnooze(newSnooze);
                }
                setSnoozeButton.Text = "Set Snooze";
            }

            
        }

 
    }

}
