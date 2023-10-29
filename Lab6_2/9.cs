//213047
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> intList = new List<int> { 10, 20, 30, 40, 50 };
        intList.Insert(1, 11);

        foreach (var el in intList)
        {
            Console.Write(el);
        }
    }
}
