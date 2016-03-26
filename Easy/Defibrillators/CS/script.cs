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
        string LON = Console.ReadLine();
        string LAT = Console.ReadLine();
        int N = int.Parse(Console.ReadLine());
        double[] distances = new double[N];
        string[] places = new string[N];
        double min;
        int imin=0;
        for (int i = 0; i < N; i++)
        {
            string DEFIB = Console.ReadLine();
            string[] input = DEFIB.Split(';');
            places[i] = input[1];
            double lonB = double.Parse(input[4].Replace(',','.'));
            double lonA = double.Parse(LON.Replace(',','.'));
            double latB = double.Parse(input[5].Replace(',','.'));
            double latA = double.Parse(LAT.Replace(',','.'));
            double x = (lonB-lonA)*(Math.Cos((latA+latB)/2));
            double y = (latB-latA);
            double d = Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2))*6371;
            distances[i] = d;
        }
        min = distances[0];
        for (int i=0; i<N;i++) {
            if (distances[i] < min){
                min = distances[i];
                imin = i;
            }
        }
        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(places[imin]);
    }
}
