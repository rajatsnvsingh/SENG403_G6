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
        private double snoozeTime;

        public Alarm()
        {
            this.time = null;
            snoozeTime = 5;
        }

        public void SetTime(DateTime newTime)
        {
            this.time = newTime;
        }

        public void Snooze()
        {
            if (time.HasValue) {
                this.time = this.time.Value.AddMinutes(snoozeTime);
            }
        }

        public void Cancel()
        {
            this.time = null;
        }

        public DateTime? GetTime()
        {
            return time;
        }
    }
}
