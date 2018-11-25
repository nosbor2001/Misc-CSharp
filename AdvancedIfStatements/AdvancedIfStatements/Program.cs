using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedIfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool heat = false;
            bool oxygen = true;
            bool fuel = true;

            if (heat && fuel && oxygen)
                Console.WriteLine("Danger of a fire!");
            else
                Console.WriteLine("No danger of a fire");

            Console.ReadKey();
        }
    }
}
