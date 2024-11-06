using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_2
{
    internal class Time
    {
        public Time() { }

        public Time(byte p_hours, uint p_minutes)
        {
            hours = p_hours;
            if (p_minutes >= 60)
            {
                while (p_minutes >= 60)
                {
                    p_minutes -= 60;
                    hours++;
                }
                minutes = (byte)p_minutes;
            }
            else minutes = (byte)p_minutes;          
        }

        private byte hours;
        private byte minutes;

        private void Check()
        {
            if (minutes >= 60)
            {
                while (minutes >= 60)
                {
                    minutes -= 60;
                    hours++;
                }
            }
        }
        private bool CheckZero()
        {
            if (minutes == 0)
            {
                if (hours == 0)
                {
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
                while (num>= 60)
                {
                    num -= 60;
                    hours++;
                }
                minutes += (byte)num;
                if (minutes >= 60) Check();
                return this;
            }
            else
            {
                minutes += (byte)num;
                if (minutes >= 60) Check();
                return this;
            }
        }
        public static Time operator ++(Time p_time)
        {
            p_time.minutes += 1;
            p_time.Check();
            return p_time;
        }
        public static Time operator --(Time p_time)
        { 
            if(!p_time.CheckZero())
            {
                p_time.minutes -= 1;
            }
            return p_time;
        }
        public static explicit operator byte(Time p_time)
        {
            return p_time.hours;
        }
        public static implicit operator bool(Time p_time)
        {
            if (p_time.hours == 0 && p_time.minutes == 0) return false;
            else return true;
        }
        public static Time operator +(Time p_time, uint p_minutes)
        {
            if (p_minutes >= 60)
            {
                while (p_minutes >= 60)
                {
                    p_minutes -= 60;
                    p_time.hours++;
                }
                p_time.minutes += (byte)p_minutes;
                if(p_time.minutes >= 60)
                {
                    p_time.minutes -= 60;
                    p_time.hours++;
                }
                return p_time;
            }
            else
            {
                p_time.minutes += (byte)p_minutes;
                if (p_time.minutes >= 60)
                {
                    p_time.minutes -= 60;
                    p_time.hours++;
                }
                return p_time;
            }
        }
        public static Time operator +(uint p_minutes, Time p_time)
        {
            if (p_minutes >= 60)
            {
                while (p_minutes >= 60)
                {
                    p_minutes -= 60;
                    p_time.hours++;
                }
                p_time.minutes += (byte)p_minutes;
                if (p_time.minutes >= 60)
                {
                    p_time.minutes -= 60;
                    p_time.hours++;
                }
                return p_time;
            }
            else
            {
                p_time.minutes += (byte)p_minutes;
                if (p_time.minutes >= 60)
                {
                    p_time.minutes -= 60;
                    p_time.Check();
                }
                return p_time;
            }
        }
        public static Time operator -(Time p_time, uint p_minutes)
        {
            if ((uint)p_time.hours * 60 + (uint)p_time.minutes > p_minutes)
            {
                uint total_time = (uint)p_time.hours * 60 + (uint)p_time.minutes - p_minutes;
                p_time.hours = 0;
                while (total_time >= 60)
                {
                    total_time -= 60;
                    p_time.hours++;
                }
                p_time.minutes = (byte)total_time;
                return p_time;
            }
            else
            {
                p_time.hours = 0;
                p_time.minutes = 0;
                return p_time;
            }
            
        }
    }
}
