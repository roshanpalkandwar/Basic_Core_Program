using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
    internal class PrimeFactorization
    {
        int Factor = 0;




        public void PrimeFactors()
        {
            Console.WriteLine("Please enter your integer: ");
            int Number = int.Parse(Console.ReadLine());

            for (Factor = 2; Number > (Number - 1); Factor++)
                if (Number % Factor == 0)
                {
                    int Times = 0;
                    while (Number % Factor == 0)
                    {
                        Number = Number / Factor;
                        Times++;
                    }
                    Console.WriteLine(Factor + " is a prime factor " + Times + " times! ");
                }



        }
    }
}
