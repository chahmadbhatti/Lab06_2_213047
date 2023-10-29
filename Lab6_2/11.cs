//213047
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> intList = new List<int> { 10, 20, 30, 40, 50 };
        bool res = intList.TrueForAll(el => el % 2 == 0);
        Console.WriteLine("All elements are even: " + res);
    }
}
