using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    public class TimeSpan
    {

        private const int HoursPerDay = 24;
        private const int MinutesPerHour = 60;

        private int days;

        public TimeSpan()
        {
            this.days = 0;
        }

        public TimeSpan(int days) : this()
        {
            this.days = days;
        }

        public int CalculateHours()
        {
            int hours = this.days * HoursPerDay;
            return hours;
        }

        public int CalculateMinutes()
        {
            int minutes = this.days * HoursPerDay * MinutesPerHour;
            return minutes;
        }
    }
}
