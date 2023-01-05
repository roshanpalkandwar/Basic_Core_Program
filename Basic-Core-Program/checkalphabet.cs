using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
    internal class checkalphabet
    {
        public static void VowelOrConsonant()
        {
            Console.WriteLine("enter alphabet");
            char obj = Convert.ToChar(Console.ReadLine());

            if (obj == 'a' || obj == 'A' || obj == 'e' || obj == 'E' || obj == 'i' || obj == 'I' || obj == 'o' || obj == 'O' || obj == 'u' || obj == 'U')
            {
                Console.WriteLine("it is vowel");
            }
            else
            {
                Console.WriteLine("it is consonant");
            }
        }
    }
}
