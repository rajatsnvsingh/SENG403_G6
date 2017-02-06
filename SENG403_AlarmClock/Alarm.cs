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
        private DateTime? time;
        private DateTime? defaultTime;
        private double snoozeTime;
        SoundPlayer alarmSound;

        public Alarm(String alarmFile)
        {
            this.time = null;
            this.defaultTime = null;
            alarmSound = new SoundPlayer(alarmFile);
            snoozeTime = 0.1;
        }

        public void play()
        {
            alarmSound.Play();
        }

        public void stop()
        {
            alarmSound.Stop();
        }

        public Alarm(Alarm newAlarm)
        {
            this.time = newAlarm.GetTime();
            this.snoozeTime = newAlarm.GetSnoozeTime();
        }

        public void SetTime(DateTime newTime)
        {
            this.defaultTime = newTime;
            this.time = this.defaultTime;
        }

        public void setSnooze(double snoozeMinutes)
        {
            this.snoozeTime = snoozeMinutes;
        }

        public void Snooze(DateTime currentTime)
        {
            this.time = currentTime.AddMinutes(snoozeTime);
        }

        public void Cancel()
        {
            this.time = null;
        }

        public DateTime? GetTime()
        {
            return time;
        }

        public double GetSnoozeTime()
        {
            return snoozeTime;
        }
    }
}
