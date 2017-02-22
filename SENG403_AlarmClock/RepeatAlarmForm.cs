using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SENG403_AlarmClock
{
    public partial class RepeatAlarmForm : Form
    {

        MainApp mainApp;

        public RepeatAlarmForm(MainApp mainApp)
        {
            this.mainApp = mainApp;
            InitializeComponent();
            repeatingAlarmPicker.Format = DateTimePickerFormat.Custom;
            repeatingAlarmPicker.CustomFormat = "hh:mm:ss tt";
        }

        private void repeatAlarmButton_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Parse(repeatingAlarmPicker.Text);
            if (Mon.Checked)
            {
                mainApp.addWeeklyAlarm(DayOfWeek.Monday, dt);
            }
            if (Tue.Checked)
            {
                mainApp.addWeeklyAlarm(DayOfWeek.Tuesday, dt);
            }
            if (Wed.Checked)
            {
                mainApp.addWeeklyAlarm(DayOfWeek.Wednesday, dt);
            }
            if (Thu.Checked)
            {
                mainApp.addWeeklyAlarm(DayOfWeek.Thursday, dt);
            }
            if (Fri.Checked)
            {
                mainApp.addWeeklyAlarm(DayOfWeek.Friday, dt);
            }
            if (Sat.Checked)
            {
                mainApp.addWeeklyAlarm(DayOfWeek.Saturday, dt);
            }
            if (Sun.Checked)
            {
                mainApp.addWeeklyAlarm(DayOfWeek.Sunday, dt);
            }
            if (Daily.Checked)
            {
                mainApp.addDailyAlarm(dt);
            }
        }
    }
}
