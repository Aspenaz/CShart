/* Problema 3:
    Realizar un programa que permita ingresar el peso (en kilogramos) de piezas.
    El proceso termina cuando ingresamos el valor 0. Se debe informar:
    a) Cuántas piezas tienen un peso entre 9.8 Kg. y 10.2 Kg.?, cuántas con 
       más de 10.2 Kg.? y cuántas con menos de 9.8 Kg.?
    b) La cantidad total de piezas procesadas.
*/

using System;

class DoWhile_3
{
    static void Main()
    {
        float cant1 = 0, cant2 = 0, cant3 = 0, peso, suma;
        do
        {
            Console.Write("Ingrese peso: ");
            peso = float.Parse(Console.ReadLine());   

            if (peso > 10.2)
            {
                cant1++;
            }
            else
            {
                if (peso >= 9.2)
                {
                    cant2++;
                }
                else
                {
                    if (peso > 0)
                    {
                        cant3++;
                    }
                }
            }


        } while (peso != 0);

        suma = cant1 + cant2 + cant3;

       // Console.WriteLine($"Cant1: {cant1} | Cant2: {cant2} | Cant3: {cant3} | Suma: {suma}");
        Console.WriteLine($">10.2: {cant1} | Aptas: {cant2} | <9.8: {cant3} | Total piezas: {suma}");

        Console.ReadKey();
    }
}

