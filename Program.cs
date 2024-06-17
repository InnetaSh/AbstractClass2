using AbstractClass2;

BankAccount accountB1 = new BankAccount("123456", 3000.5m);
BankAccount accountB2 = new BankAccount("111111", 1000.25m);
CryptoWallet accountCript1 = new CryptoWallet("2222222", 5000.0m);
CreditCardAccount accountCredit1 = new CreditCardAccount("3333333", 10000.0m);

AccountManager AccManager = new AccountManager();
AccManager.AddAccount(accountB1);
AccManager.AddAccount(accountB2);
AccManager.AddAccount(accountCript1);
AccManager.AddAccount(accountCredit1);
AccManager.ShowAccount();
Console.WriteLine();
AccManager.Deposit("123456", 500.0m);
AccManager.Withdraw("111111", 2000.0m);
AccManager.Withdraw("3333333", 20000.0m);
AccManager.Withdraw("1110111", 2000.0m);
AccManager.ShowTransactios();
Console.WriteLine();
AccManager.ShowAccount();