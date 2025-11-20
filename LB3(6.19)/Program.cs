using System;
using System.IO;

namespace LB3_6._19_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Чтение из файла
            string inputPath = "input.txt";
            if (!File.Exists(inputPath))
            {
                Console.WriteLine("Файл input.txt не найден. Запустите программу и введите числа.");
                Console.Read();
                return;
            }

            string[] lines = File.ReadAllLines(inputPath);
            long num1 = Convert.ToInt64(lines[0]);
            long num2 = Convert.ToInt64(lines[1]);

            // Улучшенный алгоритм НОД
            long largeComDiv = 0;
            long i = Math.Min(Math.Abs(num1), Math.Abs(num2));
            while (i >= 1)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    largeComDiv = i;
                    break; // первый найденный делитель - наибольший
                }
                i--;
            }

            Console.WriteLine($"Наибольший общий делитель: {largeComDiv}");
            Console.Read();
        }
    }
}