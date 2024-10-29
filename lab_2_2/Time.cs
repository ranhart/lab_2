using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_2
{
    internal class Time
    {
        public Time() { }

        public Time(byte p_minutes) 
        {
            minutes = p_minutes;
            Check();
        }

        public Time(byte p_hours, byte p_minutes)
        {
            hours = p_hours;
            minutes = p_minutes;
        }

        private byte hours;
        private byte minutes;

        private void Check()
        {
            if (minutes >= 60)
            {
                byte cnt = 0;
                while (minutes >= 60)
                {
                    minutes -= 60;
                    cnt++;
                }
                hours += cnt;
            }
        }
        private void CheckZero()
        {
            if (minutes == 0)
            {
                if (hours == 0)
                {

                }

            }
        }
        public void Print()
        {
            Console.WriteLine($"Hours: {hours}, minutes: {minutes}");
        }
        public Time Add(uint num)
        {
            if (num >= 60)
            {
                byte cnt = 0;
                uint x = num; 
                while (x>= 60)
                {
                    x -= 60;
                    cnt++;
                }
                hours += cnt;
                minutes += (byte)x;
            }
            return this;
        }
        public static Time operator ++(Time p_time)
        {
            var t = p_time;
            t.minutes += 1;
            t.Check();
            return t;
        }
        public static Time operator --(Time p_time)
        {
            var t = p_time;
            t.minutes -= 1;
            t.Check();
            return t;
        }

    }
}
