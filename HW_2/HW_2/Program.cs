using System;

namespace HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1.
            //1.Пользователь вводит 2 числа(A и B).Если A > B, подсчитать A+B, если A = B, подсчитать A* B, если A < B, подсчитать A-B.

            //double result = 0;
            //Console.WriteLine("Enter first number");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter remainder humber");
            //double b = Convert.ToDouble(Console.ReadLine());
            //if (a > b) { result = a + b; }
            //else if (a==b) { result = a * b;  }
            //else if (a < b) { result = a - b; }
            //Console.WriteLine($"Your answer is {result}");

            //Задание 2.
            //2.Пользователь вводит 2 числа(X и Y).Определить какой четверти принадлежит точка с координатами(X, Y).

            //Console.WriteLine("Enter x: ");
            //double x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter y: ");
            //double y = Convert.ToDouble(Console.ReadLine());

            //if ((x > 0) && (y > 0))
            //Console.WriteLine("Первая четверть");
            //else
            //{
            //if ((x < 0) && (y > 0))
            //Console.WriteLine("Вторая четверть");
            //else
            //{
            //if ((x < 0) && (y < 0))
            //Console.WriteLine("Третья четверть");
            //else
            //{
            //if ((x > 0) && (y < 0))
            //Console.WriteLine("Четвертая четверть");
            //else
            //Console.WriteLine("Точка лежит на линии");
            //        }
            //    }
            //}

            //Задание 3.
            //3.Пользователь вводит 3 числа(A, B и С).Выведите их в консоль в порядке возрастания.

            //Console.WriteLine("Enter first number");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter remainder number");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter third number");
            //int c = Convert.ToInt32(Console.ReadLine());

            //if (a < b && a < c)
            //{
            //    Console.WriteLine(a);
            //    Console.WriteLine(Math.Min(b, c));
            //    Console.WriteLine(Math.Max(b, c));
            //}
            //else if (b < a && b < c)
            //{
            //    Console.WriteLine(b);
            //    Console.WriteLine(Math.Min(a, c));
            //    Console.WriteLine(Math.Max(a, c));
            //}
            //else if (c < b && c < a)
            //{
            //    Console.WriteLine(c);
            //    Console.WriteLine(Math.Min(a, b));
            //    Console.WriteLine(Math.Max(a, b));
            //}


            //Задание 4.
            //4.Пользователь вводит 3 числа(A, B и С).Выведите в консоль решение(значения X)
            //квадратного уравнения стандартного вида, где AX2 + BX + C = 0.

            //Console.Write("Введите значение a = ");
            //float a = float.Parse(Console.ReadLine());
            //Console.Write("Введите значение b = ");
            //float b = float.Parse(Console.ReadLine());
            //Console.Write("Введите значение c = ");
            //float c = float.Parse(Console.ReadLine());
            //float result = b * b - 4 * a * c;
            //if (result < 0)
            //{
            //    Console.WriteLine("Дискриминант d < 0. Решение квадратного уравнения невозможно.");
            //}
            //else
            //{
            //    float x1, x2;
            //    if (result == 0)
            //    {
            //        x1 = x2 = -(b / 2 * a);
            //    }
            //    else
            //    {
            //        float sqrtD = (float)System.Math.Sqrt(result);
            //        x1 = (-b + sqrtD) / (2 * a);
            //        x2 = (-b - sqrtD) / (2 * a);
            //    }
            //    Console.WriteLine(" x1 = " + x1.ToString() + " x2 = " + x2.ToString());
            //}

            //Задание 5.
            //5.Пользователь вводит двузначное число.Выведите в консоль прописную запись этого числа.
            //Например при вводе “25” в консоль будет выведено “двадцать пять”.


            //    Console.WriteLine("Введите двузначное целое число");
            //    int number = int.Parse(Console.ReadLine());
            //    int integer = number / 10;
            //    int remainder = number % 10;
            //    string result =" ";

            //    if (integer == 1)
            //    {
            //        if (remainder == 0) { Console.WriteLine("Десять"); }
            //        if (remainder == 1) { Console.WriteLine("Одинадцать"); }
            //        if (remainder == 2) { Console.WriteLine("Двенадцать"); }
            //        if (remainder == 3) { Console.WriteLine("Тринадцать"); }
            //        if (remainder == 4) { Console.WriteLine("Четырнадцать"); }
            //        if (remainder == 5) { Console.WriteLine("Пятнадцать"); }
            //        if (remainder == 6) { Console.WriteLine("Шестнадцать"); }
            //        if (remainder == 7) { Console.WriteLine("Семнадцать"); }
            //        if (remainder == 8) { Console.WriteLine("Восемнадцать"); }
            //        if (remainder == 9) { Console.WriteLine("Девятнадцать"); }
            //    }
            //    else if (integer >= 2 && integer <= 9)
            //    {
            //        switch (integer)
            //        {
            //            case 2:
            //                result = "Двадцать";
            //                break;
            //            case 3:
            //                result = "Тридцать";
            //                break;
            //            case 4:
            //                result = "Сорок";
            //                break;
            //            case 5:
            //                result = "Пятьдесят";
            //                break;
            //            case 6:
            //                result = "Шестьдесят";
            //                break;
            //            case 7:
            //                result = "Семдесят";
            //                break;
            //            case 8:
            //                result = "Восемьдесят";
            //                break;
            //            case 9:
            //                result = "Девяносто";
            //                break;
            //        }

            //        switch (remainder)
            //        {
            //            case 1:
            //                result = result + (" один");
            //                Console.WriteLine(result);
            //                break;
            //            case 2:
            //                result = result + (" два");
            //                Console.WriteLine(result);
            //                break;
            //            case 3:
            //                result = result + (" три");
            //                Console.WriteLine(result);
            //                break;
            //            case 4:
            //                result = result + (" четыре");
            //                Console.WriteLine(result);
            //                break;
            //            case 5:
            //                result = result + (" пять");
            //                Console.WriteLine(result);
            //                break;
            //            case 6:
            //                result = result + (" шесть");
            //                Console.WriteLine(result);
            //                break;
            //            case 7:
            //                result = result + (" семь");
            //                Console.WriteLine(result);
            //                break;
            //            case 8:
            //                result = result + (" восемь");
            //                Console.WriteLine(result);
            //                break;
            //            case 9:
            //                result = result + (" девять");
            //                Console.WriteLine(result);
            //                break;
            //        }

            //    }
        }

    }
    }
