using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KonyushevskyAA.Sprint2.Task4.V30.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint2.Task4.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Конюшевский А.А  | ИИПБ-23-2";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #2                                                              *");
            Console.WriteLine("* Тема:  Тернарный оператор                                              *");
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #30                                                            *");
            Console.WriteLine("* Выполнил: Конюшевский Алексей Александрович | ИИПБ-23-2                *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("*Написать программу,которая вычисляет требуемое значение с использованием*");
            Console.WriteLine("* тернарного оператора, где пользователь вводит значение переменных x, y *");
            Console.WriteLine("* c клавиатуры                                                           *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            double x;
            double y;

            Console.WriteLine("Введите значение переменной  X: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение переменной  Y: ");
            y = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x, y);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
