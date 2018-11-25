using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            Get the user to think of a number then type it in
            Show Add 4.
            Show Multiply by 2.
            Show Subtract 6.
            Show Divide by 2.
            Show subtract the number you started with.
            **/

            Console.Write("Input a number: ");
            int input = int.Parse(Console.ReadLine());
            int output = input;


            //Console.Write("Select an option, 1 - 6: ");
            //int choice = int.Parse(Console.ReadLine());

            output = output + 4;
            Console.WriteLine("Add 4: " + output);

            output = output * 2;
            Console.WriteLine("Multiply by 2: " + output);

            output = output - 6;
            Console.WriteLine("Subtract 6: " + output);

            output = output / 2;
            Console.WriteLine("Divide by 2: " + output);

            output = output - input;
            Console.WriteLine("Subtract " + input + ": " + output);

            Console.ReadKey();

        }
    }
}
