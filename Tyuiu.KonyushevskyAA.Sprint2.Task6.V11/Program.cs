﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KonyushevskyAA.Sprint2.Task6.V11.Lib; 

namespace Tyuiu.KonyushevskyAA.Sprint2.Task6.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Конюшевский А.А  | ИИПБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Конюшевский Алексей Александрович   | ИИПб-23-2               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
            Console.WriteLine("* оператора switch  вычисляет требуемое значение и возвращает результат.  *");
            Console.WriteLine("* Условие: дата некоторого дня характеризуется тремя натуральными числами.*");
            Console.WriteLine("* По заданным g, m, n  определить дату следующего дня.                    *");
            Console.WriteLine("* Заданный год не является високосным.                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int g, m, n;

            Console.WriteLine("Введите значение Год : ");
            g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Месяц : ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение День : ");
            n = Convert.ToInt32(Console.ReadLine());

            string res = ds.FindDateOfNextDay(g, m, n);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (((m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12) && (n < 1 || n > 31)) || ((m == 4 || m == 6 || m == 9 || m == 11) && (n < 1 || n > 30)) || (m == 29 && (n < 1 || n > 29)) || (m < 1 || m > 12))
            {
                Console.WriteLine("Введено неверное значение");
            }
            else
            {
                Console.WriteLine(res);
            }


            Console.ReadKey();
        }
    }
}
