using System;

namespace FacadePattern.Models
{
    public class Student
    {
        private int _id { get; }

        public Student(int id)
        {
            _id = id;
        }

        public bool Submit(Coursework coursework)
        {
            Console.WriteLine($"Coursework from {coursework.ModuleCode} has been submitted!");
            return true;
        }
    }
}
