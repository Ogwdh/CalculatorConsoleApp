namespace CalculatorConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                double first_num = InputHandler.RequestInput();
                Func<double, double, double> op = MathOperation.Operation();
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