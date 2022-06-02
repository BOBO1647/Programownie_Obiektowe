using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car auto1 = new Car();                         //Sprawdzenie działania ToString
            Car auto2 = new Car("audi ", 4, " red ");
            Car auto3 = new Car("bmw ", 4, " black ");
            //string zmienna = auto2.ToString(); 
            //Console.WriteLine(zmienna);
            //Console.ReadKey();

            ///////////////////////////////////////////////
            ///

            Console.WriteLine(auto2 + auto3);
            Console.WriteLine(auto2 - auto3);
            Console.WriteLine(auto2 * auto3);
            Console.WriteLine(auto2 / auto3);

            auto2.IleBrakuje();


            Console.WriteLine(auto3.Equals(auto2));

            //string[] lista = { auto1 , auto2 };

            Console.ReadKey();
        }
    }
    class Car : IEquatable<Car>, IComparable<Car>
    {
        private string brand { get; }
        private int tiresCount { get; }
        private string color { get; }

        public Car()
        {

        }

        public Car(string brand, int tiresCount, string color)
        {
            this.brand = brand;
            this.tiresCount = tiresCount;
            this.color = color;
        }

        public Car(Car car)
        {
            this.brand = car.brand;
            this.tiresCount = car.tiresCount;
            this.brand = car.brand;
        }

        public override string ToString()
        {
            return brand + tiresCount + color;
        }

        public void Odczytaj()
        {
            Console.WriteLine(ToString());
        }

        public bool Equals(Car other)
        {
            return tiresCount == other.tiresCount;
        }

        public int CompareTo(Car other)
        {
            return 0;
        }

        public static int operator +(Car auto2, Car auto3)
        {
            return auto2.tiresCount + auto3.tiresCount;
        }
        public static int operator -(Car auto2, Car auto3)
        {
            return auto2.tiresCount - auto3.tiresCount;
        }
        public static int operator *(Car auto2, Car auto3)
        {
            return auto2.tiresCount * auto3.tiresCount;
        }
        public static int operator /(Car auto2, Car auto3)
        {
            return auto2.tiresCount / auto3.tiresCount;
        }
        public void IleBrakuje()
        {
            Console.WriteLine(-(tiresCount - 8));
        }
    }
}
