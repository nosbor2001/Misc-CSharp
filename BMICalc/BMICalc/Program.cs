using System;
using System.Linq;



class Program
{
    static void Main()
    {


        double height = 0.0;
        double weight = 0.0;

        double bmi;
        Console.Write("Enter your height in m:");
        height = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter your weight in kg:");
        weight = Convert.ToDouble(Console.ReadLine());

        //Write your code here
        //BMI = weight / (height * height)

        bmi = weight / (height * height);

        //


        Console.WriteLine("Your BMI is:{0}", Math.Round(bmi, 4));


    }
}


