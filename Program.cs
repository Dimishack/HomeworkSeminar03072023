using System;

namespace HomeworkSeminar03072023
{
    internal class Program
    {
        static void Main()
        {
			try
			{
				Console.WriteLine("Задача №29");
				Task29.Array8Elements();
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