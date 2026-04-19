using System;
using System.Collections.Generic;

namespace Calculator
{
    internal class Program
    {
        private static readonly Dictionary<string, Func<double, double, double>> Operations =
            new(StringComparer.OrdinalIgnoreCase)
            {
                { "add", (a, b) => a + b },
                { "sub", (a, b) => a - b },
                { "mul", (a, b) => a * b },
                { "div", (a, b) => b != 0 ? a / b : throw new DivideByZeroException() },
                { "mod", (a, b) => b != 0 ? a % b : throw new DivideByZeroException() },
                { "pow", (a, b) => Math.Pow(a, b) }
            };

        static void Main(string[] args)
        {
            Console.Title = "Advanced Calculator";

            PrintWelcomeMessage();

            while (true)
            {
                try
                {
                    double num1 = ReadNumber("Enter first number: ");
                    double num2 = ReadNumber("Enter second number: ");

                    string operation = ReadOperation();

                    if (!Operations.ContainsKey(operation))
                    {
                        Console.WriteLine("❌ Unsupported operation.");
                        continue;
                    }

                    double result = Operations[operation](num1, num2);

                    Console.WriteLine($"✅ Result: {result}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("❌ Error: Division by zero is not allowed.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"❌ Unexpected error: {ex.Message}");
                }

                if (!AskToContinue())
                    break;
            }

            Console.WriteLine("👋 Thank you for using the calculator!");
        }

        private static void PrintWelcomeMessage()
        {
            Console.WriteLine("======================================");
            Console.WriteLine("     Advanced Console Calculator      ");
            Console.WriteLine("======================================");
            Console.WriteLine("Supported operations:");
            Console.WriteLine("add | sub | mul | div | mod | pow");
            Console.WriteLine();
        }

        private static double ReadNumber(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (double.TryParse(input, out double number))
                    return number;

                Console.WriteLine("⚠️ Invalid number. Please try again.");
            }
        }

        private static string ReadOperation()
        {
            Console.Write("Enter operation: ");
            return Console.ReadLine()?.Trim().ToLower();
        }

        private static bool AskToContinue()
        {
            Console.Write("Do you want to perform another calculation? (y/n): ");
            string input = Console.ReadLine();

            return input != null && input.Equals("y", StringComparison.OrdinalIgnoreCase);
        }
    }
}