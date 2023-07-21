/* Problema 3:
    Desarrollar una clase que represente un punto en el plano y tenga los 
    siguientes métodos: cargar los valores de x e y, imprimir en que cuadrante 
    se encuentra dicho punto (concepto matemático, primer cuadrante si x e y 
    son positivas, si x<0 e y>0 segundo cuadrante, etc.)
*/

using System;

class Punto
{
    private int x, y;

    public void Inicializar()
    {
        Console.Write("Ingrese coordenada x: ");
        x = int.Parse(Console.ReadLine());

        Console.Write("Ingrese coordenada y: ");
        y = int.Parse(Console.ReadLine());
    }

    void Cuadrante()
    {
        if (x > 0 && y > 0)
        {
            Console.WriteLine("Se encuentra en el primer cuadrante");
        }
        else
        {
            if (x < 0 && y > 0)
            {
                Console.WriteLine("Se encuentra en el segundo cuadrante");
            }
            else
            {
                if (x < 0 && y < 0)
                {
                    Console.WriteLine("Se encuentra en el tercer cuadrante");
                }
                else
                {
                    if(x > 0 && y < 0)
                    {
                        Console.WriteLine("Se encuentra en el cuarto cuadrante");
                    }
                    else
                    {
                        Console.Write("El punto no está en un cuadrante");
                    }
                }
            }
        }

        Console.ReadKey();

    }

    static void Main()
    {
        Punto punto1 = new Punto();
        punto1.Inicializar();
        punto1.Cuadrante();
    }
}

