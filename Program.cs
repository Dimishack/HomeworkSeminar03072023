using System;

namespace HomeworkSeminar03072023
{
    internal class Program
    {
        static void Main()
        {
			try
			{
				Console.WriteLine("Задача №27");
				Task27.SumDigitsOfNumber();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
			finally
			{
				Console.WriteLine("\nНажмите на любую клавишу для выхода из программы...");
				Console.ReadKey(true);
			}
        }
    }
}