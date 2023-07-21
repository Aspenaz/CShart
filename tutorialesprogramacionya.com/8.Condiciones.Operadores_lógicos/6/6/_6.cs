// De un operario se conoce su sueldo y los años de antigüedad. Se
// pide confeccionar un programa que lea los datos de entrada e informe:
// a) Si el sueldo es inferior a 500 y su antigüedad es igual o superior
//    a 10 años, otorgarle un aumento del 20 %, mostrar el sueldo a pagar.
// b) Si el sueldo es inferior a 500 pero su antigüedad es menor a 10 años,
//    otorgarle un aumento de 5 %.
// c) Si el sueldo es mayor o igual a 500 mostrar el sueldo en pantalla sin cambios.

using System;

class _6
{
    static void Main()
    {
        double nuevoSueldo;

        Console.Write("Ingrese sueldo: ");
        float sueldo = float.Parse(Console.ReadLine());

        Console.Write("Ingrese antiguedad: ");
        float antiguedad = float.Parse(Console.ReadLine());

        if (sueldo < 500 && antiguedad >= 10)
        {
            nuevoSueldo = sueldo + (sueldo * 0.2f);
            Console.WriteLine($"Sueldo a pagar: {nuevoSueldo,2:C}");
        }
        else
        {
            if (sueldo < 500 )400
            {
                nuevoSueldo = sueldo + (sueldo * 0.05f);
                Console.WriteLine($"Sueldo a pagar: {nuevoSueldo,2:C}");
            }
            else
            {
                Console.WriteLine($"Sueldo a pagar: {sueldo,2:C}");
            }

        }

        Console.ReadKey();

    }
}

