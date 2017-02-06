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
        DateTime? alarmTime = null;
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
            if (alarmTime != null && DateTime.Now.CompareTo(alarmTime) > 0)
            {
                alarmTime = null;
                new Form2().ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void setAlarmButton_Click(object sender, EventArgs e)
        {
            alarmTime = alarmTimePicker.Value.Date + alarmTimePicker.Value.TimeOfDay;
        }

        private void cancelAlarmButton_Click(object sender, EventArgs e)
        {
            alarmTime = null;
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
