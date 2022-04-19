using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace zaliczenie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers would you like to process?");
            int numbersCount = Convert.ToInt32(Console.ReadLine());

            string fileName = "primeNumbers" + Convert.ToString(numbersCount) + ".txt";
            using StreamWriter file = new StreamWriter(@fileName);

            Stopwatch sw = new Stopwatch();
            sw.Start();

            List<int> primeNumbers = new LinearSieve(numbersCount).GetResult();

            sw.Stop();

            primeNumbers.ForEach(n => file.WriteLine(Convert.ToString(n)));
            Console.WriteLine("Time of the execution: " + sw.ElapsedMilliseconds + " ms");
        }
    }
}
