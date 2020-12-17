using System;

namespace ConsoleApp1
{/// <summary>
/// базовый класс для карандаша или ручки
/// </summary>
    abstract class Product
    {
        /// <summary>
        /// цвет стержня
        /// </summary>
        public int Color { get; set; }
        /// <summary>
        /// цена
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// страна производства
        /// </summary>
        public string Country { get; set; }

        public void draw()

        {
            Console.WriteLine("Рисую.");
        }
            public virtual void Do()
        {
            Console.WriteLine("Do something.");
        }

    }





    }


