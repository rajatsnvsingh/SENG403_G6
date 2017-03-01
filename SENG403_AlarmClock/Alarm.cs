using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace SENG403_AlarmClock
{
    public class Alarm
    {
        //instance variables
        private DateTime defaultAlarmTime; //default time (for repeated alarms) - this should only be changed by user
        private DateTime notifyTime; //when the alarm should go off after being snoozed
        private double snoozeTime = 1.0;
        private SoundPlayer alarmSound = new SoundPlayer(@"alarm.wav");
        private int repeatIntervalDays; //how many days before alarm goes off
        private bool enabled = false;

        public static Alarm createDailyAlarm(DateTime alarmTime, double snoozeTime)
        {
            TimeSpan ts = new TimeSpan(alarmTime.Hour, alarmTime.Minute, alarmTime.Second);
            DateTime dt = DateTime.Today.Add(ts);
            return new Alarm(dt, 1, snoozeTime);
        }

        public static Alarm createWeeklyAlarm(DayOfWeek day, DateTime alarmTime)
        {
            return null;
        }

        //create an alarm which is set to disabled by default
        public Alarm() { }

        public bool isEnabled()
        {
            return enabled;
        }

        public Alarm(DateTime alarmTime, int repeatInterval, double snoozeTime)
        {
            defaultAlarmTime = notifyTime = alarmTime;
            this.repeatIntervalDays = repeatInterval;
            this.snoozeTime = snoozeTime;

        }

        /// <summary>
        /// Alarm class constructor, takes in path filename for sound file
        /// </summary>
        /// <param name="alarmFile"></param>
        public Alarm(string alarmFile, double snoozeTime)
        {
            alarmSound = new SoundPlayer(alarmFile);
            this.snoozeTime = snoozeTime;
        }

        /// <summary>
        /// Plays SoundPlayer file for alarm
        /// </summary>
        public void play()
        {
            alarmSound.Play();
        }

        /// <summary>
        /// Stops playing SoundPlayer file for alarm
        /// </summary>
        public void stop()
        {
            alarmSound.Stop();
        }

        /// <summary>
        /// Copy Constructor for Alarm class
        /// </summary>
        /// <param name="newAlarm"></param>
        public Alarm(Alarm newAlarm)
        {
            snoozeTime = newAlarm.GetSnoozeTime();
        }

        /// <summary>
        /// Set time for alarm instance
        /// </summary>
        /// <param name="newTime"></param>
        public void SetTime(DateTime newTime)
        {

        }

        /// <summary>
        /// Set time interval for alarm snooze in minutes
        /// </summary>
        /// <param name="snoozeMinutes"></param>
        public void setSnooze(double snoozeMinutes)
        {

            this.snoozeTime = snoozeMinutes;
        }

        internal void setDailyAlarm(DateTime alarmTime)
        {
            enabled = true;
            repeatIntervalDays = 1;
            TimeSpan ts = new TimeSpan(alarmTime.Hour, alarmTime.Minute, alarmTime.Second);
            DateTime dt = DateTime.Today.Add(ts);
            defaultAlarmTime = dt;
            if (defaultAlarmTime.CompareTo(DateTime.Now) <= 0)
                defaultAlarmTime.AddDays(repeatIntervalDays);
            notifyTime = defaultAlarmTime;
        }

        internal void setWeeklyAlarm(DayOfWeek day, DateTime alarmTime)
        {
            enabled = true;
            repeatIntervalDays = 7;
            TimeSpan ts = new TimeSpan(alarmTime.Hour, alarmTime.Minute, alarmTime.Second);
            defaultAlarmTime = DateTime.Today.AddDays(day - DateTime.Now.DayOfWeek).Add(ts);
            if (defaultAlarmTime.CompareTo(DateTime.Now) <= 0)
                defaultAlarmTime.AddDays(repeatIntervalDays);
            notifyTime = defaultAlarmTime;
        }

        internal void setOneTimeAlarm(DateTime dt)
        {
            enabled = true;
            repeatIntervalDays = -1;
            defaultAlarmTime = notifyTime = dt;
        }

        /// <summary>
        /// Snooze an existing alarm by adding minutes until next alarm time
        /// </summary>
        /// <param name="currentTime"></param>
        public void Snooze(DateTime currentTime)
        {
            alarmSound.Stop();
            notifyTime = currentTime.AddMinutes(snoozeTime);
            Console.WriteLine(notifyTime);
        }

        /// <summary>
        /// Gets the time for the alarm
        /// </summary>
        /// <returns></returns>
        public DateTime? GetTime()
        {
            return notifyTime;
        }

        /// <summary>
        /// Gets the time for the alarm with added snooze time 
        /// </summary>
        /// <returns></returns>
        public double GetSnoozeTime()
        {
            return snoozeTime;
        }

        public override string ToString()
        {
            if (repeatIntervalDays == -1)
            {
                return defaultAlarmTime.ToString("hh:mm:ss tt, MM/dd");
            }
            if (repeatIntervalDays == 1)
            {
                return defaultAlarmTime.ToString("hh:mm:ss tt, daily");
            }
            if (repeatIntervalDays == 7)
            {
                return defaultAlarmTime.ToString("hh:mm:ss tt, weekly");
            }
            return "Not Set";
        }

        public void update()
        {
            if (repeatIntervalDays != -1)
            {
                defaultAlarmTime = defaultAlarmTime.AddDays(repeatIntervalDays);
                notifyTime = defaultAlarmTime;
            }
            else
            {
                enabled = false;
            }
        }

        internal void disable()
        {
            enabled = false;
        }

        internal void setSound(string fileName)
        {
            alarmSound = new SoundPlayer(fileName);
        }
    }
}