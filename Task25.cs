using System;

namespace HomeworkSeminar03072023
{
    /*
     * Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
     * 3, 5 -> 243 (3⁵)
     * 2, 4 -> 16
     */
    internal class Task25
    {
        internal static void Involution()
        {
            Console.Write("Введите число для возведения в степень: ");
            if (!Double.TryParse(Console.ReadLine(), out double number))
                throw new Exception("Данное значение введено некорректно!");
            Console.Write("Введите степень: ");
            if (!Double.TryParse(Console.ReadLine(), out double power))
                throw new Exception("Данное значение введено некорректно!");
            Console.WriteLine("Число {0} в степени {1} = {2}", number, power, Math.Pow(number, power));
        }
    }
}
