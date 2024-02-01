using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleСalculator
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть перше число:");
            if (double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Введіть друге число:");
                if (double.TryParse(Console.ReadLine(), out double num2))
                {
                    double sum = num1 + num2;
                    Console.WriteLine($"Сума {num1} і {num2} дорівнює: {sum}");
                }
                else
                {
                    Console.WriteLine("Невірний ввід для другого числа. Будь ласка, введіть числове значення.");
                }
            }
            else
            {
                Console.WriteLine("Невірний ввід для першого числа. Будь ласка, введіть числове значення.");
            }
            Console.ReadKey();
        }
    }
}