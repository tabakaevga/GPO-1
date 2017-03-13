using System;

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
        {//TODO: Дублирование проверки, что не есть хорошо.
            if (double.IsNaN(weight) || double.IsInfinity(weight))
            {
                throw new InvalidOperationException("Error. NaN or Infinity");
            }
            _weight = weight;
            _repetitions = repetitions;
            _sets = sets;
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
            {
                //TODO: Можно не создавать локальную переменную - сразу возвращать значение.
                var result = ((_weight * _repetitions) * 0.2) * _sets;
                return result;
            }
        }
    };
}
