using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicPrograms
{
    /// <summary>
    /// Calculator class is created to perform arithmetic operation
    /// </summary>
    internal class Calculator
    {
        // instance variable
        public int first,second,sum;
        //public int second;
        //public int sum;
        public Calculator(int firstNumb,int secondNumb)
        {
            first = firstNumb;
            second = secondNumb;
        }
        // Addition of two number to get sum
        public void Addition()
        {
            sum = first + second;
            Console.WriteLine("sum=" +sum);
        }
        public void Subtraction()
        {
            sum = Math.Abs(first - second); // it will not print negative value because math.abs
            Console.WriteLine("diff=" +sum);

        }
        public void Multiplication()
        {
            sum = first * second;
            Console.WriteLine("multi=" +sum);

        }
        public void Division()
        {
            sum = first/second; 
            Console.WriteLine("divi=" +sum);

        }
    }
}
