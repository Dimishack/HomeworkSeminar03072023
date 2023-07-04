using System;

namespace HomeworkSeminar03072023
{
    /*
     * Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
     * 452 -> 11
     * 82 -> 10
     * 9012 -> 12
     */
    internal class Task27
    {
        internal static void SumDigitsOfNumber()
        {
            byte digit = 0;
            Console.Write("Введите целое положительное число: ");
            string? number = Console.ReadLine();
            if (!UInt64.TryParse(number, out var _))
                throw new Exception("Данное значение введено некорректно!");
            for (int i = 0; i < number.Length; i++)
                digit += Convert.ToByte(number[i] - '0');
            Console.WriteLine("Сумма цифр числа {0} = {1}", number, digit);
        }
    }
}
