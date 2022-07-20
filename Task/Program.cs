using System;

namespace Task
{

    class Program
    {
        //Метод проверки данных
        public static double CheckEnterDataOnSymbolDouble()
        {
            bool flag = false;
            double value = 0;
            do
            {
                try
                {
                    value = Convert.ToDouble(Console.ReadLine());
                    flag = true;
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message); Console.WriteLine(" Введите корректные данные повторно");
                }
            }
            while (flag == false);
            return value;
        }

        static void Main(string[] args)
        {
            //Объявление переменных
            string cercleAff;

            //Блок ввода данных
            Console.WriteLine("Введите радиус окружности");
            double radius = CheckEnterDataOnSymbolDouble();
            Console.WriteLine("Введите координату Х центра окружности");
            double centreX = CheckEnterDataOnSymbolDouble();
            Console.WriteLine("Введите координату Y центра окружности");
            double centreY = CheckEnterDataOnSymbolDouble();
            Console.WriteLine("Введите координату Y точки");
            double dotX = CheckEnterDataOnSymbolDouble();
            Console.WriteLine("Введите координату Y точки");
            double dotY = CheckEnterDataOnSymbolDouble();

            //Проверка работы статического класса
            double lenght = Circle.GetCircumference(radius);
            double area = Circle.GetArea(radius);
            bool cercleAffiliationDot = Circle.GetCercleAffiliationDot(radius, centreX, centreY, dotX, dotY);
            if (cercleAffiliationDot) cercleAff = "Точка лежит внутри круга круга";
            else cercleAff = "Точка находится вне круга";

            //Вывод полученных данных
            Console.WriteLine("Длина окружности круга - {0}; площадь круга - {1}; {2}", lenght, area, cercleAff);
            Console.ReadKey();
        }
    }
}
