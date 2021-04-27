using System;

namespace HW_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-4
            //Task1();

            //5
            //Sum();

            //6
            //int[] arr = ArrayInput();
            //arr = Revers(arr);
            //ArrayOutput(arr);

            //7
            //Quantity();

            //8
            int[] arr = ArrayInput();
            arr = HalfSort(arr);
            ArrayOutput(arr);

            //9
            //int[] arr = ArrayInput();
            //arr = SelectSort(arr);
            //ArrayOutput(arr);

            //10
            //int[] arr = ArrayInput();
            //arr = BubbleSort(arr);
            //ArrayOutput(arr);
        }
        private static int[] ArrayInput()
        {
            int size;

            Console.WriteLine("Enter array size");

            while (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("Incorrect input");
            }

            while (size < 0)
            {
                Console.WriteLine("Incorrect input");
                ArrayInput();
            }

            int[] arr = new int[size];

            arr = FillArrayRandom(arr, 0, 10);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }

            Console.WriteLine();

            return arr;
        }
        private static int[] FillArrayRandom(int[] array, int min, int max)
        {
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(min, max);
            }
            return array;
        }

        private static void ArrayOutput(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
        }

        private static void Task1()
        {
            int[] arr = ArrayInput();
            int min = arr[0];
            int max = arr[0];
            int minindex = 0;
            int maxindex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    maxindex = i;
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                    minindex = i;
                }
            }
            Console.WriteLine($"Max element in array: {max}");
            Console.WriteLine($"Min element in array: {min}");
            Console.WriteLine($"Index of max element in array: {maxindex}");
            Console.WriteLine($"index of min element in array: {minindex}");
        }

        private static void Sum()
        {
            int[] arr = ArrayInput();
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + arr[i];
                }
            }
            Console.WriteLine($"Sum of array elements with odd indices = {sum}");
        }
        private static int[] Revers(int[] arr)
        {
            int tmp = 0;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int j = arr.Length - 1;
                while (i < j)
                {
                    tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                    i++;
                    j--;
                }
            }
            return arr;
        }
        private static void Quantity()
        {
            int[] arr = ArrayInput();
            int quantity = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    quantity++;
                }
            }
            Console.WriteLine($"Quantity of odd elements in the array: {quantity}");
        }

        private static int[] HalfSort(int[] arr)
        {
            int len = arr.Length / 2;
            int pos = len + arr.Length % 2;
            for (int i = 0; i < len; i++)
            {
                int t = arr[i];
                arr[i] = arr[pos + i];
                arr[pos + i] = t;
            }
            return arr;
        }

        private static int[] BubbleSort(int[] arr)
        {
            int maxindex = arr[0];
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
        private static int[] SelectSort(int[] arr)
        {
            int minindex = arr[0];
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                minindex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minindex])
                    {
                        minindex = j;
                    }
                }
                temp = arr[minindex];
                arr[minindex] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }
    }

}
