using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    public static class MathOperation
    {
        public static Func<double, double, double> Operation()
        {
            string[] operators = { "/", "*", "+", "-" };
            Func<double, double, double> selectedOperation = null;
            string inputValue;

            do
            {
                inputValue = Console.ReadLine();

                selectedOperation = inputValue switch
                {
                    "/" => (double x, double y) => x / y,
                    "*" => (double x, double y) => x * y,
                    "+" => (double x, double y) => x + y,
                    "-" => (double x, double y) => x - y,
                    _ => null
                };

                if (selectedOperation == null)
                {
                    Console.WriteLine("Incorrect input, please try again: ");
                }

            } while (selectedOperation == null);

            return selectedOperation;
        }
    }
}
