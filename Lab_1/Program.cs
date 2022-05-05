
using System;

namespace Lab_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Ulamek ulamek = new Ulamek(1, 4);
            Ulamek ulamek2 = new Ulamek(3, 4);
            Ulamek ulamek3 = ulamek + ulamek2;
            Ulamek ulamek4 = ulamek3 - ulamek2;
            Ulamek ulamek5 = ulamek4 * ulamek;
            Ulamek ulamek6 = ulamek5 / ulamek2;

            Console.WriteLine(ulamek.ToString());
            Console.WriteLine(ulamek2.ToString());
            Console.WriteLine(ulamek3.ToString());
            Console.WriteLine(ulamek4.ToString());
            Console.WriteLine(ulamek5.ToString());
            Console.WriteLine(ulamek6.ToString());
        }

    }


    public class Ulamek : IEquatable<Ulamek>, IComparable<Ulamek>
    {
        private int licznik { get; }

        private int mianownik { get; }

        /// <summary>
        /// 
        /// </summary>

        public Ulamek()
        {

        }
        public Ulamek(int licznik, int mianownik)
        {
            this.licznik = licznik;
            this.mianownik = mianownik;
        }

        public Ulamek(Ulamek ulamek)
        {
            this.licznik = ulamek.licznik;
        }

        public static Ulamek operator +(Ulamek a, Ulamek b)
        {
            return new Ulamek(a.licznik * b.mianownik + b.licznik + b.mianownik, a.mianownik * b.mianownik);
        }
        public static Ulamek operator -(Ulamek a, Ulamek b)
        {
            return new Ulamek(a.licznik * b.mianownik - b.licznik + b.mianownik, a.mianownik * b.mianownik);
        }
        public static Ulamek operator *(Ulamek a, Ulamek b)
        {
            return new Ulamek(a.licznik * b.licznik, b.mianownik * a.mianownik);
        }
        public static Ulamek operator /(Ulamek a, Ulamek b)
        {
            if (b.licznik == 0)
            {
                throw new DivideByZeroException();
            }
            return new Ulamek(a.licznik * b.mianownik, a.mianownik * b.licznik);
        }
        public bool Equals(Ulamek other)
        {
            if (other == null) return false;
            if (other == this) return true;

            return Object.Equals(this.licznik, other.licznik) && Object.Equals(this.mianownik, other.mianownik);
        }
        public int CompareTo(Ulamek other)
        {
            if (other == null) return +1;
            if (other == this) return 0;

            int diff = this.mianownik - other.mianownik;
            if (diff > 0) return +1;
            if (diff < 0) return -1;

            return 0;
        }
        public override string ToString()
        {
            return licznik + "/" + mianownik;
        }

    }
}