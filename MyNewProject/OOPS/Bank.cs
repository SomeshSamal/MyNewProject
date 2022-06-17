using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.OOPS
{
    class Bank
    {
        int account_num;
        string account_type;
        string customer_name;
        int balance;

        public void input(int account_num,string account_type,string customer_name,int balance)
        {
            this.account_num = account_num;
            this.account_type = account_type;
            this.customer_name = customer_name;
            this.balance = balance;
        }
        void display()
        {
            this.input(123456789, "Savings", "Somesh", 10000);
            Console.WriteLine(account_num + " " + account_type + " " + customer_name + " " + balance);
        }
        static void Main(string[] args)
        {
            Bank s = new Bank();
            s.display();
        }

    }
}
