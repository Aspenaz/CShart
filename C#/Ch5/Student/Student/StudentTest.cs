using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StudentTest
{
    static void Main()
    {
        //string letterGrade = string.Empty;
        //Console.WriteLine(letterGrade);
        //letterGrade = "A";
        //Console.WriteLine(letterGrade);

        Console.Write("Enter the name: ");
        string theName = Console.ReadLine();

        Console.Write("Enter average: ");
        int theAverage = int.Parse(Console.ReadLine());

        Student student1 = new Student(theName, theAverage);
 
        //Student student1 = new Student("Jane Green", 93);
        //Student student2 = new Student("Jhon Blue", 72);

        Console.Write($"{student1.Name}'s letter grade equivalent of ");
        Console.WriteLine($"{student1.Average} is {student1.LetterGrade}" );

        //Console.Write($"{student2.Name}'s letter grade equivalent of ");
        //Console.WriteLine($"{student2.Average} is {student2.LetterGrade}");
    }
}
