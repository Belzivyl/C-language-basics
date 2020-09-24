using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    #region Сотонин Артем - Условие к заданию №1
//    Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
//    а) используя склеивание;
//    б) используя форматированный вывод;
//	  в) используя вывод со знаком $.
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Зжравствуйте, вас приветствует программа \"Анкета\".\nПожалуйста заолните свою анкету отвечая на вопросы и выполняя зажания.\nКак вас зовут?");
            String firstName =Console.ReadLine();

            Console.WriteLine("Назовите свою фамилию.");
            String secondName = Console.ReadLine();

            Console.WriteLine("Сколько вам лет?");
            String age = Console.ReadLine();

            Console.WriteLine("Какой у вас рост в метрах?");
            String growth = Console.ReadLine();

            Console.WriteLine("Сколько вы весите в килограммах?");
            String weight = Console.ReadLine();

            Console.WriteLine("Ваше имя и фамилия: " + firstName + " " + secondName + ". Вам " + age + " лет. Ваш рост: " + growth + " метра. Ваш вес: " + weight + " килограмм.");

            Console.WriteLine("Ваше имя и фамилия: {0} {1}. Вам {2} лет. Ваш рост: {3} метра. Ваш вес: {4} килограмм.", firstName, secondName, age, growth, weight);

            Console.WriteLine($"Ваше имя и фамилия: {firstName} {secondName}. Вам {age} лет. Ваш рост: {growth} метра. Ваш вес: {weight} килограмм.");

            Console.ReadKey();
        }
    }
}
