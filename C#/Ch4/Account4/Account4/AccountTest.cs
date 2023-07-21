using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AccountTest
{
    static void Main()
    {
        Account account1 = new Account("Jane Green", 50.00m);
        Account account2 = new Account("Jhon Blue", -7.53m);

        //display initial balance for each object
        Console.WriteLine($"{account1.Name}'s balance: {account1.Balance}");
        Console.WriteLine($"{account2.Name}'s balance: {account2.Balance}");

        Console.Write("\nEnter deposit amount for account1: ");
        decimal depositAmount = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"adding {depositAmount} to account1 {account1.Name} balance\n");
        account1.Deposit(depositAmount);

        Console.WriteLine($"{account1.Name}'s balance: {account1.Balance}");
        Console.WriteLine($"{account2.Name}'s balance: {account2.Balance}");

        Console.Write("\nEnter deposit amount for account2: ");
        depositAmount = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"adding {depositAmount} to account2 {account2.Name} balance\n");
        account2.Deposit(depositAmount);

        Console.WriteLine($"{account1.Name}'s balance: {account1.Balance}");
        Console.WriteLine($"{account2.Name}'s balance: {account2.Balance}");
    }
}
