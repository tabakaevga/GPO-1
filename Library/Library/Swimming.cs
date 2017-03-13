﻿using System;

namespace Library
{
    /// <remarks>
    ///  класс программы, осуществляющий вычисления
    ///  при выборе пользователем вида спорта такого как "Swimming"
    /// </remarks>
    public class Swimming : IPractice
    {
        private readonly double _distance;
        private readonly double _style;

        /// <summary>
        /// конструктор класса
        /// </summary>
        /// <param name="distance"> дистанция заплыва </param>
        /// <param name="style"> стиль плавания </param>
        public Swimming(double distance, double style)
        {
            //TODO: Дублирование проверки, что не есть хорошо.
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
                var result = _distance * _style * 1.2;
                return result;
            }
        }
    };
}
