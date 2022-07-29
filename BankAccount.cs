namespace BankAccount;
    public class Account
    {
        public string Number {get;}
        public string Owner {get; set;}
        public decimal Balance {get;}

        private static int numberSeed = 1235;
        public static string test = "hello from test";
        public Account(string name, decimal initialBalance){
            Balance = initialBalance;
            Owner = name;
            Number = numberSeed.ToString();
            numberSeed ++;
        }
        public void MakeDeposid(decimal amount, DateTime date, string note){}

        public void MakeWidthrawl(decimal amount, DateTime date, string note){}

        
    }
