using System;

namespace HW_3
{
    class Program
    {
        static void Main(string[] args)
        {
        //1. Найти сумму четных чисел и их количество в диапазоне от 1 до 99

        //SumOfEvenNumbers();

        //2.Проверить простое ли число ? (число называется простым, если оно делится только
        //само на себя и на 1)

        //PrimeNumber();

        //3.Найти корень натурального числа с точностью до целого(рассмотреть вариант
        //последовательного подбора и метод бинарного поиска)

        //SequentialSearch();
        //BinarySearch();

        //4.Вычислить факториал числа n.n! = 1 * 2 *…*n - 1 * n; !

        //Factorial();

        //5.Посчитать сумму цифр заданного числа

        //SumOfNumber();

        //6.Вывести число, которое является зеркальным отображением последовательности
        //цифр заданного числа, например, задано число 123, вывести 321.

        //Mirror();

        //7.Простой калькулятор(2 числа и операторы + -* /) с разделением логики на методы.
        //После каждой операции повторно спрашивать числа и производить вычисления.

        //Console.WriteLine("Hello,user!");
        //CallOperator();

        //8.Пользователь вводит 2 числа.Сообщите, есть ли в написании двух чисел одинаковые цифры.
        //Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.

        SameNumbers();
            
        }

        
        private static void SumOfEvenNumbers() 
        {
            //1
            int evennumber = 0;
            int quantity = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    quantity++;
                    evennumber += i;
                }
            }
            Console.WriteLine($"Sum of even numbers = {evennumber}");
            Console.WriteLine($"Quantity of even numbers = {quantity}");

        }

        static private void PrimeNumber()
        {
            //2 
            bool choice = true;
            Console.WriteLine("Enter number");
            int number;
            if (int.TryParse(Console.ReadLine(), out number))
            {
                if(number<=0)
                {
                    Console.WriteLine("Wrong input, please, try again");
                    PrimeNumber();
                }
                else if(number <= 2)
                {
                    Console.WriteLine("Simple");
                }
                else
                {
                    int size = number / 2;
                    for (int i = 2; i < size; i++)
                    {
                        if (number % i == 0)
                        {
                            Console.WriteLine("Not Simple");
                            break;
                        }
                        else if (number % i != 0)
                        {
                            Console.WriteLine("Simple");
                            break;
                        }
                    }
                }
                Console.WriteLine("If you want to continue press F");
                choice = Console.ReadLine() == "f" ? true : false;
                while (choice == true) 
                {
                    PrimeNumber();
                    break;
                }
                if (choice == false) 
                {
                    Console.WriteLine("I was glad to help!");
                }
            }
            else { 
                Console.WriteLine("Wrong input, please, try again");
                PrimeNumber();
            }
        }

        private static void SequentialSearch()
        {
            //3
            int number;
            Console.Write("Enter a natural number:");
            int sequential = 0;
            if (int.TryParse(Console.ReadLine(), out number))
            {
                if (number != 0)
                {
                    {
                        for (int i = 1; i <= number; i = i + 2)
                        {
                            number = number - i;
                            sequential++;
                        }
                        Console.WriteLine($"Root of natural number by sequential search: {sequential}");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input. Please, try again");
                    SequentialSearch();
                }
            }
            else
            {
                Console.WriteLine("Wrong input. Please, try again");
                SequentialSearch();
            }
        }

        private static void BinarySearch()
        {
            //3
            int number;
            Console.Write("Enter a natural number:");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                if (number != 0)
                {
                    {
                        int sqrt = 0;
                        for (int i = 1; i <= number; number = number - i, i = i + 2)
                        {
                            sqrt++;
                        }
                        Console.WriteLine($"Root of natural number by binary search: {sqrt}");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input. Please, try again");
                    BinarySearch();
                }
            }
            else
            {
                Console.WriteLine("Wrong input. Please, try again");
                BinarySearch();
            }

        }
        private static void Factorial() 
        {
            //4
            Console.WriteLine("Please enter a natural number from 0 to 31:");
            int number;
            if (int.TryParse(Console.ReadLine(),out number)) { 
            int factorial = 1;
                if (number <= 31 && number >= 0)
                {
                    for (int i = 2; i <= number; i++)
                    {
                        factorial *= i;
                    }
                    Console.WriteLine($"Factorial n={number}! = {factorial}");
                }
                else if (number > 31) { Console.WriteLine("Too large number"); }
                else if (number < 0)
                {
                    Console.WriteLine("There is no such factorial");
                }
                else
                {
                    Console.WriteLine("Wrong input. Please, try again");
                    Factorial();
                }
            }

        }

        private static void SumOfNumber() 
        {
            //5
            int sum = 0;
            Console.WriteLine("Please enter a natural number:");
            int number;
            if (int.TryParse(Console.ReadLine(), out number))
            {
                for (int i = number; i > 0; i = i / 10)
                {
                    sum = sum + i % 10;
                }
                Console.WriteLine($"Sum of digits of a given number = {sum}");
            }
            else
            {
                Console.WriteLine("Wrong input, please try again");
                SumOfNumber();
            }
            Console.WriteLine("If you want to continue press F");
            bool choice;
            choice = Console.ReadLine() == "f" ? true : false;
            while (choice == true)
            {
                SumOfNumber();
                break;
            }
            if (choice == false)
            {
                Console.WriteLine("I was glad to help!");
            }
           
        }

        private static void Mirror() 
        {
            //6
            int firstnumber;
            Console.Write("Enter a natural number:");
            if (int.TryParse(Console.ReadLine(), out firstnumber))
            {
                int secondnumber = 0;
                while (firstnumber > 0)
                {
                    secondnumber *= 10;
                    secondnumber += firstnumber % 10;
                    firstnumber /= 10;
                }
                Console.WriteLine($"Mirror number is {secondnumber}");
            }
            else
            {
                Console.WriteLine("Wrong input. Please, try again");
                Mirror();
            }
        }


        private static void CallOperator()
        {
            //7
            Console.WriteLine("Choose operator +,-,* or /:");
            char oper = Convert.ToChar(Console.ReadLine());

            if (oper == '+') { SumOfNumbers(); }
            else if (oper == '-') { DifferenceOfNumbers(); }
            else if (oper == '*') { MultiplicationOfNumbers(); }
            else if (oper == '/') { DivisionOfNumbers(); }
            else
            {
                Console.WriteLine("I don't know this operator, try again");
                CallOperator();
            }

        }
        private static void SumOfNumbers()
        {
            //7
            Console.WriteLine("Enter first number");
            double firstnumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double secondnumber = double.Parse(Console.ReadLine());
            double sum = 0;
            sum = firstnumber + secondnumber;
            Console.WriteLine($"Rezult = {sum}");
            bool choice;
            Console.WriteLine("If you want to continue press F");
            choice = Console.ReadLine() == "f" ? true : false;
            if (choice == true)
            {
                CallOperator();
            }
            else if (choice == false)
            {
                Console.WriteLine("I was glad to help!");
            }
        }
        private static void DifferenceOfNumbers()
        {
            //7
            Console.WriteLine("Enter first number");
            double firstnumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double secondnumber = double.Parse(Console.ReadLine());
            double difference = 0;
            difference = firstnumber - secondnumber;
            Console.WriteLine($"Результат = {difference}");
            bool choice;
            Console.WriteLine("If you want to continue press F");
            choice = Console.ReadLine() == "f" ? true : false;
            if (choice == true)
            {
                CallOperator();
            }
            else if (choice == false)
            {
                Console.WriteLine("I was glad to help!");
            }
        }
        private static void MultiplicationOfNumbers()
        {
            //7
            Console.WriteLine("Enter first number");
            double firstnumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double secondnumber = double.Parse(Console.ReadLine());
            double multiplication = 0;
            multiplication = firstnumber * secondnumber;
            Console.WriteLine($"Результат = {multiplication}");
            bool choice;
            Console.WriteLine("If you want to continue press F");
            choice = Console.ReadLine() == "f" ? true : false;
            if (choice == true)
            {
                CallOperator();
            }
            else if (choice == false)
            {
                Console.WriteLine("I was glad to help!");
            }
        }
        private static void DivisionOfNumbers()
        {
            //7
            Console.WriteLine("Enter first number");
            double firstnumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double secondnumber = double.Parse(Console.ReadLine());
            double division = 0;
            division = firstnumber / secondnumber;
            Console.WriteLine($"Результат = {division}");
            bool choice;
            Console.WriteLine("If you want to continue press F");
            choice = Console.ReadLine() == "f" ? true : false;
            if (choice == true)
            {
                CallOperator();
            }
            else if (choice == false)
            {
                Console.WriteLine("I was glad to help!");
            }
        }
        private static void SameNumbers()
        {
            //8
            Console.WriteLine("Enter first number");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int secondnumber = int.Parse(Console.ReadLine());
            bool answer = false;
            while (firstnumber > 0)
            {
                int n = firstnumber % 10;
                firstnumber /= 10;
                int temp = secondnumber;
                while (temp > 0)
                {
                    if (temp % 10 == n)
                    {
                    answer = true;
                    break;
                }
                   temp /= 10;
                }
            }
            if (answer)
            {
              Console.WriteLine("YES");
            }
                    else
                    {
                        Console.WriteLine("NO");
                    }

        }


        


    }

}
