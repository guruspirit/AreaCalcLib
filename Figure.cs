namespace AreaCalcLib
{
    /// <summary>
    /// от абстрактного класса Figure должны наследоваться все фигуры, входящие в библиотеку 
    /// </summary>
    public abstract class Figure : ICheckable
    {
        /// <summary>
        /// абстрактный метод для проверки входных параметров
        /// </summary>
        public abstract bool Checked();

        /// <summary>
        /// абстрактный метод для получения площади фигуры 
        /// </summary>
        // для каждой фигуры нужно рассчитать площадь
        public abstract double GetArea(); 
    }
}
