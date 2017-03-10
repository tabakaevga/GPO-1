﻿namespace Library
{
    /// <remarks>
    ///  Интерфейс Practice
    ///  описывает основные методы, реализованные в дочерних классах
    /// </remarks>
    public interface IPractice
    {

        /// <summary>
        /// Метод осуществляет расчет затраченных калорий,
        /// в зависмости от искомых данных пользователя 
        /// <returns> 
        /// возвращается количество затраченных калорий  
        /// </returns>
        /// </summary>
        double GetKkal();
    };
}
