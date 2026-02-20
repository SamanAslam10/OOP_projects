using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "S:\\CS\\semester2\\OOP\\Lab\\code\\week1\\week1tasks\\week1tasks\\task10.txt";
            if (File.Exists(path))
            {
                StreamWriter task11 = new StreamWriter(path, true);
                task11.WriteLine("hahhhhaahahhahaaaaaaa");
                task11.Flush();
                task11.Close();

            }
        }
    }
}
