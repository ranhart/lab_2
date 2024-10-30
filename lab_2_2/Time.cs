using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
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
            Check();
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
        private bool CheckZero()
        {
            if (minutes == 0)
            {
                if (hours == 0)
                {
                    Console.WriteLine("Время не может уйти в минус");
                    return true;
                }
                else
                {
                    hours -= 1;
                    minutes += 60;
                    return false;
                }
            }
            else return false;
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
            if(!t.CheckZero())
            {
                t.minutes -= 1;
            }
            return t;
        }
        public static explicit operator byte(Time p_time)
        {
            return p_time.hours;
        }
        public static implicit operator bool(Time p_time)
        {
            if (p_time.hours == 0 && p_time.minutes == 0) return true;
            else return false;
        }
        public static Time operator +(Time p_time1, Time p_time2)
        {
            return 
        }
        public static Time operator -(Time p_time1, Time p_time2)
        {
            return
        }
    }
}
