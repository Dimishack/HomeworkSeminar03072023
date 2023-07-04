using System;

namespace HomeworkSeminar03072023
{
    /*
     * Задача 29: Напишите программу, которая задаёт массив из 8 элементов в диапазоне от 10 до 1000 и выводит их на экран.
     * 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
     * 6, 1, 33 -> [6, 1, 33]
     */
    internal class Task29
    {
        internal static void Array8Elements()
        {
            Random random = new();

            Console.WriteLine("Массив из 8 элементов от 10 до 1000: ");
            Console.Write('[');
            for (int i = 0; i < 8; i++)
            {
                Console.Write(random.Next(10, 1001));
                if (i < 7) Console.Write(", ");
            }
            Console.Write(']');
        }
    }
}
