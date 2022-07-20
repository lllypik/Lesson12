using System;

namespace Task
{
    public static class Circle
    {
        // метод вычисления площади окружности
        public static double GetArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        //метод вычисления длины окружности
        public static double GetCircumference(double radius)
        {
            return Math.PI * radius * 2;
        }

        //метод вычисления нахождения точки в окружности 
        public static bool GetCercleAffiliationDot(double radius, double circleСenterСoordinateX, double circleСenterСoordinateY, double circleDotСoordinateX, double circleDotСoordinateY)
        {
            // Расстояние от точки до центра круга
            double lengh = Math.Sqrt((circleDotСoordinateX - circleСenterСoordinateX) * (circleDotСoordinateX - circleСenterСoordinateX) + (circleDotСoordinateY - circleСenterСoordinateY) * (circleDotСoordinateY - circleСenterСoordinateY));
            if (lengh <= radius) return true;
            else return false;
        }
    }
}