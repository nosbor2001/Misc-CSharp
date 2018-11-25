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
            //how to covert characters to ASCII code
            char aChar;
            int aASCII;

            aChar = 'A';
            aASCII = (int)'#';

            Console.WriteLine("The ASCII code for " + aChar + " is " + aASCII);
            Console.ReadKey();

            //how to covert ASCII code to characters

            aASCII = 68;
            aChar = (char)90;

            Console.WriteLine("The character " + aASCII + " is " + aChar + " in ASCII code");
            Console.ReadKey();
        }
    }
}
