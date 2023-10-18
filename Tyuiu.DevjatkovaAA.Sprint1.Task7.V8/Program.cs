using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DevjatkovaAA.Sprint1.Task7.V8.Lib;

//Написать программу, которая вычисляет математическое выражение 
//по исходным данным, вводимых пользователем.
//
//                      y
// z = x * ln x + -------------
//                          x
//                 cos x - ---
//                          3

namespace Tyuiu.DevjatkovaAA.Sprint1.Task7.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Девяткова А. А. | АСОиУБ-23-3";
            //Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Добаление к решению итоговых проектов по спринту                  *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнила: Девяткова Анастасия Александровна | АСОиУБ-23-3              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
            Console.WriteLine("* по исходным данным, вводимых пользователем.                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("                      y           ");
            Console.WriteLine(" z = x * ln x + ------------- =   ");
            Console.WriteLine("                          x       ");
            Console.WriteLine("                 cos x - ---      ");
            Console.WriteLine("                          3       ");

            Console.WriteLine("Введите значение x = ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y = ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("{0:0.000}",ds.Calculate(x, y));
            Console.ReadKey(); 
        }
    }
}
