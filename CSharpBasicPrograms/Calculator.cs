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

    }
}
