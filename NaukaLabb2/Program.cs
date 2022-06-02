using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Person
    {
        protected string name { get; set; }
        protected int age { get; set; }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   name == person.name &&
                   age == person.age;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }

    class Teacher : Person
    {
        public Teacher(string name, int age) : base(name, age)
        {
            this.name = name;
            this.age = age;
        }

        protected string name { get; set; }
        protected int age { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    class Student : Person
    {
        protected string group { get; set; }
        protected List<Task> tasks;

        public Student(string name, int age, string group) : base(name, age)
        {
            this.group = group;
            this.name = name;
            this.age = age;

        }

        public Student(string name, int age, string group, List<Task> tasks) : base(name, age)
        {
            this.group = group;
            this.name = name;
            this.age = age;
            this.tasks = tasks;
        }

        public void AddTask(string taskName, Task.TaskStatus taskstatus)
        {
            Task tas = new Task(taskName, taskstatus);

            tasks.Add(tas);
        }

        public void RemoveTask(int index)
        {
            tasks.RemoveAt(index);
        }

        public void UpdateTask(int index, Task.TaskStatus taskStatus)
        {

            Task zmienna = tasks[index];

            Task task1 = new Task(zmienna.name, taskStatus);

            tasks[index] = task1;
        }

        public string RenderTask(string prefix = "\t")
        {
            string a = "";
            foreach (Task zmiinna in tasks)
            {
                a += zmiinna.name;
            }
            return a;
        }

        private bool SequenceEqual(List<Task> a, List<Task> b)
        {
            return a.SequenceEqual(b);
        }


    }

    public class Task
    {
        public Task(string name, TaskStatus status)
        {
            this.name = name;
            this.status = status;
        }

        public string name { get; set; }
        public TaskStatus status { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Task task &&
                   name == task.name &&
                   status == task.status;
        }

        public enum TaskStatus
        {
            Waiting,
            Progress,
            Done,
            Rejected,
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }


}
