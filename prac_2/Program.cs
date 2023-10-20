using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите задание (1-15) или введите '0' для выхода:");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 0)
                {
                    Console.WriteLine("Выход из программы.");
                    break;
                }

                switch (choice)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Task4();
                        break;
                    case 5:
                        Task5();
                        break;
                    case 6:
                        Task6();
                        break;
                    case 7:
                        Task7();
                        break;
                    case 8:
                        Task8();
                        break;
                    case 9:
                        Task9();
                        break;
                    case 10:
                        Task10();
                        break;
                    case 11:
                        Task11();
                        break;
                    case 12:
                        Task12();
                        break;
                    case 13:
                        Task13();
                        break;
                    case 14:
                        Task14();
                        break;
                    case 15:
                        Task15();
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, введите число от 1 до 15.");
                        break;
                }
            }
        }

        // 1 задание
        static void Task1()
        {
            int number1 = 7;
            int number2 = 14;
            int number3 = 29;
            Console.WriteLine($"{number1}  {number2}  {number3}");
        }

        // 2 задание
        static void Task2()
        {
            Console.WriteLine("5");
            Console.WriteLine("10");
            Console.WriteLine("21");
        }


        // 3 задание
        static void Task3()
        {
            Console.WriteLine("Дано расстояние в сантиметрах. Найти число полных метров в нем.");
            Console.WriteLine("Введите расстояние в сантиметрах:");
            int distanceInCentimeters = Convert.ToInt32(Console.ReadLine());
            int meters = distanceInCentimeters / 100;
            Console.WriteLine($"Число полных метров: {meters}");
        }

        // 4 задание
        static void Task4()
        {
            Console.WriteLine("С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?");
            int days = 234;
            int weeks = days / 7;
            Console.WriteLine($"Число полных недель: {weeks}");
        }

        // 5 задание
        static void Task5()
        {
            Console.WriteLine("Дано двузначное число. Найти:");
            Console.WriteLine("Введите двузначное число:");
            int number = Convert.ToInt32(Console.ReadLine());
            int tens = number / 10;
            int units = number % 10;
            int sum = tens + units;
            int product = tens * units;
            Console.WriteLine($"Число десятков: {tens}");
            Console.WriteLine($"Число единиц: {units}");
            Console.WriteLine($"Сумма цифр: {sum}");
            Console.WriteLine($"Произведение цифр: {product}");
        }

        // 6 задание
        static void Task6()
        {
            Console.WriteLine("Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь");
            bool A = true;
            bool B = false;
            bool C = false;

            Console.WriteLine($"a. A или B: {A || B}");
            Console.WriteLine($"b. A и B: {A && B}");
            Console.WriteLine($"c. B или C: {B || C}");
        }

        // 7 задание
        static void Task7()
        {
            Console.WriteLine("Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?");
            Console.WriteLine("Введите радиус круга:");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону квадрата:");
            double side = Convert.ToDouble(Console.ReadLine());

            double circleArea = Math.PI * Math.Pow(radius, 2);
            double squareArea = Math.Pow(side, 2);

            if (circleArea > squareArea)
            {
                Console.WriteLine("Площадь круга больше.");
            }
            else if (circleArea < squareArea)
            {
                Console.WriteLine("Площадь квадрата больше.");
            }
            else
            {
                Console.WriteLine("Площади равны.");
            }
        }

        // 8 задание
        static void Task8()
        {
            Console.WriteLine("Даны объемы и массы двух тел из разных материалов. Материал какого из тел имеет большую плотность?");
            Console.WriteLine("Введите объем первого тела (в м^3):");
            double volume1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите массу первого тела (в кг):");
            double mass1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите объем второго тела (в м^3):");
            double volume2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите массу второго тела (в кг):");
            double mass2 = Convert.ToDouble(Console.ReadLine());

            double density1 = mass1 / volume1;
            double density2 = mass2 / volume2;

            if (density1 > density2)
            {
                Console.WriteLine("Первое тело имеет большую плотность.");
            }
            else if (density1 < density2)
            {
                Console.WriteLine("Второе тело имеет большую плотность.");
            }
            else
            {
                Console.WriteLine("Плотности равны.");
            }
        }

        // 9 задание
        static void Task9()
        {
            Console.WriteLine("Известны сопротивления двух несоединенных друг с другом участков электрической цепи и напряжение на каждом из них. По какому участку протекает меньший ток?");
            Console.WriteLine("Введите сопротивление первого участка (в Ом):");
            double resistance1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите напряжение на первом участке (в Вольтах):");
            double voltage1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сопротивление второго участка (в Ом):");
            double resistance2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите напряжение на втором участке (в Вольтах):");
            double voltage2 = Convert.ToDouble(Console.ReadLine());

            double current1 = voltage1 / resistance1;
            double current2 = voltage2 / resistance2;

            if (current1 < current2)
            {
                Console.WriteLine("Меньший ток протекает по первому участку.");
            }
            else if (current1 > current2)
            {
                Console.WriteLine("Меньший ток протекает по второму участку.");
            }
            else
            {
                Console.WriteLine("Токи равны.");
            }
        }

        // 10 задание
        static void Task10()
        {
            Console.WriteLine("Введите номер задачи (a, b, c, d):");
            char task = Convert.ToChar(Console.ReadLine());

            switch (task)
            {
                case 'a':
                    Console.WriteLine("Все целые числа от 20 до 35:");
                    for (int i = 20; i <= 35; i++)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                case 'b':
                    Console.WriteLine("Введите значение b (b > 10):");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Квадраты всех целых чисел от 10 до {b}:");
                    for (int i = 10; i <= b; i++)
                    {
                        int square = i * i;
                        Console.WriteLine(square);
                    }
                    break;
                case 'c':
                    Console.WriteLine("Введите значение a (a < 50):");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Третьи степени всех целых чисел от {a} до 50:");
                    for (int i = a; i <= 50; i++)
                    {
                        int cube = i * i * i;
                        Console.WriteLine(cube);
                    }
                    break;
                case 'd':
                    Console.WriteLine("Введите значение a:");
                    int aRange = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите значение b (b > a):");
                    int bRange = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Все целые числа от {aRange} до {bRange}:");
                    for (int i = aRange; i <= bRange; i++)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                default:
                    Console.WriteLine("Неверный вариант задачи.");
                    break;
            }
        }

        // 11 задание
        static void Task11()
        {
            Console.WriteLine("Введите значение x:");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Math.Pow(x, 2) - 2 * x + 1;
            Console.WriteLine($"Значение функции при x = {x}: y = {y}");
        }

        // 12 задание
        static void Task12()
        {
            Console.WriteLine("Введите радиус окружности:");
            double radius = Convert.ToDouble(Console.ReadLine());

            double circumference = 2 * Math.PI * radius;
            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"Длина окружности: {circumference}");
            Console.WriteLine($"Площадь круга: {area}");
        }

        // 13 задание
        static void Task13()
        {
            Console.WriteLine("Введите расстояние в сантиметрах:");
            int distanceInCentimeters = Convert.ToInt32(Console.ReadLine());
            int meters = distanceInCentimeters / 100;
            Console.WriteLine($"Число полных метров: {meters}");
        }

        // 14 задание
        static void Task14()
        {
            Console.WriteLine("Введите количество дней:");
            int days = Convert.ToInt32(Console.ReadLine());
            int weeks = days / 7;
            Console.WriteLine($"Число полных недель: {weeks}");
        }

        // 15 задание
        static void Task15()
        {
            Console.WriteLine("Введите двузначное число:");
            int number = Convert.ToInt32(Console.ReadLine());

            int tens = number / 10;
            int units = number % 10;
            int sum = tens + units;
            int product = tens * units;

            Console.WriteLine($"Число десятков: {tens}");
            Console.WriteLine($"Число единиц: {units}");
            Console.WriteLine($"Сумма цифр: {sum}");
            Console.WriteLine($"Произведение цифр: {product}");
        }
    }

}
