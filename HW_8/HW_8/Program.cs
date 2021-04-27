using System;

namespace HW_8
{
    class Program
    {
        static void Main(string[] args)
        {  
            //1
            bool f = true;
            var calc = new Calculator();
            do
            {     
                Console.WriteLine("Enter first number:");
                string s = Console.ReadLine();
                if (s=="f")
                {
                    Console.WriteLine("I was glad to help!");
                    break;
                }
                while (!Calculator.IsNumber(s)) 
                {
                    Console.WriteLine("Try again");
                    s = Console.ReadLine();
                }
                double firstnumber = Convert.ToDouble(s);
                Console.WriteLine("Enter second number:");
                s = Console.ReadLine();
                while(!Calculator.IsNumber(s))
                {
                    Console.WriteLine("Try again");
                    s = Console.ReadLine();
                }
                double secondnumber = Convert.ToDouble(s);
                Console.WriteLine("Select operation '+' , '-' , '*' , '/':");
                string operation = Console.ReadLine().ToUpper();
                var num = calc.Count(firstnumber, secondnumber, operation);
                Console.WriteLine(num);
                Console.WriteLine("To exit press f");
              
            } while (f == true);


            //2
            //var array = new WorkWithArray();
            //array.AddElement();
            //array.DeleteElement();
            //array.SortArray();
            //array.ClearArray();
        }

    }
}
