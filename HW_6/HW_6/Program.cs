using System;

namespace HW_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-4
            //int[,] arr = new int[4, 4];
            //InitializeArray(arr);
            //Console.WriteLine();
            //Console.WriteLine("Min Element in array: {0}", MinElement(arr));
            //Console.WriteLine("Max Element in array: {0}", MaxElement(arr));
            //Console.ReadLine();

            //5
            //int[,] arr = new int[4, 4];
            //InitializeArray(arr);
            //Console.WriteLine();
            //Console.WriteLine("Count of numbers who are bigger than all their neighbors: {0}", CounterNeighborMax(arr));

            //6
            //Console.WriteLine("Enter number:");
            //string message = WordsConstructor(int.Parse(Console.ReadLine()));
            //Console.WriteLine(message);

            //7 //Сделано только для сотен, постараюсь на гит залить уже полностью рабочий код.
            //TextToNumber(); 

        }
        private static void InitializeArray(int[,] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(100);
                    Console.Write($"{arr[i, j]}"+" ");
                }
                Console.WriteLine();
            }
        }

        private static int MinElement(int[,] arr)
        {
            int index = 0;
            int index1 = 0;
            int minElement = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (minElement >= arr[i, j])
                    {
                        minElement = arr[i, j];
                        index = i;
                        index1 = j;   
                    }
                }
            }
            Console.WriteLine($"Index min element: [{index},{index1}]");
            return minElement;
        }
        private static int MaxElement(int[,] arr)
        {
            int index = 0;
            int index1 = 0;
            int maxElement = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (maxElement <= arr[i, j])
                    {
                        maxElement = arr[i, j];
                        index = i;
                        index1 = j;
                    }
                }
            }
            Console.WriteLine($"Index max element: [{index},{index1}]");
            return maxElement;
        }

        private static int CounterNeighborMax(int[,] arr)
        {
            int counter = 0;
            int[] arr1 = new int[arr.Length];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr1[i * arr.GetLength(0) + j] = arr[i, j];
                }
            }
            if (arr1[0] > arr1[1])
            {
                counter++;
            }
            if (arr1[arr1.Length - 1] > arr1[arr1.Length - 2])
            {
                counter++;
            }
            for (int i = 1; i < arr1.Length - 1; i++)
            {
                if (arr1[i] > arr1[i - 1] && arr1[i] > arr1[i + 1])
                {
                    counter++;
                }
            }
            return counter;
        }

        private static string WordsConstructor(int number)
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
        private static void TextToNumber() 
        {
            string number = Console.ReadLine();
            string[] number1 = number.Split(" ");


            string[] hundred = new string[10] {"", "one hundred", "two hundred", "three hundred", "four hundred", "five hundred", "six hundred", "seven hundred", "eight hundred", "nine hundred" };

            string[] dozens = new string[10] { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            string[] singles = new string[10] { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            string[] units = new string[10] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

            bool flag = true;
            int result = 0;

            if (number1.Length == 4 || number1.Length == 3)
            {
                for (int i = 0; i < hundred.Length; i++)
                {

                    if ((number1[0] + " " + number1[1]) == hundred[i])
                    {
                        result += i * 100;
                    }

                    else if (number1[2] == dozens[i] || number1[2] == units[i])
                    {
                        if (number1[2] == units[i])
                        {
                            result += i + 10;
                            flag = false;
                        }
                        else
                        {
                            result += i * 10;
                        }
                    }

                    if (number1.Length == 4)
                    {
                        if (number1[3] == singles[i] && flag == true)
                        {
                            result += i;
                        }
                    }
                }
                Console.WriteLine($"{result}");
            }
        }
    } 
}

