using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePolymorphism
{
    internal class HorizontalEnemy : Enemy
    {
        public HorizontalEnemy() 
        {
            Console.WriteLine("Horizontal!");
        }
        public override void Move()
        {
            Console.WriteLine("Horizontal Class!");
        }
    }
}
