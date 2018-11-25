using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int ascii = 32;
            //int y = 32; y < 127; y++
            while (ascii != 128)
            {
                for (int y = 0; y < 5; y++)
                {
                    Console.Write("(int) " + y + ": ");
                    Console.Write("(char) ");
                    Console.Write((char)+y);
                    Console.WriteLine();
                    for (int x = 0; x < 5; x++)
                    {

                    }
                }
            }

            
            Console.ReadLine();
        }
    }
}
