using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_1
{
    class Program
    {
        class Bank
        {
            private string depName;
            private int acc;
            private string accType;
            private int balance;
            private static double rate;

            public Bank()
            {
                depName = "";
                acc = 0;
                accType = "";
                balance = 0;
                rate = 0.6;
            }

            public Bank(string a, int b, string c, int d)
            {
                depName = a;
                acc = b;
                accType = c;
                balance = d;
                rate = 0.6;
            }

            public Bank(Bank b)
            {
                depName = b.depName;
                acc = b.acc;
                accType = b.accType;
                balance = b.balance;
                rate = 0.6;
            }

            public int Acc
            {
                get
                {
                    return acc;
                }
            }

            public int Balance
            {
                get { return balance; }
            }

            public void deposit(int amt)
            {
                balance += amt;
                Console.WriteLine("Current balance is : {0}" , balance);
            }

            public void withDraw(int amt)
            {
                if (balance + 50 > amt)
                {
                    balance -= amt;
                    Console.WriteLine("Remaining balance is : {0}", balance);
                }
                else
                    Console.WriteLine("Not possible");
            }

            public void Disp()
            {
                Console.WriteLine("The details are : \nName : {0}\nAccount number is : {1}\nAccount type : {2}\nBalance : {3}\nRate is : {4}", depName, Acc, accType, Balance, rate);
            }

            public static void dispRate()
            {
                Console.WriteLine("The rate is : {0}", rate);
            }
        }
        static void Main(string[] args)
        {
            Bank ba = new Bank();
            Bank bb = new Bank("user1", 10, "Savings", 15000);
            int t;
            int ch;
            do
            {
                Console.WriteLine("Enter a choice: \n1 - Deposit\n2 - Withdraw\n3 - Display all the details\n4 - Display the Rate");
                ch = Int16.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter the amount");
                        t = Int16.Parse(Console.ReadLine());
                        ba.deposit(t);
                        break;
                    case 2: 
                        Console.WriteLine("Enter the amount");
                        t = Int16.Parse(Console.ReadLine());
                        ba.withDraw(t);
                        break;
                    case 3:
                        ba.Disp();
                        break;
                    case 4:
                        Bank.dispRate();
                        break;          

                }
            } while (ch == 1 || ch == 2 || ch == 3 || ch == 4);
        }
    }
}
