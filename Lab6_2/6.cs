using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> fruits = new List<string>();

        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Orange");
        fruits.Add("Mango");

        int count = fruits.Count;

        Console.WriteLine("Total number of elements in the List: " + count);
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Element at index " + i + ": " + fruits[i]);
        }
    }
}
