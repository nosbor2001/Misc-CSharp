using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopsC1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display 1* table
            for (int x = 0; x <= 12; x++)
            {
                Console.WriteLine(x + "*" + "1=" + x);
            }
            Console.ReadKey();
        }
    }
}
