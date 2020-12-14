using System;

namespace HW3_datereaderMetod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите дату: ");
            string userInput = Console.ReadLine();
            bool result = DateTime.TryParse(userInput, out DateTime date);
            if (result)
            {
                Console.WriteLine(date.DayOfWeek);
            }
            else
            {
                Console.WriteLine("Некорректный ввод.");
            }

            Console.ReadLine();
        }
    }
}
