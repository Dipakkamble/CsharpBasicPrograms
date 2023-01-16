using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome csharp basic programs");

            Console.WriteLine("Pleaase enter the day number between 1 to 7");
            int day=Convert.ToInt32(Console.ReadLine());
            WeekDay.FindDayWhichFallOnWeek(day);

            Console.WriteLine("Please enter the first number");
            int first=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int second=Convert.ToInt32(Console.ReadLine());
            Calculator calculator1 = new Calculator(first,second);
            calculator1.Addition();
            calculator1.Subtraction();
            calculator1.Multiplication();
            calculator1.Division();
            Console.WriteLine("Please enter the first number");
            int third = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int fourth = Convert.ToInt32(Console.ReadLine());
            Calculator calculator2 = new Calculator(third, fourth);
            calculator2.Addition();
            calculator2.Subtraction();
            calculator2.Multiplication();
            calculator2.Division();

            Console.ReadLine();
        }
    }
}
