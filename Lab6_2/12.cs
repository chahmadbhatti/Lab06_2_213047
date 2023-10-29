//213047
using System;
using System.Collections.Generic;

class Program
{
    static bool isPositiveInt(int i)
    {
        return i > 0;
    }

    static void Main(string[] args)
    {
        List<int> intList = new List<int>() { 10, 20, 30, 40 };
        bool res = intList.TrueForAll(isPositiveInt);
        Console.WriteLine("All elements are positive: " + res);
    }
}
