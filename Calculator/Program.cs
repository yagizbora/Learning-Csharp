namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool proccessprogram = true;

            while (proccessprogram) 
            {
                var calculator = new Calculator();

                try
                {
                    Console.WriteLine("Console Calculator");
                    Console.WriteLine("------------------------\n");

                    Console.WriteLine("Please give me a first number:");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    calculator.FirstNumber = num1;

                    Console.WriteLine("Please give me a second number:");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    calculator.SecondNumber = num2;

                    Console.WriteLine("Choose an option from the following list:");
                    Console.WriteLine("+ Add");
                    Console.WriteLine("- Subtract");
                    Console.WriteLine("* Multiply");
                    Console.WriteLine("/ Divide");
                    Console.WriteLine("% Percent");
                    Console.Write("Your option? ");

                    var operation = Console.ReadLine();
                    if (operation == "+")
                        calculator.Result = calculator.FirstNumber + calculator.SecondNumber;
                    else if (operation == "-")
                        calculator.Result = calculator.FirstNumber - calculator.SecondNumber;
                    else if (operation == "*")
                        calculator.Result = calculator.FirstNumber * calculator.SecondNumber;
                    else if(operation == "%")
                    {
                        calculator.Result = (calculator.FirstNumber * calculator.SecondNumber) / 100.0f;
                    }
                    else if (operation == "/")
                    {
                        if (calculator.SecondNumber == 0)
                            throw new DivideByZeroException();
                        calculator.Result = calculator.FirstNumber / calculator.SecondNumber;
                    }
                    else
                    {
                        Console.WriteLine("Invalid operation.");
                        continue; 
                    }

                    Console.WriteLine($"Result: {calculator.Result}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("You cannot divide by zero!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                }

                Console.WriteLine("Do you want to continue? (yes/no)");
                string? continueprogram = Console.ReadLine()?.ToLower();

                if (continueprogram == "yes")
                {
                    proccessprogram = true; 
                }
                else if (continueprogram == "no")
                {
                    proccessprogram = false; 
                }
                else
                {
                    Console.WriteLine("Invalid input. Assuming 'no'.");
                    proccessprogram = false; 
                }
            }

            // Program tamamen sona erdi
            Console.WriteLine("Goodbye!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            Environment.Exit(0); 
        }
    }

    internal class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public float Result { get; set; }
    }
}
