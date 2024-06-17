using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass2
{
    internal class CreditCardAccount : Account
    {
        public CreditCardAccount(string number, decimal balance) : base(number, balance) { }
        public override Transaction Deposit(decimal amount)
        {
            Balance += amount;
            var Transaction1 = new Transaction();
            Transaction1.TypeTransaction = "deposit";
            Transaction1.SumTransaction = amount;
            Transaction1.AccountNumber = Number;
            Console.WriteLine($"Средства внесены на кредитный счет {Number}.");
            return Transaction1;
        }

        public override Transaction Withdraw(decimal amount)
        {
            Balance -= amount;
            var Transaction1 = new Transaction();
            Transaction1.TypeTransaction = "withdraw";
            Transaction1.SumTransaction = amount;
            Transaction1.AccountNumber = Number;
            Console.WriteLine($"Средства сняты с кредитного счета {Number}.");
            return Transaction1;
        }
        public override void DisplayBalance()
        {
            Console.WriteLine($"Баланс на кредитном счете {Number}:   {Balance}."); ;
        }


    }
}
