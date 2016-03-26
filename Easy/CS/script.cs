using System;
using System.Linq;
using System.IO;
class Player
{
    static void Main(string[] args)
    {
        while (true)
        {
            int max=0;
            int imax=0;
            for (int i = 0; i < 8; i++)
            {
                int H = int.Parse(Console.ReadLine()); // represents the height of one mountain, from 9 to 0.
                if (H > max) {imax=i;max=H;}
            }
            Console.WriteLine(imax); // The number of the mountain to fire on.
        }
    }
}
