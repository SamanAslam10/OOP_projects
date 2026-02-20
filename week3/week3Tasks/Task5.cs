using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClockType clockObject = new ClockType(5 , 30 , 25);
            clockObject.elapsedTime();
            clockObject.RemainingTime();
            clockObject.PrintTime();
        }
    }
    class ClockType
    {
        int hr;
        int min;
        int sec;
        int hrs;
        int mins;
        int secs;

        public ClockType() 
        { }
        public ClockType(int hr , int min , int sec)
        {
            this.hr = hr;
            this.min = min;
            this.sec = sec;
        }
       
        public int elapsedTime() 
        {
            int seconds = sec;
            seconds = min * 60;
            seconds = hr * 3600 ;
            return seconds;
        }

        public int RemainingTime()
        {

            int seconds = (60 - sec);
            secs = 60 - sec;
            seconds = (60 - min) * 60;
            mins = (60 - min);
            seconds = (24 - hr) * 3600;
            hrs = 24 - hr;
            return seconds;
        }

        public void PrintTime() 
        {
            Console.WriteLine("Elapsed Time   : " + hr + ":" + min + ":" + sec);
            Console.WriteLine("Remaining Time : " + hrs + ":" + mins + ":" + secs);
        }
    }
}