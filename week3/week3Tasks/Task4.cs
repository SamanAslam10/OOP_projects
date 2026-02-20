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
            ClockType clockobject = new ClockType(2 , 30 , 40);
            clockobject.printTime();

            clockobject.incSec();
            Console.Write("Seconds Increment : ");
            clockobject.printTime();

            clockobject.incMin();
            Console.Write("Minutes Increment : ");
            clockobject.printTime();

            clockobject.incHrs();
            Console.Write("Hours Increment   : ");
            clockobject.printTime();

            bool flag = clockobject.isequal(8 , 37 , 40);
            Console.WriteLine("Flag :  " + flag);

            bool flag2 = clockobject.isequal(2, 30, 40);
            Console.WriteLine("Object Flag :  " + flag2);
        }
    }
    class ClockType
    {
        int hr;
        int min;
        int sec;

        public ClockType() 
        { }
        public ClockType(int hr , int min , int sec)
        {
            this.hr = hr;
            this.min = min;
            this.sec = sec;
        }
        public void printTime() 
        {
            Console.WriteLine("Hours : " + hr + " Minutes : " + min + " Seconds : " + sec);
        }
        public void incSec() 
        {
            sec++;
        }
        public void incMin()
        {
            min++;
        }
        public void incHrs()
        {
            hr++;
        }
        public bool isequal(int h , int m , int s) 
        {
            if (hr == h && min == m && sec == s)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}