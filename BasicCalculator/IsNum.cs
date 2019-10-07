using System;

namespace BasicCalculator
{
    class IsNum
    {
        decimal input;
        public decimal Anum()
        {
            bool checkIt = true;
            decimal returned;


            while (checkIt)
            {
                var incoming = Console.ReadLine();

                if (!decimal.TryParse(incoming, out returned))
                {
                    Console.WriteLine("That is not a number.");
                    Console.WriteLine("Enter a number.");
                }
                else if (decimal.TryParse(incoming, out returned))
                {
                    input = returned;
                    checkIt = false;
                }

            }
            return input;

        }
    }
}
