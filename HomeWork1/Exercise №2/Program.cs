using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__2
{
    #region Сотонин Артем - Условие к заданию №2
    //Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах.
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, вас приветствует программа по рассчету индекса массы тела - \"ИМТ\".\nВведите ваш вес в килограммах.");
            double m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите ваш рост в метрах.");
            double h = Convert.ToDouble(Console.ReadLine());

            double l = m / (h * h);

            Console.WriteLine($"Индекс массы вашего тела равен: {l:f2}.");

            Console.ReadKey();
        }
    }
}
