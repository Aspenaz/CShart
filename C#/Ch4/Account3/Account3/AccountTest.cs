using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AccountTest
{
    static void Main()
    {
        Account account1 = new Account("Jane Green");
        Account account2 = new Account("Jhon Blue");

        Console.WriteLine($"account1 name is: {account1.Name }");
        Console.WriteLine($"account2 name is: {account2.Name}");
    }
}
