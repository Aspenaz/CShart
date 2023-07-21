/* Problema 1:
    Confeccionar una clase que permita carga el nombre y la edad de una 
    persona. Mostrar los datos cargados. Imprimir un mensaje si es mayor 
    de edad (edad>=18)
*/

using System;

class Persona
{
    private string nombre;
    private int edad; 

    public void Inicializar()
    {
        Console.Write("Ingrese nombre: ");
        nombre = Console.ReadLine();

        Console.Write("Ingrese edad: ");
        edad = int.Parse(Console.ReadLine());   
    }

    public void Imprimir()
    {
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
    }

    public void EsMayorEdad()
    {
        if (edad >= 18)
        {
            Console.WriteLine("Es mayor de edad");
        }
        else
        {
            Console.WriteLine("No es mayor de edad");
        }
        Console.ReadKey();
    }

    static void Main()
    {
        Persona persona1 = new Persona();
        persona1.Inicializar();
        persona1.Imprimir();
        persona1.EsMayorEdad();
    }
}

