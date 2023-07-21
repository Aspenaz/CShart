/* Problema 4:
    Desarrollar una clase que represente un Cuadrado y tenga los siguientes 
    métodos: cargar el valor de su lado, imprimir su perímetro y su superficie.
*/

using System;

class Cuadrado
{
    private int lado;

    public void Inicializar()
    {
        Console.Write("Ingrese el valor del lado: ");
        lado = int.Parse(Console.ReadLine());
    }

    public void ImprimePerimetro()
    {
        int perimetro;
        perimetro = lado * 4;
        Console.WriteLine("El perimetro es: " + perimetro);
    }

    public void ImprimeSuperficie()
    {
        int superficie;
        superficie = lado * lado;
        Console.WriteLine("La superficie es: " +  superficie);  
    }

    static void Main()
    {
        Cuadrado cuadrado1 = new Cuadrado();    

        cuadrado1.Inicializar();
        cuadrado1.ImprimePerimetro();
        cuadrado1.ImprimeSuperficie();

        Console.ReadKey();
    }
}

