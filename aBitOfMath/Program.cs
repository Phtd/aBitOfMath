using System;
using System.Collections.Generic;
using System.Windows;

namespace aBitOfMath
{
    class Program
    {
        // static double num1;
        // static double num2;
        static double totalAddNumber;
        static double totalDivideNumber;
        static double totalPowerNumber;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, here we will add 2 numbers, divide them and use the power function. Each seperately");
            Console.WriteLine("Please write the 1st number");
            double num1 = double.Parse(Console.ReadLine()); // collects the first number from the user input

            Console.WriteLine("Please write the 2nd number");
            double num2 = double.Parse(Console.ReadLine()); // collects the 2nd number from the user input

            totalAddNumber = num1 + num2; // gives totalAddNumber its value
            totalDivideNumber = num1 / num2; // gives totalDivideNumber its value 
            totalPowerNumber = Math.Pow(num1, num2); // gives totalPowerNumber its value
            Console.WriteLine(totalAddNumber); // tells the program to display the result
            Console.WriteLine(totalDivideNumber); // same as the one above
            Console.WriteLine(totalPowerNumber);  // same as the one above
            Console.ReadKey(); // makes it so the program wont shut down the moment its done
        }
    }
}
