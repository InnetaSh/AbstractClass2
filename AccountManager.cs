using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

//Создайте класс AccountManager, который будет содержать список аккаунтов и метод для добавления аккаунта в этот список.
//В классе AccountManager реализуйте методы для выполнения транзакций (пополнение и снятие средств).

namespace AbstractClass2
{
    internal class AccountManager
    {
        public List<Account> Accounts { get; set; }
        public List<Transaction> Transactions { get; set; }

        public AccountManager()
        {
            Accounts = new List<Account>();
            Transactions = new List<Transaction>();
        }
        public void AddAccount(Account account)
        {
            Accounts.Add(account);

        }
        public void Deposit(string AccountNumber, decimal amound)
        {
            bool flag = false;
            foreach (var ac in Accounts)
            {
                if (ac.Number == AccountNumber)
                {
                    var Transaction1 = ac.Deposit(amound);
                    Transactions.Add(Transaction1);
                    flag = true;
                    break;
                }
                
            }
            if (!flag)
                Console.WriteLine("Аккаунт не найден.");
        }
        public void Withdraw(string AccountNumber, decimal amound)
        {
            bool flag = false;
            foreach (var ac in Accounts)
            {
                if (ac.Number == AccountNumber)
                {

                    var Transaction1 = ac.Withdraw(amound);
                    Transactions.Add(Transaction1);
                    flag = true;
                    break;
                }
            }
            if (!flag)
                Console.WriteLine("Аккаунт не найден.");
        }
        public void ShowAccount()
        {
            foreach (var ac in Accounts)
                ac.DisplayBalance();
        }
        public void ShowTransactios()
        {
            foreach (var transact in Transactions)
                transact.PrintInfo();
        }
    }
}
