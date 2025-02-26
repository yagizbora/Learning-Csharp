﻿using System;
using Raise_Calculation_Models;
using static Raise_Calculation_Models.NumberModels;

namespace Raise_Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool proccessprogram = true;
            while (proccessprogram) 
            {
                try
                {
                    var calculator = new Numbers();

                    Console.WriteLine("That's Raise Calculation Program");
                    Console.WriteLine("------------------------");

                    Console.WriteLine("Please write employee salary:");
                    string num1 = Console.ReadLine();
                    if (string.IsNullOrEmpty(num1))
                    {
                        Console.WriteLine("Salary cannot be empty.");
                        Console.WriteLine("Program will be restart....");
                        Thread.Sleep(1000);
                    }

                    if (!float.TryParse(num1, out float salary))
                    {
                        Console.WriteLine("Please enter a valid numeric value for the salary.");
                        Console.WriteLine("Program will be restart....");
                        Thread.Sleep(1000);
                    }

                    calculator.FirstNumber = salary;

                    Console.WriteLine("Enter raise percentage (e.g., 10 for 10%):");
                    string num2 = Console.ReadLine();
                    if (string.IsNullOrEmpty(num2))
                    {
                        Console.WriteLine("Raise percentage cannot be empty.");
                        Console.WriteLine("Program will be restart....");
                        Thread.Sleep(1000);
                    }

                    if (!int.TryParse(num2, out int raisePercentage))
                    {
                        Console.WriteLine("Please enter a valid numeric value for the raise percentage.");
                    }

                    calculator.SecondNumber = raisePercentage;

                    float raiseAmount = salary * (raisePercentage / 100.0f);
                    float newSalary = salary + raiseAmount;

                    Console.WriteLine($"The original salary is: {salary}");
                    Console.WriteLine($"The raise amount is: {raiseAmount}");
                    Console.WriteLine($"The new salary after {raisePercentage}% raise is: {newSalary}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception Error: {ex.Message}");
                }
                Console.WriteLine("Do you want to continue? (yes/no)");
                string? continueprogram = Console.ReadLine()?.ToLower();

                if (continueprogram == "yes")
                {
                    Console.WriteLine("Program will be restart....");
                    Thread.Sleep(1000);
                    proccessprogram = true;
                }
                else if (continueprogram == "no")
                {
                    Console.WriteLine("Program will be stop....");
                    Thread.Sleep(1000);
                    proccessprogram = false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Assuming 'no'.");
                    Console.WriteLine("Program will be stop....");
                    Thread.Sleep(1000);
                    proccessprogram = false;
                }
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
