using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
    internal class NumberEvenOrOdd
    {
        public static void number()
        {
            int a, b;
            Console.WriteLine("enter the number");
            b = Convert.ToInt32(Console.ReadLine());

            if (b % 2 == 0)
            {



                Console.WriteLine(" number is a even");

            }
            else
            {
                Console.WriteLine("enter number is odd number");
            }

        }
    }
}
