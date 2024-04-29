using System;

namespace AreaCalcLib
{
    /// <summary>
    /// Класс для рассчёта площади круга
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Радиус окружности 
        /// </summary>
        public double R { get; set; }

        /// <summary>
        /// Конструктор класса для рассчёта площади круга. 
        /// Имеет входной параметр: радиус окружности
        /// </summary>
        public Circle(double r)
        {
            this.R = r;
        }

        /// <summary>
        /// Проверяет, является ли круг валидным.
        /// Валидным является круг, у которого длина радиуса > 0
        /// </summary>
        public override bool Checked()
        {
            if (R > 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Возвращает площадь круга
        /// </summary>
        public override double GetArea()
        {
            double result = 0;
            if (Checked() == true)
            {
                result = Math.PI * R * R;
            }
            else
            {
                result = 0;
            }
            return result;
        }
    }
}
