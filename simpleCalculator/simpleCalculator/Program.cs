using System;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("++ Simple Calculator Program ++");
                Console.WriteLine("Options:\t+, -, *, /, and %");

                Console.Write("Enter your first number, please: ");

                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter your second number, please: ");

                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter and oparotor, please: ");


                switch (Console.ReadLine())
                {
                    case "+":
                        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                        break;

                    case "-":
                        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                        break;

                    case "*":
                        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                        break;

                    case "/":
                        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                        break;

                    case "%":
                        Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                        break;

                    default:
                        Console.WriteLine("Invalide Oparation");
                        break;
                }
                Console.Write("Enter Y(yes) to continue N(no) to exit: ");

            } while (Console.ReadLine()?.ToUpper() == "Y");


        }
    }
}
