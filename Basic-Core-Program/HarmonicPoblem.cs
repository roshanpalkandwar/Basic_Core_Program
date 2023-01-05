using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
    internal class HarmonicPoblem
    {
        public static void harmonic()
        {
            Console.WriteLine("enter the number for lentgh of series");
            double num = Convert.ToInt32(Convert.ToDouble(Console.ReadLine()));
            double i = 1;
            double rst = 0.0;
            num = num;
            while (i <= num)
            {
                Console.WriteLine("1/" + i + "+");
                rst = rst + (double)1 / i;
                i++;
            }
            Console.WriteLine("the sum of harmonic series is  " + rst);
        }
    }
}
