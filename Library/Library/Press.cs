namespace Library
{
    /// <remarks>
    ///  класс программы, осуществляющий вычисления
    ///  при выборе пользователем вида спорта такого как "Press"
    /// </remarks>
    public class Press : IPractice
    {
        private readonly double _weight;
        private readonly int _repetitions;
        private readonly int _sets;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="weight"> вес </param>
        /// <param name="repetitions"> количество повторений </param>
        /// <param name="sets"> количество подходов </param>
        public Press(double weight, int repetitions, int sets)
        {
            CheckDouble.DoubleCheck(weight);

            _weight = weight;
            _repetitions = repetitions;
            _sets = sets;
        }

        /// <summary>
        /// Свойство осуществляет расчет данных пользователя
        /// и возвращает количество затраченных калорий
        /// </summary>
        public double Kkal
        {
            get
            {
                return _weight * _repetitions * 0.2 * _sets;
            }
        }
    };
}
