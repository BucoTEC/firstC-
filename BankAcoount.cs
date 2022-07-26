public class BankAccount{
    public string Number { get; }
    public string Owner {get;set;}
    public decimal Balance {get; set;}

    public  BankAccount(string name, decimal initialBalance ){
        Owner = name;
        Balance = initialBalance;
    }



}
