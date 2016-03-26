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
class Player
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int W = int.Parse(inputs[0]); // width of the building.
        int H = int.Parse(inputs[1]); // height of the building.
        int N = int.Parse(Console.ReadLine()); // maximum number of turns before game over.
        inputs = Console.ReadLine().Split(' ');
        int X0 = int.Parse(inputs[0]);
        int Y0 = int.Parse(inputs[1]);
        int minX = 0, minY = 0, maxX = W, maxY = H;

        // game loop
        while (true)
        {
            string BOMBDIR = Console.ReadLine(); // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)
            switch(BOMBDIR) {
                case "U":
                    maxY = Y0;
                    Y0 = (int)Math.Round((double)((Y0+minY)/2));
                    break;
                case "UR":
                    maxY = Y0;
                    minX = X0;
                    Y0 = (int)Math.Round((double)(Y0+minY)/2);
                    X0 = (int)Math.Round((double)(X0 + maxX)/2);
                    break;
                case "R":
                    minX = X0;
                    X0 = (int)Math.Round((double)(X0 + maxX)/2);
                    break;
                case "DR":
                    minY = Y0;
                    minX = X0;
                    Y0 = (int)Math.Round((double)(Y0 + maxY)/2);
                    X0 = (int)Math.Round((double)(X0 + maxX)/2);
                    break;
                case "D":
                    minY = Y0;
                    Y0 = (int)Math.Round((double)(Y0 + maxY)/2);
                    break;
                case "DL":
                    minY = Y0;
                    maxX = X0;
                    Y0 = (int)Math.Round((double)(Y0 + maxY)/2);
                    X0 = (int)Math.Round((double)(X0+minX)/2);
                    break;
                case "L":
                    maxX = X0;
                    X0 = (int)Math.Round((double)(X0+minX)/2);
                    break;
                case "UL":
                    maxX = X0;
                    maxY = Y0;
                    Y0 = (int)Math.Round((double)(Y0+minY)/2);
                    X0 = (int)Math.Round((double)(X0+minX)/2);
                    break;
                default:
                    break;
            }
            Console.WriteLine(X0+" "+Y0);
        }
    }
}
