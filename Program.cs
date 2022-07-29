using BankAccount;

var newAccount = new Account("Adnan", 123);

Console.WriteLine($"Hello from {newAccount.Owner} and his number is {newAccount.Number}");


var secondAccount = new Account("Nejra", 333);

Console.WriteLine(Account.test);

Console.WriteLine($"Hello from {secondAccount.Owner} and his number is {secondAccount.Number}");
