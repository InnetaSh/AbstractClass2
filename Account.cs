using AbstractClass2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//ам нужно создать систему управления финансовыми транзакциями для различных типов счетов (банковский счет, криптовалютный кошелек, счет кредитной карты и т.д.).
//Каждый тип счета имеет свои особенности обработки транзакций, а также методы для пополнения и снятия средств.

//Требования:
//Создайте абстрактный класс Account с методами Deposit(decimal amount), Withdraw(decimal amount) и DisplayBalance().


namespace AbstractClass2
{
    internal abstract class Account
    {
        public string Number { get; set; }
        public decimal Balance { get; set; }
        public Account(string number, decimal balance)
        {
            Number = number;
            Balance = balance;
        }
        public abstract Transaction Deposit(decimal amount);
        public abstract Transaction Withdraw(decimal amount);
        public abstract void DisplayBalance();
    }
}
