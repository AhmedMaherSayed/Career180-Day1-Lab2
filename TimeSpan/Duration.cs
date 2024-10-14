using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpan
{
    public class Duration
    {
        private int _hours;
        public int Hours 
        { 
            set
            {
                if(value < 0)
                    throw new ArgumentOutOfRangeException("value");

                _hours = value;
            }
            get
            {
                return _hours;
            }
        }

        private int _minutes;

        public int Minutes 
        {
            set
            {
                if (value >= 60)
                    throw new ArgumentOutOfRangeException("value");

                _minutes = value;
            }
            get
            {
                return _minutes;
            }
        }

        private int _seconds;   

        public int Seconds 
        { 
            set
            {
                if(value >= 60)
                    throw new ArgumentOutOfRangeException("value");

                _seconds = value;
            }
            get 
            { 
                return _seconds; 
            }
        }

        public Duration(int seconds)
        {
            if(seconds >= 3600)
            {
                Hours = seconds / 3600;
                seconds -= Hours * 3600;

                Minutes = seconds / 60;
                seconds -= Minutes * 60;
                Seconds = seconds;
            }
            else if (seconds >= 60)
            {
                Minutes = seconds / 60;
                seconds -= Minutes * 60;
                Seconds = seconds;
            }
            else
            {
                Seconds = seconds;
            }
            
        }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public override string ToString()
            => $"Hours: {Hours}, Minutes: {Minutes}, Seconds= {Seconds}";
    }
}
