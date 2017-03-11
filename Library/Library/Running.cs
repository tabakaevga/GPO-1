﻿using System;

namespace Library
{
    //TODO: Не стоит писать название класса/интерфейса/метода в комментариях, 
    //TODO: поменяете название класса, а в комментарии забудете и будет рассогласование
    /// <remarks>
    ///  Класс Running
    ///  класс программы, осуществляющий вычисления
    ///  при выборе пользователем вида спорта такого как "Running"
    /// </remarks>
    public class Running : IPractice
    {
        private readonly double _distance;
        private readonly double _style;

        /// <summary>
        /// Конструктор класса Running
        /// </summary>
        /// <param name="distance"> дистанция забега </param>
        /// <param name="style"> интенсивность бега </param>
        public Running(double distance, double style)
        {
            _distance = distance;
            _style = style;
        }

        /// <summary>
        /// Метод осуществляет расчет данных пользователя
        /// <returns> 
        /// результат возвращается в виде значения типа double 
        /// </returns>
        /// </summary>
        public double GetKkal()
        {
            var result = _distance * _style * 0.8;
            return result;
        }
    };
}
