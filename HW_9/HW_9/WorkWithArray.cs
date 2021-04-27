using System;
using System.Collections.Generic;
using System.Text;

namespace HW_9
{
    public class WorkWithArray
    {
        private int[] _arr;//= new int[] { };

        public WorkWithArray()
        {
            Console.WriteLine("Введите размер массива n");
            int n = Convert.ToInt32(Console.ReadLine());

            _arr = new int[n];
            Console.WriteLine("Введите элементы массива");

            for (int i = 0; i < _arr.GetLength(0); i++)
            {
                Console.WriteLine("Введите следующий элемент:");
                _arr[i] = int.Parse(Console.ReadLine());
            }
            //Print();
        }
        public WorkWithArray(int[] arr) 
        {
            _arr = new int[arr.Length];

            for (int i = 0; i<_arr.Length;i++) 
            {
                _arr[i] = arr[i];
            }
        }
        public int[] GetArr()
        {
            return _arr;
        }
        public void Print()
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                Console.Write($"{_arr[i]} ");
            }
            Console.WriteLine();
        }

        public void AddElement()
        {
            Console.WriteLine("Enter element wich you want to add:");
            int j = int.Parse(Console.ReadLine());
            int[] _arr1 = new int[_arr.Length + 1];
            for (int i = 0; i < _arr.Length; i++)
            {
                _arr1[i] = _arr[i];
            }
            _arr1[_arr.Length] = j;
            _arr = _arr1;
            //Print();
        }
        public void AddElement(int value)
        {        
            int[] _arr1 = new int[_arr.Length + 1];
            
            for (int i = 0; i < _arr1.Length-1; i++)
            {
                _arr1[i] = _arr[i];
            } 

            _arr1[_arr1.Length-1] = value;
            _arr = _arr1;
   
        }

        public void DeleteElement()
        {
            Console.WriteLine("Enter index of element wich you want to delete:");
            int j = int.Parse(Console.ReadLine());
            DeleteElement(j);
            //Print();
        }
        public void DeleteElement(int j)
        {
            int[] _arr1 = new int[_arr.Length - 1];
            for (int i = 0; i < j; i++)
            {
                _arr1[i] = _arr[i];
            }
            for (int i = j + 1; i < _arr.Length; i++)
            {
                _arr1[i - 1] = _arr[i];
            }
            _arr = _arr1;
            //Print();
        }

        public void ClearArray()
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                _arr[i] = 0;
            }
            //Print();
        }

        public void SortArray()
        {
            int temp;
            for (int i = 0; i < _arr.Length; i++)
            {
                for (int j = 0; j < _arr.Length - 1; j++)
                {
                    if (_arr[j] < _arr[j + 1])
                    {
                        temp = _arr[j + 1];
                        _arr[j + 1] = _arr[j];
                        _arr[j] = temp;
                    }
                }
            }
            //Print();
        }
    }
}
