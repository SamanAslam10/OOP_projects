using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int accNum = 1234567;
            string holderName = "Ali";
            float balance = 10000;

            BankAccount b1 = new BankAccount(accNum , holderName , balance);

            while (true) 
            {
                int option = menu();
                if (option == 1)
                {
                    Console.Write("Enter the Account Number : ");
                    int number = int.Parse(Console.ReadLine());
                    Console.Write("Enter Account Holder name : ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Account Balance : ");
                    float amount = float.Parse(Console.ReadLine());

                    BankAccount b2 = new BankAccount(accNum , name , amount);
                }
                if (option == 2)
                {
                    Console.WriteLine("Enter the amount you want to deposit");
                    float deposit = float.Parse(Console.ReadLine());
                    b1.Deposit(deposit);
                }
                if (option == 3)
                {
                    Console.WriteLine("Enter the amount you want to withdraw");
                    float withdraw = float.Parse(Console.ReadLine());
                    b1.Withdraw(withdraw);
                }
                if (option == 4)
                {
                    b1.checkBalance();
                }
                if (option == 5)
                {
                    b1.accdetails();
                }
            }
        }

        static int menu() 
        {
            Console.WriteLine("Which action do u want to perform : ");
            Console.WriteLine("1.New Bank Account");
            Console.WriteLine("2.Deposit");
            Console.WriteLine("3.Withdraw");
            Console.WriteLine("4.Check Balance");
            Console.WriteLine("5.Account Details");
            
            int option = int.Parse(Console.ReadLine());
            return option;
        }
    }
    class BankAccount 
    {
        public int AccNum;
        public string HolderName;
        public float Balance;

        public BankAccount(int accNum, string holderName, float balance)
        {
            this.AccNum = accNum;
            this.HolderName = holderName;
            this.Balance = balance;
        }
        public void Deposit(float deposit)
        {
            Balance += deposit;
            

        }
        public void Withdraw(float withdraw)
        {
            Balance -= withdraw;
        }
        public void checkBalance()
        {
            Console.WriteLine("The Balance is " + Balance);
        }
        public void accdetails() 
        {
            Console.WriteLine(AccNum + " " + HolderName + " " + Balance);
        }
    }
    
}