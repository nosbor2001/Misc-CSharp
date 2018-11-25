using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {

        static void Main(string[] args)
        {
            //Setup
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();


            centerString("ATM");
            centerString("WELOCME TO THE BANK OF QE");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            centerString("[*] Cash with Receipt     On Screen Balance [*]");
            centerString("[*] Cash without Receipt      Print Balance [*]");
            centerString("[*] Change Pin               Mini Statement [*]");
            Console.WriteLine("");
            centerString("[1] [2] [3] [Clear ]");
            centerString("[4] [5] [6] [Cancel]");
            centerString("[7] [8] [9] [Enter ]");
            centerString("[ ] [0] [ ] [      ]");

            Console.Read();
            
        }

        static void centerString(string message)
        {
            int screenWidth = Console.WindowWidth;
            int stringWidth = message.Length;
            int spaces = (screenWidth / 2) + (stringWidth / 2);

            Console.WriteLine(message.PadLeft(spaces));
        }
    }
}
