using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumofdigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 num, sum = 0, r;

            Console.WriteLine("Enter a Number : ");

            num = Int64.Parse(Console.ReadLine());

            while (num != 0)

            {
                r = num % 10;
                num = num / 10;
                sum = sum + r;
            }

            Console.WriteLine("Sum of Digits of the Number : " + sum);
            Console.ReadLine();
        }
    }
}
