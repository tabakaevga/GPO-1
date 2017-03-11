using System;

namespace Library
{
    //TODO: Не стоит писать название класса/интерфейса/метода в комментариях, 
    //TODO: поменяете название класса, а в комментарии забудете и будет рассогласование
    /// <remarks>
    ///  Класс Swimming
    ///  класс программы, осуществляющий вычисления
    ///  при выборе пользователем вида спорта такого как "Swimming"
    /// </remarks>
    public class Swimming : IPractice
    {
        private readonly double _distance;
        private readonly double _style;

        /// <summary>
        /// конструктор класса Swimming
        /// </summary>
        /// <param name="distance"> дистанция заплыва </param>
        /// <param name="style"> стиль плавания </param>
        public Swimming(double distance, double style)
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
            var result = _distance * _style * 1.2;
            return result;
        }
    };
}
