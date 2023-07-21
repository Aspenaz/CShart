using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ComdicionalCompuesto1
{
    static void Main()
    {
        Console.Write("Ingrese 1er valor: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese 2do valor: ");
        int num2 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            int suma = num1 + num2;
            int resta = num1 - num2;
            Console.WriteLine($"{num1} > {num2} | suma: {suma} | resta: {resta}");
            
        }
        else if (num1 == num2)
        {
            Console.WriteLine($"{num1} = {num2}");
        }
        else
        {
            float producto = num1 * num2;
            float division = num2 / num1;   
            Console.WriteLine($"{num2} > {num1} | producto: {producto} | division: {division,4:F}");
        }
    }
}

