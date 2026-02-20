using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePolymorphism
{
    internal class DiagonalEnemy : Enemy
    {
        public DiagonalEnemy() 
        {
            Console.WriteLine("Diagonal ");
        }
        public override void Move()
        {
            Console.WriteLine("Diagonal Class!");
        }
    }
}
