using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("What is your speed?: ");
            int speed = int.Parse(Console.ReadLine());

            if (speed > 70)
            {
                Console.WriteLine("Warning you are speeding!");
            }
            else
            {
                Console.WriteLine("Your speed is fine");
            }
            Console.Read();

        }
    }
}
