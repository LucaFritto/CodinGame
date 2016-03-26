using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        double min = 0;
        double max = 0;
        int n = int.Parse(Console.ReadLine());
        string[] inputs = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            int v = int.Parse(inputs[i]);
            if (v > max) max = v;
            else if(max-v > min)    min = max-v;
            
        }
        Console.Write(-min);
    }
}
