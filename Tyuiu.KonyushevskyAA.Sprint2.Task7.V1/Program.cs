using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KonyushevskyAA.Sprint2.Task7.V1.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint2.Task7.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Конюшевский А.А  | ИИПБ-23-2";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #2                                                              *");
            Console.WriteLine("* Тема:  Операции сравнения                                              *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #1                                                             *");
            Console.WriteLine("* Выполнил: Конюшевский Алексей Александрович | ИИПБ-23-2                *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные                 *");
            Console.WriteLine("* данные (вещественные значения) и вычисляет, находится ли точка с       *");
            Console.WriteLine("* координатами X,Y в заштрихованной области.                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            if (ds.CheckDotInShadedArea(x, y)) Console.WriteLine("Данная точка находится в заштрихованной области");
            else Console.WriteLine("Данная точка не находится в заштрихованной области");

            Console.ReadKey();




        }
    }
}
