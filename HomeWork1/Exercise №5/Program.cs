using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exercise__5
{
    #region Сотонин Артем - Условие к заданию №5
    //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
    //б) * Сделать задание, только вывод организовать в центре экрана.
    //в) ** Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).
    #endregion
    class Program
    {
        static void Print(string ms, int x, int y) 
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);
        }

        static void Main(string[] args)
        {
            string firstName = "Артем";
            string secondName = "Сотонин";
            string city = "г.Екатеринбург";

            Console.WriteLine($"{firstName} {secondName} {city}.");

            Print($"{firstName} {secondName} {city}.", 50, 50);

            Console.ReadKey();
        }
    }
}
