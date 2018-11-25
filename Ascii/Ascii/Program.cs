using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("ASCII (1) or Character (2): ");
                int output = int.Parse(Console.ReadLine());

                if (output == 1)
                {
                    Console.Write("Enter an ASCII code: ");
                    int ASCII = int.Parse(Console.ReadLine());

                    Console.WriteLine((char)+ASCII);
                    Console.ReadKey();
                }

                if (output == 2)
                {
                    Console.Write("Enter a character: ");
                    char Char = char.Parse(Console.ReadLine());

                    Console.WriteLine((int)+Char);
                    Console.ReadKey();
                }

            }
        }
    }
}