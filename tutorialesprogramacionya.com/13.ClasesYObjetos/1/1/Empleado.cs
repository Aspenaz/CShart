/* Confeccionar una clase que represente un empleado. Definir como atributos 
   su nombre y su sueldo. Confeccionar los métodos para la carga, otro para 
   imprimir sus datos y por último uno que imprima un mensaje si debe pagar 
   impuestos (si el sueldo supera a 3000)
*/

using System;

class Empleado
{
    private string nombre;
    private int sueldo;

    public void Inicializar()
    {
        Console.Write("Ingrese nombre: ");
        nombre = Console.ReadLine();

        Console.Write("Ingrese sueldo: ");
        sueldo = int.Parse(Console.ReadLine());
    }

    public void Imprime()
    {
        Console.WriteLine($"\nNombre: {nombre}");
        Console.WriteLine($"Sueldo: {sueldo}");
    }

    public void Impuestos()
    {
        if (sueldo > 3000)
        {
            Console.WriteLine("Debe pagar impuestos");
        }
        else
        {
            Console.WriteLine("No paga impuestos");
        }
    }

    static void Main()
    {
        Empleado empleado1 = new Empleado();

        empleado1.Inicializar();    
        empleado1.Imprime();    
        empleado1.Impuestos();

        Console.ReadKey();
    }
}

