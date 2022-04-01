using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sum of squares
            double sum = 0;
            double count = 0;
            do
            {
                sum = sum + Math.Pow(count, 2.0);
                Console.WriteLine("count: {0}   sum: {1}", count, sum); 
                count++;
            } while (count != 10);

            Console.WriteLine();
            //sum of squares with while loop
            sum = 0;
            count = 0;
            while (count != 10)
            {
                sum = sum + Math.Pow(count, 2.0);
                Console.WriteLine("count: {0}   sum: {1}", count, sum);
                count++;
            }
            
            Console.WriteLine();
            //print odd numbers 1-100
            for (int i=1; i < 100; i=i+2)
            {
                Console.Write("{0} ", i);
            }

            Console.ReadLine();
        }
    }
}
