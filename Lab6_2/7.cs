//213047
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        numbers.Add(40);
        numbers.Add(50);
        int count = numbers.Count;

        Console.WriteLine("Accessing elements in the List using a for loop:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Element at index " + i + ": " + numbers[i]);
        }
    }
}
