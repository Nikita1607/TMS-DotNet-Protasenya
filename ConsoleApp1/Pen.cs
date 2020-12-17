using System;

namespace ConsoleApp1
{
    class Pen : Product
    {/// <summary>
     /// базовый конструктор
     /// </summary>
        public Pen()
        {
            Console.WriteLine("Я создался");
        }
        /// <summary>
        /// Конструктор с параметром цвет
        /// </summary>
        /// <param name="сolor">цвет</param>
        public Pen(int сolor)
        {
            Color = сolor;
            Console.WriteLine("Я создался с параметром цвет!!");

        }
    }
}
