using System;
using System.IO;
using System.Text.Json;

namespace LB3_6._19_
{
    // Класс для хранения результата
    public class GCDResult
    {
        public long Number1 { get; set; }
        public long Number2 { get; set; }
        public long GCD { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)//ddsdssss
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
                    break;
                }
                i--;
            }

            Console.WriteLine($"Наибольший общий делитель: {largeComDiv}");

            // Сохранение результата в JSON
            var result = new GCDResult { Number1 = num1, Number2 = num2, GCD = largeComDiv };
            string json = JsonSerializer.Serialize(result, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("result.json", json);

            Console.Read();
        }
    }
}