using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        string str = Console.ReadLine();
        int num = 0;
        bool[] chk = new bool[128];
        foreach (char c in str)
        {
            if (c >= 48 && c <= 57)
            {
                Console.WriteLine(c);
                num *= 10;
                num += c - '0';
            }


        }

        Console.WriteLine(response);
    }
}
