using System;

namespace AreaCalcLib
{
    /// <summary>
    /// Класс для рассчёта площади треугольника
    /// </summary>
    public class Triangle : Figure
    {
        /// <summary>
        /// сторона A
        /// </summary>
        public double A {get;set;}

        /// <summary>
        /// сторона B
        /// </summary>
        public double B { get;set;}

        /// <summary>
        /// сторона C
        /// </summary>
        public double C { get;set;}

        /// <summary>
        /// Конструктор класса принимает в качестве входных параметров 
        /// длины сторон треугольника
        /// </summary>
        public Triangle(double sideA, double sideB, double sideC)
        {
            this.A = sideA;
            this.B = sideB;
            this.C = sideC;
        }

        /// <summary>
        /// Проверяет, является ли треугольник валидным
        /// </summary>
        public override bool Checked()
        {
            if (A + B > C && A + C > B && B + C > A)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Возвращает площадь треугольника
        /// </summary>
        public override double GetArea()
        {
            double result = 0;

            if (Checked())
            {
                double p = (A + B + C) / 2;
                result = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
            return result;
        }

        /// <summary>
        /// Проверяет, является ли треугольник прямоугольным.
        /// </summary>
        public bool IsRightTriangle()
        {
            if (!Checked()) return false;

            double a2 = A * A;
            double b2 = B * B;
            double c2 = C * C;
            bool result = false;

            if ((a2 + b2) == c2)
            {
                result = true;
            }
            else if ((a2 + c2) == b2)
            {
                result = true;
            }
            else if ((b2 + c2) == a2)
            {
                result = true;
            }
            return result;
        }
    }
}
