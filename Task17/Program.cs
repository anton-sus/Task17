using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            Account<int> account1 = GetAccountInt();
            Console.WriteLine("номер счета-1: {0}\nбаланс: {1}\nфио: {2}\n", account1.AccName, account1.Balance, account1.UserName);

            Account<string> account2 = GetAccountString();
            Console.WriteLine("номер счета-2: {0}\nбаланс: {1}\nфио: {2}\n", account2.AccName, account2.Balance, account2.UserName);
            Console.ReadKey();

            Account<int> GetAccountInt()
            {
                Account<int> account = new Account<int>();
                Console.WriteLine("введите числовой номер счета, баланс, фио:");
                account.AccName = Convert.ToInt32(Console.ReadLine());
                account.Balance = Convert.ToDouble(Console.ReadLine());
                account.UserName = Convert.ToString(Console.ReadLine());
                return account;
            }
            Account<string> GetAccountString()
            {
                Account<string> account = new Account<string>();
                Console.WriteLine("введите строковый номер счета, баланс, фио:");
                account.AccName = Convert.ToString(Console.ReadLine());
                account.Balance = Convert.ToDouble(Console.ReadLine());
                account.UserName = Convert.ToString(Console.ReadLine());
                return account;
            }
        }
    }

    class Account<Т>
    {
        public Т AccName { get; set; }
        public double Balance { get; set; }
        public string UserName { get; set; }
    }
}
