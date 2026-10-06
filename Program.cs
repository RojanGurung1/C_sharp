using System;
using System.Collections.Generic;

namespace VariablesAndDatatypes
{
    class Program
    {
        static void Main()
        {
            // ---- Task 1: variables and interpolated strings ----
            string userName = "Rojan Gurung";
            int luckyNumber = 28;
            Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");

            // ---- Task 3: data types and type conversion ----
            byte tiny = 200;
            short small = 30000;
            int number = 1000000;
            long bigNumber = 10000000000;
            float pointNumber = 3.14f;
            double large = 3.14159265359;
            decimal money = 99.999999m;
            char letter = 'A';
            bool isTrue = true;

            string numberString = 42.ToString();
            double doubleString = double.Parse("3.14");

            Console.WriteLine($"byte   = {tiny}      (type: byte)");
            Console.WriteLine($"short  = {small}     (type: short)");
            Console.WriteLine($"int    = {number}     (type: int)");
            Console.WriteLine($"long   = {bigNumber} (type: long)");
            Console.WriteLine($"float  = {pointNumber} (type: float)");
            Console.WriteLine($"double = {large} (type: double)");
            Console.WriteLine($"decimal = {money} (type: decimal)");
            Console.WriteLine($"char   = {letter}     (type: char)");
            Console.WriteLine($"bool   = {isTrue}     (type: bool)");
            Console.WriteLine($"string = {numberString} (converted from int)");
            Console.WriteLine($"double = {doubleString} (converted from string)");

            // ---- Task 4: arrays and Array methods ----
            int[] numbers = { 42, 7, 19, 3, 88 };
            Console.WriteLine("Original: " + string.Join(", ", numbers));

            Array.Sort(numbers);
            Console.WriteLine("Sorted:   " + string.Join(", ", numbers));

            Array.Reverse(numbers);
            Console.WriteLine("Reversed: " + string.Join(", ", numbers));

            Console.WriteLine("\nIndexed values:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Index {i}: {numbers[i]}");
            }

            int pos19 = Array.IndexOf(numbers, 19);
            int pos100 = Array.IndexOf(numbers, 100);
            Console.WriteLine($"\nPosition of 19: {pos19}");
            Console.WriteLine($"Position of 100: {pos100}");

            // ---- Task 5: DateTime and TimeSpan ----
            DateTime birthDate = new DateTime(2004, 11, 25);
            DateTime today = DateTime.Now;
            TimeSpan ageSpan = today - birthDate;
            int years = (int)(ageSpan.TotalDays / 365.25);

            Console.WriteLine($"Birth date: {birthDate}");
            Console.WriteLine($"Today's date: {today}");
            Console.WriteLine($"Age in years: {years}");
            Console.WriteLine($"Birth date + 10 days: {birthDate.AddDays(10)}");

            // ---- Task 6: List<T> and Dictionary<K,V> ----
            List<string> fruits = new() { "Apple", "Banana", "Orange" };

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Dictionary<int, string> byId = new()
            {
                { 1, "Apple" },
                { 2, "Mango" },
                { 3, "Banana" },
                { 4, "Orange" }
            };

            foreach (var entry in byId)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }

            // Demo Circle usage
            Circle c = new Circle();
            double radius = 5;
            Console.WriteLine($"\nCircle with radius {radius}:");
            Console.WriteLine($"Area = {c.Area(radius)}");
            Console.WriteLine($"Perimeter = {c.Perimeter(radius)}");
        }
    }

    public class Circle
    {
        public const double PI = 3.14;

        public double Area(double radius)
        {
            return PI * radius * radius;
        }

        public double Perimeter(double radius)
        {
            return 2 * PI * radius;
        }
    }
}
