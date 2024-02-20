using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Program_HanzS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Calculator Program");
            Console.WriteLine("All credits go to Bro Code!");

            // Using a do while loop for repeating the calculator
            do
            {


                // Declare variables of first, second number and result
                double num1 = 0;
                double num2 = 0;
                double result = 0;    

                // Inputting numbers
                Console.Write("Enter your first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter your second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                // Writing the Options
                Console.WriteLine("Enter an option: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.Write("Enter an option: ");

                // Using a switch to determine the Option given from the Input
                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                Console.Write("Would you like to continue? (Yes = Y, No = N): ");

            } 
            while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Thanks for using the calculator!!");
            Console.ReadKey();
        }
    }
}
