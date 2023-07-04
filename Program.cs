using System;

namespace HomeworkSeminar03072023
{
    internal class Program
    {
        static void Main()
        {
			try
			{

			}
			catch (Exception)
			{

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