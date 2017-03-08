using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{

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
            try
            {
                _distance = distance;
                _style = style;
            }
            catch (ArithmeticException)
            {
                Console.WriteLine($"Error. You entered is not a number");
            }
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
