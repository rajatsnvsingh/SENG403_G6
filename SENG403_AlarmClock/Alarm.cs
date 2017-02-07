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
        private DateTime? time;
        private DateTime? defaultTime;
        private double snoozeTime;
        SoundPlayer alarmSound;

        /// <summary>
        /// Alarm class constructor, takes in path filename for sound file
        /// </summary>
        /// <param name="alarmFile"></param>
        public Alarm(String alarmFile)
        {
            this.time = null;
            this.defaultTime = null;
            alarmSound = new SoundPlayer(alarmFile);
            snoozeTime = 0.1;
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
            this.time = newAlarm.GetTime();
            this.snoozeTime = newAlarm.GetSnoozeTime();
        }

        /// <summary>
        /// Set time for alarm instance
        /// </summary>
        /// <param name="newTime"></param>
        public void SetTime(DateTime newTime)
        {
            this.defaultTime = newTime;
            this.time = this.defaultTime;
        }

        /// <summary>
        /// Set time interval for alarm snooze in minutes
        /// </summary>
        /// <param name="snoozeMinutes"></param>
        public void setSnooze(double snoozeMinutes)
        {
            this.snoozeTime = snoozeMinutes;
        }

        /// <summary>
        /// Snooze an existing alarm by adding minutes until next alarm time
        /// </summary>
        /// <param name="currentTime"></param>
        public void Snooze(DateTime currentTime)
        {
            this.time = currentTime.AddMinutes(snoozeTime);
        }

        /// <summary>
        /// Cancel a set alarm
        /// </summary>
        public void Cancel()
        {
            this.time = null;
        }

        /// <summary>
        /// Gets the time for the alarm
        /// </summary>
        /// <returns></returns>
        public DateTime? GetTime()
        {
            return time;
        }

        /// <summary>
        /// Gets the time for the alarm with added snooze time 
        /// </summary>
        /// <returns></returns>
        public double GetSnoozeTime()
        {
            return snoozeTime;
        }
    }
}
