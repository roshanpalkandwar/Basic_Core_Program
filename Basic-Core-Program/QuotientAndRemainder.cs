using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
    internal class QuotientAndRemainder
    {
        public static void Calculate()
        {
            Console.WriteLine("Please enter Number: ");
            int Number = int.Parse(Console.ReadLine());
            Console.WriteLine("Please By which you want to Divide: ");
            int By = int.Parse(Console.ReadLine());



            int Quotient = Number / By;
            int Remainder = Number % By;

            Console.WriteLine("Quotient " + Quotient);
            Console.WriteLine("Remainder " + Remainder);
        }
    }
}
