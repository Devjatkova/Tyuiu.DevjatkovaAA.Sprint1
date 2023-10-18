using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DevjatkovaAA.Sprint1.Task3.V2.Lib;

//Задание
//Написать программу, которая запрашивает у пользователя исходные данные,
//выполняет указанные расчёты и печатает результат на экране.
//Расчёты: Объявите необходимые переменные и напишите программу вычисления стоимости покупки,
//состоящей из нескольких тетрадей и карандашей.
//Предполагается, что пользователь будет вводить данные о каждой составляющей
//покупки в отдельной строке: сначала цену, затем количество.

namespace Tyuiu.DevjatkovaAA.Sprint1.Task3.V2
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
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнила: Девяткова Анастасия Александровна | АСОиУБ-23-3              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double priceNotebook;
            Console.WriteLine("Введите цену блокнотов = ");
            priceNotebook = Convert.ToDouble(Console.ReadLine());

            int amountNotebook;
            Console.WriteLine("Введите количество блокнотов = " );
            amountNotebook = Convert.ToInt32(Console.ReadLine());

            double pricePencil;
            Console.WriteLine("Введите цену карандашей = " );
            pricePencil = Convert.ToDouble(Console.ReadLine());

            int amountPencil;
            Console.WriteLine("Введите количество карандашей = ");
            amountPencil = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Стоимость покупки = " + ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil));
            Console.ReadKey();
        }
    }
}
