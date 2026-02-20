using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    internal class task8
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM(1000000);
            while (true)
            {
                Console.WriteLine("Which action do u want to perform : ");
                Console.WriteLine("1.Deposit");
                Console.WriteLine("2.Withdraw");
                Console.WriteLine("3.Check Balance");
                Console.WriteLine("4.Transaction History");
                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("Enter the amount you want to deposit");
                    float deposit = float.Parse(Console.ReadLine());
                    atm.Deposit(deposit);
                }
                if (option == 2)
                {
                    Console.WriteLine("Enter the amount you want to withdraw");
                    float withdraw = float.Parse(Console.ReadLine());
                    atm.Withdraw(withdraw);
                }
                if (option == 3)
                {
                    atm.checkBalance();

                }
                if (option == 4)
                {
                    atm.History();
                }

            }

        }
    }

    class ATM
    {
        public float amount;
        list<string> history = new list<string>;

        public ATM(float money)
        {
            amount = money;
        }

        public void Deposit(float deposit)
        {
            amount += deposit;
            history = { deposit + " is deposited in the account"}
            ;
        }
        public void Withdraw(float withdraw)
        {
            if (withdraw < amount)
            {
                amount -= withdraw;
                history = { withdraw + " is withdrawn from the account"}
                ;
            }
            else
            {
                Console.WriteLine("Not enough amount in balance to withdraw.");
            }

        }
        public void checkBalance()
        {
            Console.WriteLine("The Balance is " + amount);
        }
        public void History(float amount)
        {
            foreach (string h in history)
            {
                Console.WriteLine(h);
            }
        }
    }
}