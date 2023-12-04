using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibCalculator;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first numbers: ");
            double number1 = double.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            double number2 = double.Parse(Console.ReadLine());

            Calculator calc = new Calculator();

            Console.WriteLine($"The result of addition is {calc.Add(number1, number2)}.");
            Console.WriteLine($"The result of substraction is {calc.Subtract(number1, number2)}.");

            Console.ReadLine();
        }
        
    }
}
