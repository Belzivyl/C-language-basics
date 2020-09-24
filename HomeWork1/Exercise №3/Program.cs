using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__3
{
    #region Сотонин Артем - Условие к заданию №3
    ////а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
    //Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
    //б) * Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
    #endregion
    class Program
    {
        static void Computation(double x1, double y1, double x2, double y2) 
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"Растояние между двумя точками равно: {r:f2}.");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте вас приветсвует программа по подсчету рассояния между двумя точками\nВведите координаты первой точки по оси X.");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты первой точки по оси Y.");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты второй точки по оси X.");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты второй точки по оси Y.");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"Растояние между двумя точками равно: {r:f2}.");

            Computation(x1, y1, x2, y2);

            Console.ReadKey();
        }
    }
}
