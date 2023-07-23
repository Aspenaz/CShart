/* Problema 1:
    Se tiene la siguiente información:
    · Nombres de 4 empleados.
    · Ingresos en concepto de sueldo, cobrado por cada empleado, en los últimos 3 meses.
    Confeccionar el programa para:

    a) Realizar la carga de la información mencionada.
    b) Generar un vector que contenga el ingreso acumulado en sueldos en los últimos 3 meses para cada empleado.
    c) Mostrar por pantalla el total pagado en sueldos a todos los empleados en los últimos 3 meses
    d) Obtener el nombre del empleado que tuvo el mayor ingreso acumulado
*/



using System;

class Matriz9
{
    private string[] empleados;
    private int[,] sueldos;
    private int[] sueldosTotal;

    public void Cargar()
    {
        empleados = new string[4];
        sueldos = new int[4,3];

        for (int f = 0; f < empleados.Length; f++)
        {
            Console.Write("\nIngrese nombre del empleado: ");
            empleados[f] = Console.ReadLine();

            for(int c = 0; c < sueldos.GetLength(1);  c++)
            {
                Console.Write("Ingrese sueldo: ");
                sueldos[f,c] = int.Parse(Console.ReadLine());
            }
        }
    }

    public void CalcularSumaSueldos()
    {
        sueldosTotal = new int[4];

        for (int f = 0; f < sueldos.GetLength(0); f++)
        {
            int suma = 0;

            for (int c = 0; c < sueldos.GetLength(1); c++)
            {
                suma = suma + sueldos[f,c];
            }
            sueldosTotal[f] = suma;
        }
    }

    public void ImprimirTotalPagado()
    {
        Console.WriteLine("Total de sueldos pagados por empleados: ");

        for(int f = 0; f < sueldosTotal.Length; f++)
        {
            Console.WriteLine(empleados[f] + " - " + sueldosTotal[f]);
        }
    }

    public void EmpleadoMayorSueldo()
    {
        int mayor = sueldosTotal[0];
        string nom = empleados[0];

        for (int f = 0; f < sueldosTotal.Length; f++)
        {
            if (sueldosTotal[f] > mayor)
            {
                mayor = sueldosTotal[f];
                nom = empleados[f];
            }
        }
        Console.WriteLine("El empleado con mayor sueldo es " + nom + " que tiene un sueldo de " + mayor); 
    }


    static void Main()
    {
        Matriz9 m = new Matriz9();

        m.Cargar();
        m.CalcularSumaSueldos();
        m.ImprimirTotalPagado();    
        m.EmpleadoMayorSueldo();

        Console.ReadKey();
    }
}



/*

Ingrese nombre del empleado: JF Kennedy
Ingrese sueldo: 25000
Ingrese sueldo: 23000
Ingrese sueldo: 43000
Ingrese nombre del empleado: Miguel Velasquez
Ingrese sueldo: 5000
Ingrese sueldo: 4000
Ingrese sueldo: 3000
Ingrese nombre del empleado: Jhonn
Ingrese sueldo: 25000
Ingrese sueldo: 23000
Ingrese sueldo: 24000
Ingrese nombre del empleado: Loreto
Ingrese sueldo: 12000
Ingrese sueldo: 14000
Ingrese sueldo: 13000
Total de sueldos pagados por empleados
JF Kennedy - 91000
Miguel Velasquez - 12000
Jhonn  - 72000
Loreto - 39000
El empleado con mayor sueldo es JF Kennedy que tiene un sueldo de 91000

*/
