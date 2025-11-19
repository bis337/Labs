using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3_6._19_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 6.19");
            Console.WriteLine("Введите первое число");
            long num1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            long num2 = Convert.ToInt64(Console.ReadLine());
            long i = 1;
            long largeComDiv = 0;
            while (i < Math.Max(num1, num2))
            {


                if (num1 % i == 0 && num2 % i == 0)
                {
                    largeComDiv = i;
                }
                //Console.WriteLine(i);
                i++;
            }
            Console.WriteLine($"Наибольший общий делитель: {largeComDiv}");
            Console.Read();
        }
    }
}
