using System;
using System.Collections.Generic;
using System.Threading;


    public class Program
    {

        public static void Main(string[] args)
        {


            HashSet<int> primeNumbers = new HashSet<int>();

            bool looped = true;


            Thread thread1 = new Thread(() =>
            {
                Console.WriteLine("Started");

                for (int i = 0; looped; i++)
                {
                    if (czyPierwsza(i) == true)
                    {
                        primeNumbers.Add(i);
                    }
                }

                Console.WriteLine("Stopping");

            });

            Thread thread2 = new Thread(() =>
            {
                Console.WriteLine("Started");

                for (int i = 0; looped; i++)
                {
                    if (czyPierwsza(i) == true)
                    {
                        primeNumbers.Add(i);
                    }
                }

                Console.WriteLine("Stopping");

            });
            thread1.Start();

            thread2.Start();

            Thread.Sleep(10000);

            looped = false;

            thread1.Join();

            thread2.Join();

            Console.WriteLine("Znaleziono " + primeNumbers.Count + " liczb pierwszych");

            static bool czyPierwsza(int j)
            {
                if (j < 2)
                {
                    return false;
                }
                if (j == 2)
                {
                    return true;
                }
                if (j % 2 == 0)
                {
                    return false;
                }
                for (int i = 3; i < j; i += 2)
                {
                    if (j % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            };


        }
    }
// Dziękuję za szansę przesłania zadania, otwarcie mówię że nie robiłem tego sam lecz z momocą kumpli z grupy 
