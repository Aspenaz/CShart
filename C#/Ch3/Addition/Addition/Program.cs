﻿using System;

class Addition
{
    static void Main()
    {
        int number1;
        int number2;
        int sum;

        Console.Write("Enter the first integer: ");
        number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        number2 = int.Parse(Console.ReadLine());

        sum = number1 + number2;

        Console.WriteLine($"Sum is {sum}");

    }
}
