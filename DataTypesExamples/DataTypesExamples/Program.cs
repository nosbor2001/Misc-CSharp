using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declares the two integers
            int Total;
            int Answer;
            //Assigns Total to 12
            Total = 12;

            //Prints the output of each operation done on the variable Total
            Answer = 3 * Total;
            Console.WriteLine("The Answer to 3 * Total = " + Answer);

            Answer = Total - 7 * Total;
            Console.WriteLine("The Answer to Total – 7 * Total = " + Answer);

            Answer = (Total - 7) * Total;
            Console.WriteLine("The Answer to (Total – 7) * Total = " + Answer);

            Answer = Total * -5;
            Console.WriteLine("The Answer to Total * -5 = " + Answer);

            Console.ReadKey();

        }
    }
}
