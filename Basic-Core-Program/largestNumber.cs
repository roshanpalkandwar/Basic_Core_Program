using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
    internal class largestNumber
    {
        public static void threeLagerNumber()
        {
            Console.WriteLine("enter three number a & b & c");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("greter number is a = " + a);

            }
            else if (b > a && b > c)
            {
                Console.WriteLine("the greater number is b = " + b);

            }
            else
            {
                Console.WriteLine("the greter number is c = " + c);
            }
        }
    }
}
