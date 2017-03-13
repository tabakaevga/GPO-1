using System;

namespace Library
{
    /// <remarks>
    ///  класс программы, осуществляющий вычисления
    ///  при выборе пользователем вида спорта такого как "Running"
    /// </remarks>
    public class Running : IPractice
    {
        private readonly double _distance;
        private readonly double _style;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="distance"> дистанция забега </param>
        /// <param name="style"> интенсивность бега </param>
        public Running(double distance, double style)
        {//TODO: Дублирование проверки, что не есть хорошо.
            if (double.IsNaN(style) || double.IsInfinity(style))
            {
                throw new InvalidOperationException("Error. NaN or Infinity");
            }

            if (double.IsNaN(distance) || double.IsInfinity(distance))
            {
                throw new InvalidOperationException("Error. NaN or Infinity");
            }
            _distance = distance;
            _style = style;
        }

        //TODO: Уже не метод.
        /// <summary>
        /// Метод осуществляет расчет данных пользователя
        /// <returns> 
        /// возвращается количество затраченных калорий  
        /// </returns>
        /// </summary>
        public double Kkal
        {
            get
            {//TODO: Можно не создавать локальную переменную - сразу возвращать значение.
                var result = _distance * _style * 0.8;
                return result;
            }
        }
    };
}
