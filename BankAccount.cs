namespace BankAccount;
    public class Account
    {
        public string Number {get;}
        public string Owner {get; set;}
        public decimal Balance {get;}


        public Account(string name, decimal initialBalance){
            Balance = initialBalance;
            Owner = name;
        }
        public void MakeDeposid(decimal amount, DateTime date, string note){}

        public void MakeWidthrawl(decimal amount, DateTime date, string note){}

        
    }