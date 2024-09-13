using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nNumber1;
            int nNumber2;
            int nSum;

            Console.Write("Enter first integer: ");
            nNumber1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer: ");
            nNumber2 = int.Parse(Console.ReadLine());

            nSum = nNumber1 + nNumber2;

            Console.WriteLine(String.Format("Sum is {0}", nSum));

            Console.ReadLine();
        }
    }
}
