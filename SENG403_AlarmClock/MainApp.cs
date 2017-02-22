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
            repeatingAlarmPicker.Format = DateTimePickerFormat.Custom;
            repeatingAlarmPicker.CustomFormat = " hh:mm:ss tt";
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
            AlarmActivatedLabel.Visible = false;
            snoozeButton.Visible = false;
        }

        private void creatAlarmButton_Click(object sender, EventArgs e)
        {
            ToolStripItem[] dummyItems = new ToolStripItem[3];
            dummyItems[0] = new ToolStripLabel("00:00:00");
            dummyItems[1] = new ToolStripButton("Set");
            dummyItems[2] = new ToolStripButton("Edit");
            ToolStrip dummyStrip = new ToolStrip(dummyItems);
            dummyStrip.GripStyle = ToolStripGripStyle.Hidden;
            alarmStrips.Add(dummyStrip);
            alarmsList.TopToolStripPanel.Join(alarmStrips[alarmStrips.Count-1],alarmStrips.Count-1);
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

        private void repeatAlarmButton_Click(object sender, EventArgs e)
        {
            if (Mon.Checked)
            {

            }
            if (Tue.Checked)
            {

            }
            if (Wed.Checked)
            {

            }
            if (Thu.Checked)
            {

            }
            if (Fri.Checked)
            {

            }
            if (Sat.Checked)
            {

            }
            if (Sun.Checked)
            {

            }
            if (Daily.Checked)
            {

            }
        }

        private void nonrepeatAlarmButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Alarm a in alarms)
            {

            }
        }

        private void setCurrentTime_Click(object sender, EventArgs e)
        {
            currentTime = DateTime.Parse(debugDateTimePicker.Text);
            currentTimeDisplay.Text = currentTime.ToString("h:mm:ss tt");
        }
    }

}
