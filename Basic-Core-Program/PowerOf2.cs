using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
    internal class PowerOf2
    {
        public void CalculationOfPower()
        {

            double m, n;
            Console.WriteLine("Enter the Number : ");
            m = double.Parse(Console.ReadLine());
            Console.WriteLine("Give the Exponent : ");
            n = double.Parse(Console.ReadLine());
            double value1 = Math.Pow(m, n);
            Console.WriteLine("Result : {0}", value1);
            Console.ReadLine();
        }
    }
}
