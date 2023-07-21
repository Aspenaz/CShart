/* Problema 3:
    Una empresa tiene dos turnos (mañana y tarde) en los que trabajan 8 
    empleados (4 por la mañana y 4 por la tarde). Confeccionar un programa 
    que permita almacenar los sueldos de los empleados agrupados por turno.
    Imprimir los gastos en sueldos de cada turno.
*/

using System;

class Vector3
{
    private float[] turnoMañana;
    private float[] turnoTarde;

    public void Cargar()
    {
        turnoMañana = new float[4];
        turnoTarde = new float[4];

        Console.WriteLine("Sueldos turno mañana.");
        for (int f = 0; f < 4; f++)
        {
            Console.Write($"Ingrese sueldo {f+1}: ");
            turnoMañana[f] = float.Parse(Console.ReadLine());
        }

        Console.WriteLine("Sueldos turno tarde");
        for(int f = 0;f < 4; f++)
        {
            Console.Write($"Ingrese sueldo {f+1}: ");
            turnoTarde[f] = float.Parse(Console.ReadLine());
        }
    }

    public void CalcularGastos()
    {
        float man = 0, tar = 0;

        for (int f = 0; f < 4; f++)
        {
            man += turnoMañana[f];
            tar += turnoTarde[f];
        }

        Console.WriteLine("Total turno mañana: " + man);
        Console.WriteLine("Total turno tarde: " + tar);
        Console.ReadKey();
    }

    static void Main()
    {
        Vector3 v3 = new Vector3();

        v3.Cargar();
        v3.CalcularGastos();
    }
}

