using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePolymorphism
{
    internal class Enemy
    {
        public virtual void Move() 
        {
            Console.WriteLine("Parent class!");
        }
    }
}
