//213047
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        IList<int> intList = new List<int>() { 10, 20, 30, 40 };

        foreach (var element in intList)
        {
            Console.WriteLine(element);
        }
    }
}
