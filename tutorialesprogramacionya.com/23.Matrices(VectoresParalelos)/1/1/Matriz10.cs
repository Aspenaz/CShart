﻿/* 
Se desea saber la temperatura media trimestral de cuatro paises. Para 
ello se tiene como dato las temperaturas medias mensuales de dichos paises.
Se debe ingresar el nombre del país y seguidamente las tres temperaturas medias mensuales.
Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en memoria.
a - Cargar por teclado los nombres de los paises y las temperaturas medias mensuales.
b - Imprimir los nombres de las paises y las temperaturas medias mensuales de las mismas.
c - Calcular la temperatura media trimestral de cada país.
d - Imprimir los nombres de los paises y las temperaturas medias trimestrales.
e - Imprimir el nombre del país con la temperatura media trimestral mayor.

 */


using System;

class Matriz10
{
    private string[] paises;
    private int[,] temperaturaMedia;
    private int[] temperaturaTrimestral;

    public void Cargar()
    {
        paises = new string[4];
        temperaturaMedia = new int[4, 3];

        for (int f = 0; f < paises.Length; f++)
        {
            Console.Write("Ingrese nombre del país: ");
            paises[f] = Console.ReadLine();

            for (int c = 0; c < temperaturaMedia.GetLength(1); c++)
            {
                Console.Write("Ingrese temperatura mensual: ");
                temperaturaMedia[f,c] = int.Parse(Console.ReadLine());
                
            }
        }
    }

    public void ImprimirTempMensual()
    {
        for(int f = 0; f < paises.Length; f++)
        {
            Console.Write("Pais: " + paises[f] + ": ");

            for (int c = 0; c < temperaturaMedia.GetLength(1); c++)
            {
                Console.Write(temperaturaMedia[f,c] + " ");
            }
            Console.WriteLine();    
        }
    }

    public void CalcularTemperaturaTrimestral()
    {
        temperaturaTrimestral = new int[4]; 

        for(int f = 0; f < temperaturaMedia.GetLength(0); f++)
        {
            int suma = 0;

            for (int c = 0; c < temperaturaMedia.GetLength(1); c++)
            {
                suma = suma + temperaturaMedia[f, c];
            }
            temperaturaTrimestral[f] = suma / 3;
        }
    }

    public void ImprimirTempTri()
    {
        Console.WriteLine("Temperaturas trimestrales: ");

        for (int f = 0; f < paises.Length; f++)
        {
            Console.WriteLine(paises[f] + " " + temperaturaTrimestral[f]);      
        }
    }

    public void PaisMayorTemp()
    {
        int mayor = temperaturaTrimestral[0];
        string nom = paises[0];

        for (int f = 0; f < paises.Length; f++)
        {
            if (temperaturaTrimestral[f] > mayor)
            {
                mayor = temperaturaTrimestral[f];
                nom = paises[f];
            }
        }
        Console.WriteLine("\nPais con temperatura trimestral mayor es " + nom + " que tiene una temperatura de " + mayor);
    }



    static void Main()
    {
        Matriz10 m = new Matriz10();

        m.Cargar();
        m.ImprimirTempMensual();
        m.CalcularTemperaturaTrimestral();
        m.ImprimirTempTri();
        m.PaisMayorTemp();

        Console.ReadKey();


    }
}

