// See https://aka.ms/new-console-template for more information
using Test;
string adnan = "   pozdrav moje ime je adnan sta ima kod vas";

var trimovan = adnan.Trim();
string[] imena = {"Riad", "Advna"};
Console.WriteLine(trimovan.Contains("adnan"));
Safet.Hello();
Safet.MyName();
if(args.Length != 0){

Console.WriteLine(args[0]);
}
foreach (var item in imena)
{
    Console.WriteLine(item);
}
