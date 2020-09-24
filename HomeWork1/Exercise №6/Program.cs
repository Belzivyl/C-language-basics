using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__6
{
    #region Сотонин Артем - Условие к заданию №6
    //*Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
    #endregion
    class Program
    {
        static void Print(string text, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(text);
        }

        static void Pause()
        {
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
        }
    }
}
