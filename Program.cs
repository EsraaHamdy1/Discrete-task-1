using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the starting number:");
            int n1 = int.Parse(Console.ReadLine());














            Console.WriteLine("Enter the Ending number:");
            int n2 = int.Parse(Console.ReadLine());

            for (int i = n1; i <= n2; i++) { int sum = 0; for (int j = 1; j < i; j++) { if (i % j == 0) { sum += j; } } if (sum == i) { Console.WriteLine(i); } }
        }
    }
}
