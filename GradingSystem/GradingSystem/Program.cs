using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //If the exam mark is 90 or more then they get an “A *” grade
            //If the exam mark is 80 or more and less then 90 then they get an “A” grade
            //If the exam mark is 70 or more and less then 80 then they get an “B” grade
            //If the exam mark is 60 or more and less then 70 then they get an “C” grade
            //If the exam mark is 50 or more and less then 60 then they get an “D” grade
            //If the exam mark is 40 or more and less then 50 then they get an “E” grade
            //Less than 40 “Fail”

            int marks = 59;

            if (marks >= 90)
                Console.WriteLine("A*");
            else if (marks >= 80)
                Console.WriteLine("A");
            else if (marks >= 70)
                Console.WriteLine("B");
            else if (marks >= 60)
                Console.WriteLine("C");
            else if (marks >= 50)
                Console.WriteLine("D");
            else if ((marks > 40) && (marks < 50))
                Console.WriteLine("E");
            else
                Console.WriteLine("Fail");

            Console.ReadKey();
        }
    }
}
