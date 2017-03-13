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
                return _distance * _style * 0.8;
            }
        }
    };
}
