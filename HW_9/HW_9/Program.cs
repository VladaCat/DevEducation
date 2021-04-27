using System;

namespace HW_9
{
   public class Program
    {
        static void Main(string[] args)
        {
            //1
            //bool f = true;
            //var calc = new Calculator();
            //do
            //{
            //    Console.WriteLine("Enter first number:");
            //    string s = Console.ReadLine();
            //    if (s == "f")
            //    {
            //        Console.WriteLine("I was glad to help!");
            //        break;
            //    }
            //    while (!Calculator.IsNumber(s))
            //    {
            //        Console.WriteLine("Try again");
            //        s = Console.ReadLine();
            //    }
            //    double firstnumber = Convert.ToDouble(s);
            //    Console.WriteLine("Enter second number:");
            //    s = Console.ReadLine();
            //    while (!Calculator.IsNumber(s))
            //    {
            //        Console.WriteLine("Try again");
            //        s = Console.ReadLine();
            //    }
            //    double secondnumber = Convert.ToDouble(s);
            //    Console.WriteLine("Select operation '+' , '-' , '*' , '/':");
            //    string operation = Console.ReadLine().ToUpper();
            //    var num = calc.Count(firstnumber, secondnumber, operation);
            //    Console.WriteLine(num);
            //    Console.WriteLine("To exit press f");

            //} while (f == true);


            //2
            //var array = new WorkWithArray();
            //array.AddElement();
            //array.Print();
            //array.DeleteElement();
            //array.Print();
            //array.SortArray();
            //array.Print();
            //array.ClearArray();
            //array.Print();

            //3
            //Console.WriteLine("Enter number:");
            //string message = WordsConstructor(int.Parse(Console.ReadLine()));
            //Console.WriteLine(message);
        }
        public static string WordsConstructor(int number)
        {
            string words = "";

            if (number == 0)
                return "zero";

            if (number < 0)
            {
                Console.WriteLine("Your number is too small");
            }
            if ((number / 1000) > 0)
            {
                Console.WriteLine("Your number is too large");
            }
            if ((number / 100) > 0)
            {
                words += WordsConstructor(number / 100) + " hundred";
                number %= 100;
            }
            if (number > 0)
            {
                if (words != "")
                    words += " ";

                var units = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tens = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += units[number];
                else
                {
                    words += tens[number / 10];
                    if ((number % 10) > 0)
                        words += " " + units[number % 10];
                }
            }
            return words;
        }
    }
}
