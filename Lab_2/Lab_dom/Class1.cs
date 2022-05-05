using System;
using System.Collections.Generic;

namespace Lab_02_Dom
{
    public class Program
    {
        public static void Main()
        {
            Seller treacher = new Seller("Jan Kowalski", 50);

            Buyer buyer1 = new Buyer("Jaś Fasola 1", 25);
            Buyer buyer2 = new Buyer("Jaś Fasola 2", 21);
            Buyer buyer3 = new Buyer("Jaś Fasola 3", 23);

            buyer1.AddProduct(new Fruit("Apple", 6));
            buyer1.AddProduct(new Meat("Fish", 0.5));

            Person[] persons = { treacher, buyer1, buyer2, buyer3 };

            Product[] products = {
                new Fruit("Apple", 1000),
                new Fruit("Banana", 700),
                new Fruit("Orange", 500),
                new Meat("Fish", 100.0),
                new Meat("Beef", 75.0)
            };

            Shop shop = new Shop("Super Market", persons, products);


        }
    }
    interface IThing
    {
        string Name { get; set; }
    }
    class Product
    {
        private string name { get; set; }

    }
    class Fruit : Product
    {
        public string name;
        private int Count { get; set; }

        public Fruit(string name, int Count)
        {
            this.name = name;
            this.Count = Count;
        }
    }
    class Meat : Product
    {
        public string name;
        public double weight;

        public Meat(string name, double weight)
        {
            this.name = name;
            this.weight = weight;
        }
    }
    class Person
    {
        private string name { get; set; }
        private int age { get; set; }
    }
    class Buyer : Person
    {
        List<Product> tasks = new List<Product>();
    }
    class Seller : Person
    {

    }
}