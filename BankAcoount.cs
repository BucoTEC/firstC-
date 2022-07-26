public class BankAccount{
    public string Number { get; }
    public string Owner {get;set;}
    public decimal Balance {get; set;}

    private static int Rand = 1234;

    public  BankAccount(string name, decimal initialBalance ){
        Owner = name;
        Balance = initialBalance;
        Number = Rand.ToString();
    }




}
