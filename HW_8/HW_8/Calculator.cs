using System;
using System.Collections.Generic;
using System.Text;

namespace HW_8
{
    class Calculator
    {
        public static bool IsNumber(string number) 
        {      
            for (int i=0; i<number.Length;i++) 
            {
                if (!char.IsNumber(number[i]) && !(number[i] == ',')) 
                {
                    return false;
                }
            }
            return true;
        }
        private double Sum(double firstnumber, double secondnumber)
        {
            double number = firstnumber + secondnumber;
            return firstnumber + secondnumber;
        }

        private double Subtraction(double firstnumber, double secondnumber)
        {
            double number = firstnumber - secondnumber;
            return firstnumber - secondnumber;
        }

        private double Multiplication(double firstnumber, double secondnumber)
        {
            double number = firstnumber * secondnumber;
            return firstnumber * secondnumber;
        }

        private double Division(double firstnumber, double secondnumber)
        {        
            double number = firstnumber / secondnumber;
            return firstnumber / secondnumber;
        }

        public string Count(double firstnumber, double secondnumber, string operation)
        {
            string result = " ";
            switch (operation)
            {
                case "+":
                    result = $" {firstnumber} + {secondnumber} = {Sum(firstnumber, secondnumber)}";
                    break;
                case "-":
                    result = $"{firstnumber} - {secondnumber} = {Subtraction(firstnumber, secondnumber)}";
                    break;
                case "*":
                    result = $" {firstnumber} * {secondnumber} = {Multiplication(firstnumber, secondnumber)}";
                    break;
                case "/":
                    if (firstnumber != 0 & secondnumber != 0)
                    { 
                        result = $"{firstnumber} / {secondnumber} = {Division(firstnumber, secondnumber)}"; 
                    }
                    else if (secondnumber == 0)
                    {
                        Console.WriteLine("This operation can not be performed");
                        break;
                    }
                    break;
                default:
                    return "This operation can not be performed";
            }
            return result;
        }
    }
}
