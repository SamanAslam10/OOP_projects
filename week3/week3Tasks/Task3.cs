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
            
            Car car = new Car("Ali",50);
            car.IncreaseSpeed(15);
            car.FuelDecrease(15);
            car.Damage();
            car.Lapcount(4);
            car.ToString();

        }
    }
    public class Car 
    {
        public string name;
        public float speed;
        public float acceleration;
        public int fuellevel;
        public int damagelevel;
        public double position;
        public int lapcount;

        public Car() 
        {
            speed = 50;
        }
        public Car( string name , int fuellevel  ) 
        {
            this.name = name;
            this.acceleration =0;
            this.fuellevel = fuellevel;
            damagelevel = 0;
            lapcount = 0;
            position = 0;            
        }
       
        public void IncreaseSpeed(float acceleration) 
        {
            if (acceleration >= 10) 
            {
                speed += 10;
            }
        }
        public void FuelDecrease(float acceleration) 
        {
            if (acceleration >= 10)
            {
                 fuellevel -= 10;
            }
            if (fuellevel < 10) 
            {
                Refuel();
            }
        }
        public void Damage() 
        {
            damagelevel += 10;
            if ( damagelevel > 90) 
            {
                DamageRepair();
            }
        }
        public void Refuel()
        {
            Console.WriteLine("Refueling Done!");
            fuellevel = 70;
        }
        public void DamageRepair() 
        {
            damagelevel -= 40;
        }
        public void Lapcount(int position) 
        {
            if (position > 2) 
            {
                lapcount += 1;
            }
        }
        public void ToString()
        {
            Console.WriteLine("Name : " + name + " Speed : " + speed  + " Acceleration : " + acceleration +  " Fuel Level : " + fuellevel+ " Damage Level : " + damagelevel + " Position : " + position + " Lap Count : " + lapcount );
        }
    }
}