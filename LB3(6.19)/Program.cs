using System;
using System.IO;

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

            // Запись в файл
            string inputPath = "input.txt";
            using (StreamWriter writer = new StreamWriter(inputPath))
            {
                writer.WriteLine(num1);
                writer.WriteLine(num2);
            }

            long i = 1;
            long largeComDiv = 0;
            while (i <= Math.Min(Math.Abs(num1), Math.Abs(num2)))
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    largeComDiv = i;
                }
                i++;
            }
            Console.WriteLine($"Наибольший общий делитель: {largeComDiv}");
            Console.Read();
        }
    }
}