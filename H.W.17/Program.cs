using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.W._17
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int num = Convert.ToInt32(Console.ReadLine());
            double bal = Convert.ToDouble(Console.ReadLine());
            string nam = Console.ReadLine();
            BankAccount<string> abs = new BankAccount<string>();
            abs.SetInfo(str,bal,nam);
            abs.GetInfo(str, bal, nam);
            BankAccount<int> abs1 = new BankAccount<int>();
            abs1.SetInfo(num, bal, nam);
            abs1.GetInfo(num, bal, nam);
            Console.ReadKey();
            
        }
    }
    class BankAccount<T>
    {
        private T idAccount { get; set; }
        private double balance { get; set; }
        private string name { get; set; }
        public void SetInfo<T>(T a, double b, string s)
        {
            T IDAccount = a;
            double Balance =b;
            string Name = s;

        }
        public void GetInfo<T>(T a, double b, string s)
        {
            Console.WriteLine($"счет - {a},Баланс-{b},Имя-{s}");
        }
        public T IDAccount
        {
            set
            {
                idAccount = value;
            }
            get
            {
                return idAccount;
            }
        }
        public double Balance
        {
            set
            {
                balance = value;
            }
            get
            {
                return balance;
            }
        }

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

    }


}
