using System;
using System.Text.RegularExpressions;

class Program
{
    static string ReplaceSumsWithResults(string input)
    {
        // Используем регулярное выражение для поиска всех сумм натуральных чисел
        string pattern = @"(\d+)\+(\d+)";
        Regex regex = new Regex(pattern);

        // Заменяем найденные суммы на их результаты
        string result = regex.Replace(input, match =>
        {
            int num1 = int.Parse(match.Groups[1].Value);
            int num2 = int.Parse(match.Groups[2].Value);
            int sum = num1 + num2;
            return sum.ToString();
        });

        return result;
    }

    static void Main()
    {
        Console.Title = " Практическая работа №11";
        Console.WriteLine("\tЗдравствуйте");
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();
        string result = ReplaceSumsWithResults(input);

        Console.WriteLine("Исходная строка: " + input);
        Console.WriteLine("Результат: " + result);
        Console.ReadKey();
    }
}