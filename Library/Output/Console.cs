using System;
using  Library;

namespace Output
{
    /// <remarks>
    ///  основной класс программы
    ///  реализующий ввод и вывод обработанных данных пользователя
    /// </remarks>
    internal class MainClass
    {
        /// <summary>
        /// Метод является
        /// входной точкой работы программы
        /// </summary>
        private static void Main()
        {
            Console.WriteLine("Select sport: ");
            Console.WriteLine("1 - Running");
            Console.WriteLine("2 - Swimming");
            Console.WriteLine("3 - Press");
            while (true)
            {
                int enterNumb;
                if (CheckEnterData(1, 3, out enterNumb))
                {
                    Console.WriteLine("Error");
                }

                double distance;
                double style;
                switch (enterNumb)
                    {
                        case 1:
                            {
                                EnterDataRunning(out distance, out style);
                                IPractice sport = new Running(distance, style);
                                Console.Clear();
                                Console.WriteLine("Kkal = " + sport.Kkal);
                                Console.ReadKey();
                                return;
                            }
                        case 2:
                            {
                                EnterDataSwimming(out distance, out style);
                                IPractice sport = new Swimming(distance, style);
                                Console.Clear();
                                Console.WriteLine("Kkal = " + sport.Kkal);
                                Console.ReadKey();
                                return;
                            }
                        case 3:
                            {
                                double weight;
                                int repetitions;
                                int sets;
                                EnterDataPress(out weight, out repetitions, out sets);
                                IPractice sport = new Press(weight, repetitions, sets);
                                Console.Clear();
                                Console.WriteLine("Kkal = " + sport.Kkal);
                                Console.ReadKey();
                                return;
                            }
                        default:
                            Console.WriteLine("Error");
                            return;
                    }
                }
            }

        /// <summary>
        /// метод реализует ввод и проверку данных пользователя,
        /// если был выбран вид спорта как "Running"
        /// </summary>
        /// <param name="distance"> дистанция забега </param>
        /// <param name="style"> интенсивность бега </param>
        private static void EnterDataRunning(out double distance, out double style)
        {
            style = 0;
            Console.WriteLine("Enter your data");
            Console.WriteLine("Distance(meters) - ");
            if (CheckEnterData(1, 100000, out distance))
            {
                return;
            }

            Console.WriteLine("Intensity: 1 - low; 2 - medium; 3 - high ");
            int checkStyle;
            if (CheckEnterData(1, 3, out checkStyle))
            {
                return;
            }

            switch (checkStyle)
            {
                case 1:
                {
                    style = 0.3;
                    break;
                }
                case 2:
                {
                    style = 0.5;
                    break;
                }
                case 3:
                {
                    style = 0.8;
                    break;
                }
                default:
                    Console.WriteLine("Error in enter style");
                    break;
            }
        }

        /// <summary>
        /// метод реализует ввод и проверку данных пользователя,
        /// если был выбран вид спорта как "Swimming"
        /// </summary>
        /// <param name="distance"> дистанция заплыва </param>
        /// <param name="style"> стиль плавания </param>
        private static void EnterDataSwimming(out double distance, out double style)
        {
            style = 0;
            Console.WriteLine("Enter your data");
            Console.WriteLine("Distance(meters) - ");
            if (CheckEnterData(1, 100000, out distance))
            {
                return;
            }


            Console.WriteLine("Style: 1 - free; 2 - сrawl; 3 - butterfly ");
            int checkStyle;
            if (CheckEnterData(1, 3, out checkStyle))
            {
                return;
            }

            switch (checkStyle)
            {
                case 1:
                    {
                        style = 1;
                        break;
                    }
                case 2:
                    {
                        style = 1.5;
                        break;
                    }
                case 3:
                    {
                        style = 1.8;
                        break;
                    }
                default:
                    Console.WriteLine("Error in enter style");
                    break;
            }
        }

        /// <summary>
        /// метод реализует ввод и проверку данных пользователя,
        /// если был выбран вид спорта как "Press"
        /// </summary>
        /// <param name="weight"> вес </param>
        /// <param name="repetitions"> количество повторений</param>
        /// <param name="sets"> количество подходов </param>
        private static void EnterDataPress(out double weight, out int repetitions, out int sets)
        {
            Console.WriteLine("Enter your data");

            Console.WriteLine("Weight(kilogram) - ");
            if (CheckEnterData(1, 500, out weight))
            {
                repetitions = 0;
                sets = 0;
                return;
            }

            Console.WriteLine("Number of repetitions - ");
            if (CheckEnterData(1, 100, out repetitions))
            {
                sets = 0;
                return;
            }

            Console.WriteLine("Number of sets - ");
            if (CheckEnterData(1, 20, out sets))
            {
                return;
            }
        }

        /// <summary>
        /// метод осуществляет проверку на ввод данных пользователя
        /// и принадлежности заданному диапазону
        /// </summary>
        /// <typeparam name="T"> универсальный параметр </typeparam>
        /// <param name="min"> минимально число диапазона </param>
        /// <param name="max"> максимальное число диапазона </param>
        /// <param name="enterNum"> вводимое пользователем число</param>
        /// <returns> возвращает false, если вводимое число, принадлежит заданному диапазону </returns>
        private static bool CheckEnterData<T>(int min, int max, out T enterNum)
        {
            while (true)
            {
                try
                {
                    enterNum = ChangeType<T>(Console.ReadLine());
                    int enterNumToInt = ChangeType<int>(enterNum); // для проверки принадлежности диапазону (т.к min и max - Int)
                    if (enterNumToInt < min || enterNumToInt > max)
                    {
                        Console.WriteLine("Error. Сhoose correct number");
                        continue;
                    }
                    Console.Clear();
                    return false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("You entered is not a number");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error. Сhoose correct number");
                    continue;
                }
            }
        }

        /// <summary>
        /// метод осуществляет конвертирование из искомого типа данных в заданный
        /// </summary>
        /// <typeparam name="T"> универсальный параметр </typeparam>
        /// <param name="obj"> конвертируемая переменная </param>
        /// <returns> возвращает сковертированную переменную </returns>
        public static T ChangeType<T>(object obj)
        {
            return (T)Convert.ChangeType(obj, typeof(T));
        }
    }
}
