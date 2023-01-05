using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
    internal class SwapNumber
    {
        public static void swapNumber()
        {
            Console.WriteLine("enter the valu of a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of b");
            int b = Convert.ToInt32(Console.ReadLine());


            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("the number a is :" + a);
            Console.WriteLine("the number b is :" + b);
        }
    }
}
