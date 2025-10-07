namespace CalculatorConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CalculateLoop();
        }

        public static void CalculateLoop()
        {
            bool exit = false;
            string userInput = string.Empty;

            do
            {
                Calculate();
                Console.Write("type N to exit: ");
                userInput = Console.ReadLine()?.Trim().ToLower() ?? "";

                if (userInput == "n")
                    exit = true;
            }
            while (!exit);
        }

        public static void Calculate()
        {
            try
            {
                Console.Write("Enter the first number: ");
                double first_num = InputHandler.RequestInput();
                Console.Write("Enter the operation: ");
                Func<double, double, double> op = MathOperation.Operation();
                Console.Write("Enter the second number: ");
                double second_num = InputHandler.RequestInput();

                if (second_num == 0)
                {
                    throw new DivideByZeroException();
                }
                else
                {
                    Console.WriteLine(op(first_num, second_num));
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
        }
    }
}