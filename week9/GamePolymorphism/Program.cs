using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Enemy> enemy = new List<Enemy>();  
            enemy.Add(new VerticalEnemy());
            enemy.Add(new HorizontalEnemy());
            enemy.Add(new DiagonalEnemy());

            while (true) 
            {
                foreach (Enemy e in enemy) 
                {
                    e.Move();
                }
                Console.ReadKey();
            }
        }
    }
}
