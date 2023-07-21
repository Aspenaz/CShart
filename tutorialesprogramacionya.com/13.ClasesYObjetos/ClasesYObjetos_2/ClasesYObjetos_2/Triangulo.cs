/* Problema 2:
    Desarrollar un programa que cargue los lados de un triángulo e implemente 
    los siguientes métodos: inicializar los atributos, imprimir el valor del 
    lado mayor y otro método que muestre si es equilátero o no.
*/

using System;


class Triangulo
{
    private int lado1, lado2, lado3;

    public void Inicializar()
    {
        Console.Write("Lado 1: ");
        lado1 = int.Parse(Console.ReadLine());

        Console.Write("Lado 2: ");
        lado2 = int.Parse(Console.ReadLine());

        Console.Write("Lado 3: ");
        lado3 = int.Parse(Console.ReadLine());  
    }

    public void LadoMayor()
    {
        Console.Write("Lado mayor: ");
        if (lado1 > lado2 && lado1 > lado3)
        {
            Console.WriteLine(lado1);
        }
        else
        {
            if(lado2 > lado3)
            {
                Console.WriteLine(lado2);
            }
            else
            {
                Console.WriteLine(lado3);
            }
        }
    }

    public void EsEquilatero()
    {
        if (lado1==lado2 && lado1 == lado3)
        {
            Console.WriteLine("Es un triángulo equilátero");
        }
        else
        {
            Console.WriteLine("No es equilátero!");
        }
    }

    static void Main()
    {
        Triangulo triangulo1 = new Triangulo();
        triangulo1.Inicializar();
        triangulo1.LadoMayor();
        triangulo1.EsEquilatero();

        Console.WriteLine($"\nLado1: {triangulo1.lado1} \nLado2: {triangulo1.lado2} \nLado3: {triangulo1.lado3}");


        Console.ReadKey();
    }
}

