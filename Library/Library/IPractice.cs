using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <remarks>
    ///  Интерфейс Practice
    ///  описывает основные методы, реализованные в дочерних классах
    /// </remarks>
    public interface IPractice
    {

        /// <summary>
        /// Метод осуществляет расчет данных пользователя
        /// <returns> 
        /// возвращается количество затраченных калорий  
        /// </returns>
        /// </summary>
        double GetResult();
    };
}
