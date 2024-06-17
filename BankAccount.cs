using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Создайте классы-наследники BankAccount, CryptoWallet и CreditCardAccount, которые будут наследовать от класса Account и предоставлять свою реализацию методов Deposit, Withdraw и DisplayBalance.


namespace AbstractClass2
{
    internal class BankAccount : Account
    {
        public BankAccount(string number, decimal balance) : base(number, balance) { }
        public override Transaction Deposit(decimal amount)
        {
            Balance += amount;
            var Transaction1 = new Transaction();
            Transaction1.TypeTransaction = "deposit";
            Transaction1.SumTransaction = amount;
            Transaction1.AccountNumber = Number;
            Console.WriteLine($"Средства внесены на банковский счет {Number}.");
            return Transaction1;
        }
       
        public override Transaction Withdraw(decimal amount)
        {
            bool flag = false;
            if (Balance >= amount)
            {
                Balance -= amount;
                flag = true;
            }
            var Transaction1 = new Transaction();
            Transaction1.TypeTransaction = "withdraw";
            Transaction1.SumTransaction = amount;
            Transaction1.AccountNumber = Number;
            if(!flag)
                Console.WriteLine($"Недостаточно средств на счету {Number}.");
            else
                Console.WriteLine($"Средства сняты с банковского счета {Number}.");
            return Transaction1;
        }
        public override void DisplayBalance()
        {
            Console.WriteLine($"Баланс на банковском счете {Number}:   {Balance}."); ;
        }

       
    }
}
