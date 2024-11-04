using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // generate a list of random numbers
        Random random = new Random();
        List<int> numbers = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            numbers.Add(random.Next(-50, 50)); // add random number between -50 and 50
        }

        // print list
        Console.WriteLine("Oluşturulan Liste:");
        numbers.ForEach(n => Console.Write(n + " "));
        Console.WriteLine("\n");

        // even numbers
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Çift Sayılar:");
        foreach (var num in evenNumbers) Console.Write(num + " ");
        Console.WriteLine("\n");

        // odd numbers
        var oddNumbers = numbers.Where(n => n % 2 != 0);
        Console.WriteLine("Tek Sayılar:");
        foreach (var num in oddNumbers) Console.Write(num + " ");
        Console.WriteLine("\n");

        // negatives numbers
        var negativeNumbers = numbers.Where(n => n < 0);
        Console.WriteLine("Negatif Sayılar:");
        foreach (var num in negativeNumbers) Console.Write(num + " ");
        Console.WriteLine("\n");

        // positive numbers
        var positiveNumbers = numbers.Where(n => n > 0);
        Console.WriteLine("Pozitif Sayılar:");
        foreach (var num in positiveNumbers) Console.Write(num + " ");
        Console.WriteLine("\n");

        // numbers greater than 15 and less than 22
        var rangeNumbers = numbers.Where(n => n > 15 && n < 22);
        Console.WriteLine("15'ten Büyük ve 22'den Küçük Sayılar:");
        foreach (var num in rangeNumbers) Console.Write(num + " ");
        Console.WriteLine("\n");

        // square each number in the list
        var squares = numbers.Select(n => n * n);
        Console.WriteLine("Listedeki Sayıların Kareleri:");
        foreach (var square in squares) Console.Write(square + " ");
    }
}
