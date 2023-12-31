﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KonyushevskyAA.Sprint2.Task1.V19.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint2.Task1.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 696;
            int b = 354;
            int c = 423;
            int d = 957;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            Console.Title = "Спринт #2 | Выполнил: Конюшевский А.А  | ИИПБ-23-2";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #2                                                              *");
            Console.WriteLine("* Тема: Логические операции                                              *");
            Console.WriteLine("* Задание #1                                                             *");
            Console.WriteLine("* Вариант #19                                                            *");
            Console.WriteLine("* Выполнил: Конюшевский Алексей Александрович | ИИПБ-23-2                *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,        *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в        *");
            Console.WriteLine("* выражении) и логических операций (|, &, ||, &&, !, ^,последовательность*");
            Console.WriteLine("* операций не должна нарушаться), а также арифметических  выражений,     *");
            Console.WriteLine("* которая вернет логическую последовательность(массив): (True, False,    *");
            Console.WriteLine("* True, False, True, False), при a = 696, b = 354, c = 423, d = 957      *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();



        }
    }
}
