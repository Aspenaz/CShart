// 3. En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y $500,
// realizar un programa que lea los sueldos que cobra cada empleado e informe
// cuántos empleados cobran entre $100 y $300 y cuántos cobran más de $300.
// Además el programa deberá informar el importe que gasta la empresa en
// sueldos al personal.

using System;

class _3
{
    static void Main()
    {
        int contador = 1, cont_1 = 0, cont_2 = 0;
        float sumaSueldos = 0;

        Console.Write("Ingrese cantidad de empleados: ");
        int cant = int.Parse(Console.ReadLine());

        while(contador <= cant)
        {           
            Console.Write($"Ingrese sueldo {contador}: ");
            float sueldo = float.Parse(Console.ReadLine());

            if (sueldo >= 100 && sueldo <= 500)
            {
                contador++;
                sumaSueldos += sueldo;

                if (sueldo >= 100 && sueldo <= 300)
                {
                    cont_1++;
                }
                else
                {
                    cont_2++;
                }

            }
            else
            {
                Console.WriteLine("Error: Ingrese sueldos entre 100 y 500");
            }
        }

        Console.WriteLine($"\nSueldos entre 100 y 300: {cont_1}");
        Console.WriteLine($"Sueldos mayores a 300: {cont_2}");
        Console.WriteLine($"\nTotal sueldos: {sumaSueldos}");

        Console.ReadKey();

    }
}

