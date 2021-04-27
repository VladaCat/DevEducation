using System;
using System.Collections.Generic;
using System.Text;

namespace HW_10
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
 
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public abstract void GetInfo();
        //{
            //Console.WriteLine($"First Name = {FirstName}\n" + $"Last Name = {LastName}\n" + $"Age = {Age}\n");
        //}
    }
    public class Employee : Person
    {
        public string Experience { get; set; }
        public override void GetInfo()
        {
            Console.WriteLine($"Experience = {Experience}");
        }
        public Employee(string firstName, string lastName, int age, string experience):base(firstName, lastName, age)
        {
            Experience = experience;
        }
    }
    public class Lecturer : Employee, ILecturer
    {
        //private int lectures;

        public int Lectures { get; set; }
        public void GetSpecific()
        {
            Console.WriteLine("Teaching");
        }
        public Lecturer(string firstName, string lastName, int age, string experience, int lectures) : base(firstName, lastName, age, experience)
        {
            Lectures = lectures;
        }
        public new void GetInfo()
        {
            Console.WriteLine($"First Name = {FirstName}\n" + $"Last Name = {LastName}\n" + $"Age = {Age}\n" /*+ $"Quanty of lectures= {lectures}"*/);
        }
    }

    public class Decan : Employee, IDecan
    {
        //private int numberofseminar;

        public int NumberOfSeminar { get; set; }
        public void GetSpecific()
        {
            Console.WriteLine("Makes a schedule of lessons");
        }
        public Decan(string firstName, string lastName, int age, string experience, int numberofseminar):base(firstName, lastName, age, experience)
        {
            NumberOfSeminar = numberofseminar;
        }
        public new void GetInfo()
        {
            Console.WriteLine($"First Name = {FirstName}\n" + $"Last Name = {LastName}\n" + $"Age = {Age}\n" /*+ $"Quanty of seminars= {numberofseminar}"*/);
        }
    }
    sealed class Rector:Employee, IRector
    {
        //private int numberofprojects;

        public int NumberOfProjects { get; set; }
        public void GetSpecific()
        {
            Console.WriteLine("Guides the learning process");
        }
        public Rector(string firstName, string lastName, int age, string experience, int numberofprojects) : base(firstName, lastName, age, experience)
        {
            NumberOfProjects = numberofprojects;
        }
        public new void GetInfo()
        {
            Console.WriteLine($"First Name = {FirstName}\n" + $"Last Name = {LastName}\n" + $"Age = {Age}\n"/*+$"Quanty of projects= {numberofprojects}"*/);
        }
    }
    public class Student : Person
    {
        public Student(string firstName, string lastName, int age) : base(firstName, lastName, age) 
        {

        }
        public void GetSpecific()
        {
            Console.WriteLine("Learns");
            Console.WriteLine("Go to the auditory");
        }
        public override void GetInfo()
        {
            Console.WriteLine($"First Name = {FirstName}\n" + $"Last Name = {LastName}\n" + $"Age = {Age}\n");
        }
    }
}
