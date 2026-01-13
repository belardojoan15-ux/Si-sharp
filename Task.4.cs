namespace ConsoleApp1;
public class Task4
{
    static double Add(double a, double b) => a + b;
    static double Subtract(double a, double b) => a - b;
    static double Multiply(double a, double b) => a * b;
    static double Divide(double a, double b) => a / b;

     static void Main(string[] args)
    {
        while (true)
        {
            double num1, num2;
            double result = 0;

            Console.WriteLine("****************************");
            Console.WriteLine("*        Calculator        *");
            Console.WriteLine("****************************");

            Console.WriteLine("Select an operation:");
            Console.WriteLine("+ : Addition");
            Console.WriteLine("- : Subtraction");
            Console.WriteLine("* : Multiplication");
            Console.WriteLine("/ : Division");

            string operation = Console.ReadKey(true).KeyChar.ToString();

            Console.WriteLine("Enter first number:");
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input.");
                Console.ReadKey();
                continue;
            }
             Console.WriteLine("Enter second number:");
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.ReadKey();
                continue;
            }

            switch (operation)
            {
                case "+":
                case "1":
                operation = "+";
                    result = Add(num1, num2);
                    break;

                case "-":
                case "2":
                operation = "-";
                    result = Subtract(num1, num2);
                    break;
                case "*":
                case "3":
                operation = "*";
                    result = Multiply(num1, num2);
                    if (num1 == 0 || num2 == 0)
                    {
                        Console.WriteLine("Error: Multiplication by zero.");
                        Console.ReadKey();
                        continue;
                    }
                    break;
                case "/":
                case "4":
                operation = "/";
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        Console.ReadKey();
                        continue;
                    }

                    result = Divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    Console.ReadKey();
                    continue;
            }

                Console.WriteLine($"the result of {num1} {operation} {num2} = {result}");
                Console.WriteLine("Do you want to perform another calculation? (y/n):");
                string continueChoice = Console.ReadKey(true).KeyChar.ToString();
                if (continueChoice == "y" || continueChoice == "Y")
                {
                    continue;
                }
                
            else
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return;
            }
        }
    }
}