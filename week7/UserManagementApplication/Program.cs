using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserUI userUI = new UserUI();
            userUI.Start();
        }
    }
}
