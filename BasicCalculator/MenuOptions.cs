using System;

namespace BasicCalculator
{
    class MenuOptions
    {
        public void Menu()
        {
            Console.Clear();
            MathFunctions mathFunctions = new MathFunctions();
            bool exitIt = false;
            int goodMath = 0;
            Console.WriteLine("                 Let's do some simple math, please choose an option.");
            Console.WriteLine("\n                       1) Addition            4) Division");
            Console.WriteLine("\n                       2) Subtraction         5) Modulo (remainder)");
            Console.WriteLine("\n                       3) Multiplication      6) Exit");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            while (!exitIt)
            {
                string mathType = Console.ReadLine();

                if (!int.TryParse(mathType, out goodMath))
                {
                    Console.WriteLine("That was not an option");
                }
                else if (goodMath > 6 || goodMath < 1)
                {
                    Console.WriteLine("That was not an option");
                }

                switch (goodMath)
                {
                    case 1:
                        mathFunctions.AddIt();
                        break;
                    case 2:
                        mathFunctions.SubIt();
                        break;
                    case 3:
                        mathFunctions.MultIt();
                        break;
                    case 4:
                        mathFunctions.DivIt();
                        break;
                    case 5:
                        mathFunctions.ModIt();
                        break;
                    case 6:
                        mathFunctions.Exit();
                        break;
                }
            }
        }
    }
}
