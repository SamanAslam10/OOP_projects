using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Member
    {
        public string Name;
        public int ID;
        public List<string> booksBought;
        public int noOFBooks;
        public float moneyINBank;
        public float AmountSpent;

        public Member() { }
        public void ModifyMemeber() { }
        public void SetMember() { }
        public void GetMember() { }

        public void UpdateBooks() { }
        public void ModifyBooks() { }
        public void showBooks() { }

        public void UpdateAmountSpent() { }
        public void ModifyAmountSpent() { }
        public void showAmountSpent() { }
    }
}