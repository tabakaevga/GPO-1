using System;

namespace Library
{
    /// <remarks>
    /// Статический класс, осуществляющий проверку на
    /// double.NaN и double.Infinity
    /// </remarks>
    static class CheckDouble
    {
        /// <summary>
        /// метод, осуществляющий проверку на 
        /// double.NaN и double.Infinity
        /// </summary>
        /// <param name="check"> проверяемая переменная типа double</param>
        public static void DoubleCheck(double check)
        {
            if (double.IsNaN(check) || double.IsInfinity(check))
            {
                throw new InvalidOperationException("Error. NaN or Infinity");
            }
        }
    }
}
