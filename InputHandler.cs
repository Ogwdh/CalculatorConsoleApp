using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    public static class InputHandler
    {
        public static double RequestInput()
        {
            bool validInput = false;
            double inputValue = 0;

            do
            {
                if (double.TryParse(Console.ReadLine(), out double result))
                {
                    validInput = true;
                    inputValue = result;
                }
                else
                    Console.WriteLine("incorrect input, please try again:");
            }
            while (!validInput);

            return inputValue;
        }
    }
}
