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
    public partial class SetAlarmForm : Form
    {

        MainApp mainApp;

        public SetAlarmForm(MainApp mainApp)
        {
            this.mainApp = mainApp;
            InitializeComponent();
            repeatingAlarmPicker.Format = DateTimePickerFormat.Custom;
            repeatingAlarmPicker.CustomFormat = "hh:mm:ss tt";
        }

        private void setAlarmButton_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Parse(repeatingAlarmPicker.Text);
            if (repeatCheckbox.Checked)
            {
                if (Mon.Checked)
                {
                    mainApp.setWeeklyAlarm(DayOfWeek.Monday, dt);
                }
                if (Tue.Checked)
                {
                    mainApp.setWeeklyAlarm(DayOfWeek.Tuesday, dt);
                }
                if (Wed.Checked)
                {
                    mainApp.setWeeklyAlarm(DayOfWeek.Wednesday, dt);
                }
                if (Thu.Checked)
                {
                    mainApp.setWeeklyAlarm(DayOfWeek.Thursday, dt);
                }
                if (Fri.Checked)
                {
                    mainApp.setWeeklyAlarm(DayOfWeek.Friday, dt);
                }
                if (Sat.Checked)
                {
                    mainApp.setWeeklyAlarm(DayOfWeek.Saturday, dt);
                }
                if (Sun.Checked)
                {
                    mainApp.setWeeklyAlarm(DayOfWeek.Sunday, dt);
                }
                if (Daily.Checked)
                {
                    mainApp.setDailyAlarm(dt);
                }
            }
            else
            {
                mainApp.setOneTimeAlarm(dt);
            }
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (repeatCheckbox.Checked)
            {
                Mon.Visible = true;
                Tue.Visible = true;
                Wed.Visible = true;
                Thu.Visible = true;
                Fri.Visible = true;
                Sat.Visible = true;
                Sun.Visible = true;
                Daily.Visible = true;
                repeatingAlarmPicker.CustomFormat = "hh:mm:ss tt";
            }
            else
            {
                Mon.Visible = false;
                Tue.Visible = false;
                Wed.Visible = false;
                Thu.Visible = false;
                Fri.Visible = false;
                Sat.Visible = false;
                Sun.Visible = false;
                Daily.Visible = false;
                repeatingAlarmPicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            }
        }
    }
}
