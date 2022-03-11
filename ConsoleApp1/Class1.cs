using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class1
    {
        public void HarmonicSeries()
        {

            Console.WriteLine("Enter The Harmonic Series");

            int Num;
            Console.WriteLine("Enter Number till you want to print Harmonic series: ");
            Num = Convert.ToInt32(Console.ReadLine());
            double sumofHarmonicSeries = 0.0;

            for (int i = 1; i <= Num; i++)
            {

                Console.Write("1/{0} +", i);
                sumofHarmonicSeries = sumofHarmonicSeries + 1 / (double)i;

            }

            Console.WriteLine();
            Console.WriteLine("\nSum of series upto {0} terms : {1}\n", +Num, +sumofHarmonicSeries);
            Console.ReadLine();
        }
        public  void PowerOfTwo()
        {
            int Num;
            Console.WriteLine("Enter number till which you want to print power of 2 = ");
            Num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= Num; i++)
            {
                double Power = Math.Pow(2, i);
                Console.WriteLine(Power);
            }
        }
    }
}
