using System;
using System.Linq;



class Program
{
    static void Main()
    {

        string name;
        int age;
        float salary;
        Console.WriteLine("Please enter your Name,Age and Salary:");

        //Write your code here

        name = Console.ReadLine();
        age = int.Parse(Console.ReadLine());
        salary = float.Parse(Console.ReadLine());

        //

        Console.WriteLine("Name:{0}", name);
        Console.WriteLine("Age:{0}", age);
        Console.WriteLine("Salary:{0}", salary);

    }
}


