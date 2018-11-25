using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedBranching
{
    class Program
    {
        static void Main(string[] args)
        {
            bool winTheLottery = false;
            bool leftMoneyInAWill = true;
            bool youHaveLotsOfDepandants = true;

            if ((winTheLottery || leftMoneyInAWill) && !youHaveLotsOfDepandants)
                Console.WriteLine("You have more money for yourself");
            else
                Console.WriteLine("You may not have more money for yourself");

            Console.ReadKey();

            winTheLottery = false;
            leftMoneyInAWill = true;
            youHaveLotsOfDepandants = true;

            if ((winTheLottery || leftMoneyInAWill) && !youHaveLotsOfDepandants)
                Console.WriteLine("You have more money for yourself");
            else
                Console.WriteLine("You may not have more money for yourself");

            Console.ReadKey();
        }
    }
}