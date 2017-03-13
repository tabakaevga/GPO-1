namespace Library
{
    /// <remarks>
    ///  Интерфейс
    ///  описывает основные методы, реализованные в дочерних классах
    /// </remarks>
    public interface IPractice
    {
        /// <summary>
        /// Свойство осуществляет расчет данных пользователя
        /// и возвращает количество затраченных калорий
        /// </summary>
        double Kkal { get; }
    };
}
