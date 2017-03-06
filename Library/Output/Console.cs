using System;
using  Library;

namespace Output
{

    /// <remarks>
    ///  Класс MainClass
    ///  основной класс программы
    ///  реализующий ввод и вывод обработанных данных пользователя
    /// </remarks>
    class MainClass
    {
        /// <summary>
        /// Метод Main() является
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
                try
                {
                    var choiceSport = int.Parse(Console.ReadLine());

                    if (choiceSport < 1 || choiceSport > 3)
                    {
                        Console.WriteLine("Error. Сhoose 1-3");
                        continue;
                    }
                    switch (choiceSport)
                    {
                        case 1:
                        {
                                double distance;
                                double style;
                                Running(out distance, out style);
                                IPractice sport = new Running(distance, style);
                                Console.Clear();
                                Console.WriteLine("Kkal = ");
                                Console.Write(sport.GetResult());
                                Console.ReadKey();
                                break;
                            }
                        case 2:
                            {
                                double distance;
                                double style;
                                Swimming(out distance, out style);
                                IPractice sport = new Swimming(distance, style);
                                Console.Clear();
                                Console.WriteLine("Kkal = ");
                                Console.Write(sport.GetResult());
                                Console.ReadKey();
                                break;
                            }
                        case 3:
                            {
                                double weight;
                                int repetitions;
                                int sets;
                                Press(out weight, out repetitions, out sets);
                                IPractice sport = new Press(weight, repetitions, sets);
                                Console.Clear();
                                Console.WriteLine("Kkal = ");
                                Console.Write(sport.GetResult());
                                Console.ReadKey();
                                break;
                            }
                        default:
                            Console.WriteLine("Error");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("You entered is not a number. Сhoose 1-3");
                    continue;
                }
                break;
            }
        }

        /// <summary>
        /// метод реализует ввод и проверку данных пользователя,
        /// если был выбран вид спорта как "Running"
        /// </summary>
        /// <param name="distance"> дистанция забега </param>
        /// <param name="style"> интенсивность бега </param>
        private static void Running(out double distance, out double style)
        {
            style = 0;
            Console.WriteLine("Enter your data");
            Console.WriteLine("Distance(meters) - ");
            while (true)
            {
                try
                {
                    distance = double.Parse(Console.ReadLine());
                    if (distance < 1)
                    {
                        Console.WriteLine("Error. Distance < 1 Try again");
                        continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("You entered is not a number. Enter number > 0");
                    continue;
                }
                break;
            }

            Console.WriteLine("Intensity: 1 - low; 2 - medium; 3 - high ");
            while (true)
            {
                int choiceStyle;
                try
                {
                    choiceStyle = int.Parse(Console.ReadLine());
                    if (choiceStyle < 1 || choiceStyle > 3)
                    {
                        Console.WriteLine("Error. Choose 1-3");
                        continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("You entered is not a number. Enter number > 0");
                    continue;
                }
                switch (choiceStyle)
                {
                    case 1:
                        style = 0.3;
                        break;
                    case 2:
                        style = 0.5;
                        break;
                    case 3:
                        style = 0.8;
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                break;
            }
        }

        /// <summary>
        /// метод реализует ввод и проверку данных пользователя,
        /// если был выбран вид спорта как "Swimming"
        /// </summary>
        /// <param name="distance"> дистанция заплыва </param>
        /// <param name="style"> стиль плавания </param>
        private static void Swimming(out double distance, out double style)
        {
            style = 0;
            Console.WriteLine("Enter your data");
            Console.WriteLine("Distance(meters) - ");
            while (true)
            {
                try
                {
                    distance = double.Parse(Console.ReadLine());
                    if (distance < 1)
                    {
                        Console.WriteLine("Error. Distance < 1 Try again");
                        continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("You entered is not a number. Enter number > 0");
                    continue;
                }
                break;
            }

            Console.WriteLine("Style: 1 - free; 2 - сrawl; 3 - butterfly ");
            while (true)
            {
                int choiceStyle;
                try
                {
                    choiceStyle = int.Parse(Console.ReadLine());
                    if (choiceStyle < 1 || choiceStyle > 3)
                    {
                        Console.WriteLine("Error. Сhoose 1-3");
                        continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("You entered is not a number. Enter number > 0");
                    continue;
                }
                switch (choiceStyle)
                {
                    case 1:
                        style = 1;
                        break;
                    case 2:
                        style = 1.6;
                        break;
                    case 3:
                        style = 1.8;
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
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
        private static void Press(out double weight, out int repetitions, out int sets)
        {
            Console.WriteLine("Enter your data");

            Console.WriteLine("Weight(kilogram) - ");
            while (true)
            {
                try
                {
                    weight = double.Parse(Console.ReadLine());
                    if (weight < 1)
                    {
                        Console.WriteLine("Error. Weight < 1. Try again");
                        continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("You entered is not a number. Enter number > 0");
                    continue;
                }
                break;
            }

            Console.WriteLine("Number of repetitions - ");
            while (true)
            {
                try
                {
                    repetitions = int.Parse(Console.ReadLine());
                    if (repetitions < 1)
                    {
                        Console.WriteLine("Error. Repetitions < 1. Try again");
                        continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("You entered is not a number. Enter number > 0");
                    continue;
                }
                break;
            }

            Console.WriteLine("Number of sets - ");
            while (true)
            {
                try
                {
                    sets = int.Parse(Console.ReadLine());
                    if (sets < 1)
                    {
                        Console.WriteLine("Error. Sets < 1. Try again");
                        continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("You entered is not a number. Enter number > 0");
                    continue;
                }
                break;
            }
        }


    }
}
