using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__4
{
    #region Сотонин Артем - Условие к заданию №4
    //Написать программу обмена значениями двух переменных:
    //а) с использованием третьей переменной;
    //б) * без использования третьей переменной.
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            int c = a;

            Console.WriteLine($"Значение a = {a = b}.Значение b = {b = c}.");

            a = 2;
            b = 3;

            b = a + b;
            a = b - a;
            b = b - a;

            Console.WriteLine($"Значение a = {a}.Значение b = {b}.");
            
            Console.ReadKey();
        }
    }
}
