namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool isCalculating = true;
            while (isCalculating)
            {
                Console.Clear();
                Console.WriteLine("---Calculator---");
                Console.WriteLine("Choose one of the following:");
                Console.WriteLine("1 = Addision");
                Console.WriteLine("2 = Subtraction");
                Console.WriteLine("3 = Multiplication");
                Console.WriteLine("4 = Division");
                Console.WriteLine("5 = Exit");

                bool isWorking = int.TryParse(Console.ReadLine(), out int input);
                if (!isWorking)
                {
                    Console.WriteLine("Please enter valid input.");
                    Console.ReadLine();
                    continue;
                }
                if (input < 1 || input > 5)
                {
                    Console.WriteLine("Please choose a number between 1 and 5");
                    Console.ReadLine();
                    continue;
                }
                else
                {
                    switch (input)
                    {
                        case 1:
                            CalculateAddision();
                            break;

                        case 2:
                            CalculateSubtraction();
                            break;

                        case 3:
                            CalculateMultiplication();
                            break;

                        case 4:
                            CalculateDivision();
                            break;

                        case 5:
                            Console.WriteLine("Exiting...");
                            isCalculating = false;
                            break;
                    }
                }
            }
        }

        static int GetNumber(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                bool suksess = int.TryParse(Console.ReadLine(), out int number);
                if (suksess) return number;
                Console.WriteLine("Not a valid number, try again.");
            }
        }

        static void CalculateAddision()
        {
            Console.Clear();
            Console.WriteLine("---Addision---");
            int firstNumber = GetNumber("Enter your first number");
            int secondNumber = GetNumber("Enter your second number");

            int result = firstNumber + secondNumber;
            Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
            Console.ReadLine();

        }
        static void CalculateSubtraction()
        {
            Console.Clear();
            Console.WriteLine("---Subtraction---");
            int firstNumber = GetNumber("Enter your first number");
            int secondNumber = GetNumber("Enter your second number");


            int result = firstNumber - secondNumber;
            Console.WriteLine($"{firstNumber} - {secondNumber} = {result}");
            Console.ReadLine();
        }
        static void CalculateMultiplication()
        {
            Console.Clear();
            Console.WriteLine("---Multiplication---");
            int firstNumber = GetNumber("Enter your first number");
            int secondNumber = GetNumber("Enter your second number");

            int result = firstNumber * secondNumber;
            Console.WriteLine($"{firstNumber} * {secondNumber} = {result}");
            Console.ReadLine();

        }
        static void CalculateDivision()
        {
            Console.Clear();
            Console.WriteLine("---Division---");
            int firstNumber = GetNumber("Enter your first number");
            int secondNumber = GetNumber("Enter your second number");
            if (secondNumber == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                return;
            }
            int result = firstNumber / secondNumber;
            Console.WriteLine($"{firstNumber} / {secondNumber} = {result}");
            Console.ReadLine();

        }
    }
}
