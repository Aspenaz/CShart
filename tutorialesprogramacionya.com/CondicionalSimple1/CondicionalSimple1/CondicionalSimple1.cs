using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CondicionalSimple1
{
    static void Main()
    {
        Console.Write("Ingrese el sueldo: ");
        float sueldo = float.Parse(Console.ReadLine());

        if (sueldo > 3000)
        {
            Console.Write("Debe abonar impuestos");
        }

        Console.ReadKey();  
    }
}

