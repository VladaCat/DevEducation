using System;

namespace HW_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Пользователь вводит 2 числа(A и B).Вывести сумму всех чисел из диапазона от A до B,
            //которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).

            Sum();

            //2.Пользователь вводит 1 число(A).Найдите количество положительных целых чисел, квадрат которых меньше A.

            //QuantyPlusNumbers();
        }

        private static void Sum() 
        {
            Console.WriteLine("Enter first number");
            string a = Console.ReadLine();
            Console.WriteLine("Enter second number");
            string b = Console.ReadLine();
            double firstnumber;
            double secondnumber;
            double result = 0;
            if (double.TryParse(a, out firstnumber) && double.TryParse(b, out secondnumber))
            {
                if (firstnumber % 1 != 0 || secondnumber % 1 != 0)
                {
                    Console.WriteLine("Wrong input, please try again");
                    Sum();
                }
                else
                {
                    if (secondnumber > firstnumber)
                    {
                        for (double i = firstnumber; i <= secondnumber; i++)
                        {
                            if (i % 7 == 0)
                            {
                                result += i;
                            }
                            else
                            {
                                result += 0;
                            }
                        }
                        Console.WriteLine(result);
                    }
                    else
                    {
                        for (double i = secondnumber; i <= firstnumber; i++)
                        {
                            if (i % 7 == 0)
                            {
                                result += i;
                            }
                            else
                            {
                                result += 0;
                            }
                        }
                        Console.WriteLine(result);
                    }
                }

            }
            else
            {
                Console.WriteLine("Wrong input, please try again");
                Sum();
            }
    }

        private static void QuantyPlusNumbers() 
        {
            int i = 2;
            int number;
            int quantity = 0;
            Console.WriteLine("Enter positive number:");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                if (number <= 0)
                {
                    Console.WriteLine("Your number is less then 0, please try again");
                    QuantyPlusNumbers();
                }
                else
                {
                    while (i * i < number)
                    {
                        i++;
                        quantity++;
                        if (i * i >= number)
                        {
                            break;
                        }
                    }
                    Console.WriteLine($"The number of positive integers whose square is less than your number: {quantity}");
                }
            }
            else 
            { 
                Console.WriteLine("Wrong input, please try again");
                QuantyPlusNumbers();
            }
        }
    }
}
