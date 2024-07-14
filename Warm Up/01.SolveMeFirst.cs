using System;
using System.Collections.Generic;
using System.Text;

namespace Warm_Up
{
    public class SolveMeFirst
    {
        private NumberValidation numberValidation;
        public SolveMeFirst()
        {
            numberValidation = new NumberValidation();

            int value1, value2;
            string input;

            Console.WriteLine("01. Warm Up");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("01. Solve Me First");
            Console.WriteLine("-------------------------------------");

            do
            {
                Console.Write("Input Value 1 : ");
                input = Console.ReadLine();
                if (!numberValidation.IsValidNumber(input, out value1))
                {
                    Console.WriteLine(numberValidation.WarningMessage);
                }
            } while (!numberValidation.IsValidNumber(input, out value1));

            do
            {
                Console.Write("Input Value 2 : ");
                input = Console.ReadLine();
                if (!numberValidation.IsValidNumber(input, out value2))
                {
                    Console.WriteLine(numberValidation.WarningMessage);
                }
            } while (!numberValidation.IsValidNumber(input, out value2));

            int result = value1 + value2;
            Console.WriteLine("Result\t\t: "+result);
        }
    }
}
