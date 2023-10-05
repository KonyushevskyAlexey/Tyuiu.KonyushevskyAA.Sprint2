using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KonyushevskyAA.Sprint2.Task3.V3.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint2.Task3.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Конюшевский А.А  | ИИПБ-23-2";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #2                                                              *");
            Console.WriteLine("* Тема:  Базовые навыки работы в C#                                      *");
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #3                                                             *");
            Console.WriteLine("* Выполнил: Конюшевский Алексей Александрович | ИИПБ-23-2                *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с   *");
            Console.WriteLine("* использованием вложенных оператор if-else, где пользователь вводит     *");
            Console.WriteLine("* значение переменной X с клавиатуры.                                    *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Введите значение переменной X: ");
            double x = Convert.ToInt32(Console.ReadLine());
            double res = ds.Calculate(x);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Значение функции = " + res);

            Console.ReadKey();




        }
    }
}
