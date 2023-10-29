//213047
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> intList = new List<int> { 10, 20, 30, 40 };
        intList.Remove(10);
        if (intList.Count > 2)
        {
            intList.RemoveAt(2);
        }
        foreach (var el in intList)
        {
            Console.WriteLine(el);
        }
    }
}
