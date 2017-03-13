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
            CheckDouble.DoubleCheck(distance);
            CheckDouble.DoubleCheck(style);

            _distance = distance;
            _style = style;
        }

        /// <summary>
        /// Свойство осуществляет расчет данных пользователя
        /// и возвращает количество затраченных калорий
        /// </summary>
        public double Kkal
        {
            get
            {
                return _distance * _style * 1.2;
            }
        }
    };
}
