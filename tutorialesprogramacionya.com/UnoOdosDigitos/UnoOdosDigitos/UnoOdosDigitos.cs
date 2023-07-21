using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class UnoOdosDigitos
{
    static void Main()
    {
        Console.Write("Ingrese número: ");
        int num = int.Parse(Console.ReadLine());

        if (num >= 10)
        {
            if (num < 100)
            {
                Console.WriteLine("Número es de dos dígitos!");
            }
            else
            {
                Console.WriteLine("Número es de más de dos dígitos");   
            }
        }
        else
        {
            Console.WriteLine("Número es de un dígito");
        }

        Console.ReadKey();  
        
    }
}

