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
    public partial class MainApp : Form
    {
        Alarm alarm = new Alarm("../../alarm.wav");
        List<ToolStrip> alarmStrips = new List<ToolStrip>();

        /// <summary>
        /// Initializes Clock Display Window Form
        /// </summary>
        public MainApp()
        {
            InitializeComponent();             
            this.currentTimeDisplay.Text = DateTime.Now.ToString("h:mm:ss tt");
            nonrepeatingAlarmPicker.Format = DateTimePickerFormat.Custom;
            nonrepeatingAlarmPicker.CustomFormat = " MM/dd/yyyy  hh:mm:ss";
            repeatingAlarmPicker.Format = DateTimePickerFormat.Custom;
            repeatingAlarmPicker.CustomFormat = " hh:mm:ss";
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
            this.currentTimeDisplay.Text = DateTime.Now.ToString("h:mm:ss tt");
            
        }

        /// <summary>
        /// Set Alarm Clock window form as topmost window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            
    
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

        }
       
    }

}
