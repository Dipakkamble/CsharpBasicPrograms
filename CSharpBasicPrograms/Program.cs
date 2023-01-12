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
            Console.WriteLine("Please enter the first number");
            int first=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int second=Convert.ToInt32(Console.ReadLine());
            Calculator calculator = new Calculator(first,second);
            calculator.Addition();
            Console.ReadLine();
        }
    }
}
