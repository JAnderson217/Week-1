using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = 0;
            int secondNum = 0;
            Console.WriteLine("Enter first number: ");
            firstNum = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            secondNum = Convert.ToInt32(Console.ReadLine());
            if (firstNum > secondNum)
            {
                Console.WriteLine("First number is larger than second number");
            }
            else if (firstNum == secondNum)
            {
                Console.WriteLine("Numbers are equal");
            }
            else
            {
                Console.WriteLine("Second number is larger than first number");
            }
            Console.ReadLine();
        }
    }
}
