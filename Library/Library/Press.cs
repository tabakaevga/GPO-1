using System;

namespace Library
{
    //TODO: Не стоит писать название класса/интерфейса/метода в комментариях, 
    //TODO: поменяете название класса, а в комментарии забудете и будет рассогласование
    /// <remarks>
    ///  Класс Press
    ///  класс программы, осуществляющий вычисления
    ///  при выборе пользователем вида спорта такого как "Press"
    /// </remarks>
    public class Press : IPractice
    {
        private readonly double _weight;
        private readonly int _repetitions;
        private readonly int _sets;

        /// <summary>
        /// Конструктор класса Press
        /// </summary>
        /// <param name="weight"> вес </param>
        /// <param name="repetitions"> количество повторений </param>
        /// <param name="sets"> количество подходов </param>
        public Press(double weight, int repetitions, int sets)
        {
            _weight = weight;
            _repetitions = repetitions;
            _sets = sets;
        }

        /// <summary>
        /// Метод осуществляет расчет данных пользователя
        /// <returns> 
        /// результат возвращается в виде значения типа double 
        /// </returns>
        /// </summary>
        public double GetKkal()
        {
            var result = ((_weight * _repetitions) * 0.2) * _sets;
            return result;
        }
    };
}
