using System;
using System.Threading;

namespace BasicCalculator
{
    class MathFunctions
    {
        MenuOptions goBack = new MenuOptions();
        IsNum isNum = new IsNum();
        decimal numOne, numTwo, total;
        public void AddIt()
        {
            Console.WriteLine("Addition");
            Console.WriteLine("~~~~~~~~");
            Console.WriteLine("Enter a number:");
            numOne = isNum.Anum();
            Console.WriteLine("Enter a number:");
            numTwo = isNum.Anum();
            total = numOne + numTwo;
            Console.WriteLine($"The two numbers added is {total}");
            Console.Read();
            goBack.Menu();
        }
        public void SubIt()
        {
            Console.WriteLine("Subtraction");
            Console.WriteLine("~~~~~~~~");
            Console.WriteLine("Enter a number:");
            numOne = isNum.Anum();
            Console.WriteLine("Enter a number:");
            numTwo = isNum.Anum();
            total = numOne - numTwo;
            Console.WriteLine($"The two numbers subtracted is {total}");
            Console.Read();

            goBack.Menu();

        }
        public void MultIt()
        {
            Console.WriteLine("Multiplication");
            Console.WriteLine("~~~~~~~~");
            Console.WriteLine("Enter a number:");
            numOne = isNum.Anum();
            Console.WriteLine("Enter a number:");
            numTwo = isNum.Anum();
            total = numOne * numTwo;
            Console.WriteLine($"The two numbers miltiplied is {total}");
            Console.Read();

            goBack.Menu();

        }
        public void DivIt()
        {
            bool divZero = true;
            Console.WriteLine("Division");
            Console.WriteLine("~~~~~~~~");
            Console.WriteLine("Enter a number:");
            numOne = isNum.Anum();
            while (divZero)
            {
                Console.WriteLine("Enter a number:");
                numTwo = isNum.Anum();

                if (numTwo == 0)
                {
                    Console.WriteLine("Cannot divide by 0. choose a different number.");
                }
                else
                {
                    //DO NOTHING.
                    divZero = false;
                }
            }
            total = numOne / numTwo;
            Console.WriteLine($"The two numbers divided is {total}");
            Console.Read();

            goBack.Menu();

        }
        public void ModIt()
        {
            Console.WriteLine("Modulo");
            Console.WriteLine("~~~~~~~~");
            Console.WriteLine("Enter a number:");
            numOne = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number:");
            numTwo = decimal.Parse(Console.ReadLine());
            total = numOne % numTwo;
            Console.WriteLine($"The modulo (remainder) of the two numbers is {total}");
            Console.Read();

            goBack.Menu();

        }
        public void Exit()
        {
            Console.Clear();
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Thank you, have a nice day!"));
            Thread.Sleep(1000);
            Environment.Exit(0);
        }

    }
}
