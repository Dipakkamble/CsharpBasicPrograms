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
            Console.ReadLine();
        }
    }
}
