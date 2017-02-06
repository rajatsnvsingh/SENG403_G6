using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENG403_AlarmClock
{
    public class Alarm
    {
        private DateTime? time;
        private DateTime? defaultTime;
        private double snoozeTime;

        public Alarm()
        {
            this.time = null;
            this.defaultTime = null;
            snoozeTime = 0.1;
        }

        public Alarm(Alarm newAlarm)
        {
            this.time = newAlarm.GetTime();
            this.snoozeTime = newAlarm.GetSnoozeTime();
        }

        public void SetTime(DateTime newTime)
        {
            this.defaultTime = newTime;
            this.time = this.defaultTime;        }

        public void Snooze(DateTime? currentTime)
        {
            if (time.HasValue) {
                this.time = currentTime.Value.AddMinutes(snoozeTime);
            }
        }

        public void Cancel()
        {
            this.time = this.defaultTime;
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
