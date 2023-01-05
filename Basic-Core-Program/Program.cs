namespace Basic_Core_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Program");
            Console.WriteLine("Enter your choice ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1 For: Flip a Coin Head and Tail.\t 2.Select Value is Leap Year Or not \t 3.Select Power of 2 Number\t 4.harmonic series\t 5.the prime factor \t6.Quotient and Remainder\t7.swap number");
            int selection = Convert.ToInt32(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    //FLIP COIN
                    FlipCoinSimulation FlipCoin = new FlipCoinSimulation();
                    FlipCoin.CheckHeadTailPercentage();
                    break;
                case 2:
                    
                    LeapYear LeapYearOrNot = new LeapYear();
                    LeapYearOrNot.LeapYearr();
                    break;
                case 3:
                    PowerOf2 CalculatePower = new PowerOf2();
                    CalculatePower.CalculationOfPower();
                    break;
                case 4:
                    HarmonicPoblem.harmonic();
                    break;
                case 5:

                    PrimeFactorization p1 = new PrimeFactorization();
                    p1.PrimeFactors();
                    break;
                case 6:

                    QuotientAndRemainder.Calculate();
                    break;
                case 7:
                    SwapNumber.swapNumber();
                    break;
                default:
                    Console.WriteLine("Invalid Selection.");
                    break;
            }
            Console.ReadLine();
        }
    }
}