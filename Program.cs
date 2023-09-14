using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int digit;

            while (number > 0)
            {
                digit = number % 10;
                sum += digit;
                number /= 10;
            }

            Console.WriteLine("The sum of the digits is: {0}", sum);
        }
    }
}
