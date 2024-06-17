using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Создайте класс Transaction, который будет содержать информацию о сумме транзакции и типе транзакции (пополнение или снятие).


namespace AbstractClass2
{
    internal class Transaction
    {
        public string TypeTransaction { get; set; }
        public decimal SumTransaction { get; set; }
        public string AccountNumber { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Банковский счет номер:{AccountNumber}    тип транзакции: {TypeTransaction}    сумма: {SumTransaction}");
        }
    }
}
