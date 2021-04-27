using System;

namespace HW_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Lecturer lector = new Lecturer("Tetyana", "Zayzeva", 30, "Lector", 50);
            Console.WriteLine("Lector information:");
            lector.GetInfo();
            lector.GetSpecific();
            Decan decan = new Decan("Ivan","Ivanovich", 45, "Decan", 125);
            Console.WriteLine("\n Decan information:");
            decan.GetInfo();
            decan.GetSpecific();
            Rector rector = new Rector("Natalia", "Guk", 55, "Rector", 425);
            Console.WriteLine("\n Rector information:");
            rector.GetInfo();
            rector.GetSpecific();
            Student student = new Student("Pavel", "Rodionov", 21);
            Console.WriteLine("\n Student information:");
            student.GetInfo();
            student.GetSpecific();
            Student student1 = new Student("Maria", "Morozova", 19);
            Console.WriteLine("\n Student information:");
            student1.GetInfo();
            student1.GetSpecific();
        }
    }
}
