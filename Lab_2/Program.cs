using System;
using System.Collections.Generic;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher treacher = new Teacher("Maria Skłodowska", 50);

            Student student1 = new Student("Jan Kowaslski", 21, "LAB-01");
            Student student2 = new Student("Jan Kowaslski", 21, "LAB-01");
            Student student3 = new Student("Jaś Fasola", 23, "LAB-02");

            student1.AddTask("Taks A", TaskStatus.Waiting);
            student1.AddTask("Taks B", TaskStatus.Waiting);
            student1.AddTask("Taks C", TaskStatus.Rejected);

            student2.AddTask("Taks A", TaskStatus.Waiting);
            student2.AddTask("Taks B", TaskStatus.Waiting);
            student2.AddTask("Taks C", TaskStatus.Rejected);

            student3.AddTask("Taks D", TaskStatus.Done);
            student3.AddTask("Taks E", TaskStatus.Waiting);
            student3.AddTask("Taks F", TaskStatus.Waiting);

            student3.UpdateTask(1, TaskStatus.Done);
            student3.UpdateTask(2, TaskStatus.Progress);

            Person[] persons = { treacher, student1, student2, student3 };
            Classroom classroom = new Classroom("Sala Komputerowa", persons);

            Console.WriteLine(classroom);

            Console.WriteLine("student1 == student2: " + student1.Equals(student2)); // Output: student1 == student2: true
            Console.WriteLine("student1 == student3: " + student1.Equals(student3)); // Output: student1 == student3: false
        }
    }
    class Person
    {
        protected string name { get; set; }
        protected int age { get; set; }
        public string Tostring()
        {
            return "name: " + name + "age: " + age;
        }

    }
    enum TaskStatus
    {
        Waiting,
        Progress,
        Done,
        Rejected,
    }
    class Task
    {

        private string name { get; set; }

        public override string ToString()
        {
            return "name " + name + "Status" + TaskStatus;
        }
    }
    class Student : Person
    {
        public static List<string> Lista(string taskName, string taskStatus)
        {
            List<string> Task = new List<string> { };
        }

        protected String group { get; set; }
        public Task AddTask { get; set; }

    }

    class Teacher : Person
    {

    }
    class Classroom : Student, Teacher
    {
        string name { get; set; }
        Person[] persons { get; set; }
    }

}