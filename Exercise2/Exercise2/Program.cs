using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Forename, Surname, Age, hours worked in a week, hours worked on a weekend and hours worked after 18:00 hrs on a weekday
            //The basic pay = £6.50 per hour
            //Time and a half for evening hours worked (1.5)
            //Double time for weekends hours worked (2.0)

            Console.WriteLine("Employee data");

            Console.Write("Enter Forname: ");
            string forname = Console.ReadLine();

            Console.Write("Enter Surname: ");
            string surname = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Hours worked this week: ");
            double hoursWeek = double.Parse(Console.ReadLine());

            Console.Write("Enter Hours worked this weekend: ");
            double hoursEnd = double.Parse(Console.ReadLine());

            Console.Write("Enter Hours worked after 18:00 on a weekday: ");
            double hoursAfter = double.Parse(Console.ReadLine());

            double money = ((hoursWeek) + (hoursEnd * 2) + (hoursAfter * 1.5)) * 6.5;
            Console.Write("Money Earned: " + money);

            Console.ReadKey();

        }
    }
}
