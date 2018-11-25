using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        //Global Scope

        static void Main(string[] args)
        {
            //Local Scope

            //Declaring variables
            //double a;
            //bool a;
            //string a;
            //int a;
            //float a;
            //char a;

            //Assigning variables
            //double a = 12.12;
            //bool a = true;
            //string a = "12.12";
            //int a = 12;
            //float a = 12.12;
            //char a = 'A';

            //Initialising Values (Decalred and assigned simultaneously)
            //double a = 12.12;
            //bool a = true;
            //string a = "12.12";
            //int a = 12;
            //float a = 12.12;
            //char a = 'A';

            //Variables
            string Name = "";
            int age = 0;

            //Code
            Console.Write("Insert name here: ");
            Name = Console.ReadLine();

            Console.Write("Please enter your age: ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("My name is " + Name);
            Console.Write("My age is " + age);
            Console.ReadKey();


        }
    }
}
