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
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        string T = Console.ReadLine();
        string result = "";
        char[] Tchar = T.ToCharArray();
        char[] Trow = new char[26*L];
        for (int i = 0; i < H; i++)
        {
            string ROW = Console.ReadLine();
            
            Trow = ROW.ToCharArray();
            foreach (char element in Tchar) {
                switch (element) {
                    case 'a':
                    case 'A':
                        for (int j=0; j<L;j++) result += Trow[j];
                        break;
                    case 'b':
                    case 'B':
                        for (int j=L; j<L*2;j++) result += Trow[j];
                        break;
                    case 'c':
                    case 'C':
                        for (int j=L*2; j<L*3;j++) result += Trow[j];
                        break;
                    case 'd':
                    case 'D':
                        for (int j=L*3; j<L*4;j++) result += Trow[j];
                        break;
                    case 'e':
                    case 'E':
                        for (int j=L*4; j<L*5;j++) result += Trow[j];
                        break;
                    case 'f':
                    case 'F':
                        for (int j=L*5; j<L*6;j++) result += Trow[j];
                        break;
                    case 'g':
                    case 'G':
                        for (int j=L*6; j<L*7;j++) result += Trow[j];
                        break;
                    case 'h':
                    case 'H':
                        for (int j=L*7; j<L*8;j++) result += Trow[j];
                        break;
                    case 'i':
                    case 'I':
                        for (int j=L*8; j<L*9;j++) result += Trow[j];
                        break;
                    case 'j':
                    case 'J':
                        for (int j=L*9; j<L*10;j++) result += Trow[j];
                        break;
                    case 'k':
                    case 'K':
                        for (int j=L*10; j<L*11;j++) result += Trow[j];
                        break;
                    case 'l':
                    case 'L':
                        for (int j=L*11; j<L*12;j++) result += Trow[j];
                        break;
                    case 'm':
                    case 'M':
                        for (int j=L*12; j<L*13;j++) result += Trow[j];
                        break;
                    case 'n':
                    case 'N':
                        for (int j=L*13; j<L*14;j++) result += Trow[j];
                        break;
                    case 'o':
                    case 'O':
                        for (int j=L*14; j<L*15;j++) result += Trow[j];
                        break;
                    case 'p':
                    case 'P':
                        for (int j=L*15; j<L*16;j++) result += Trow[j];
                        break;
                    case 'q':
                    case 'Q':
                        for (int j=L*16; j<L*17;j++) result += Trow[j];
                        break;
                    case 'r':
                    case 'R':
                        for (int j=L*17; j<L*18;j++) result += Trow[j];
                        break;
                    case 's':
                    case 'S':
                        for (int j=L*18; j<L*19;j++) result += Trow[j];
                        break;
                    case 't':
                    case 'T':
                        for (int j=L*19; j<L*20;j++) result += Trow[j];
                        break;
                    case 'u':
                    case 'U':
                        for (int j=L*20; j<L*21;j++) result += Trow[j];
                        break;
                    case 'v':
                    case 'V':
                        for (int j=L*21; j<L*22;j++) result += Trow[j];
                        break;
                    case 'w':
                    case 'W':
                        for (int j=L*22; j<L*23;j++) result += Trow[j];
                        break;
                    case 'x':
                    case 'X':
                        for (int j=L*23; j<L*24;j++) result += Trow[j];
                        break;
                    case 'y':
                    case 'Y':
                        for (int j=L*24; j<L*25;j++) result += Trow[j];
                        break;
                    case 'z':
                    case 'Z':
                        for (int j=L*25; j<L*26;j++) result += Trow[j];
                        break;
                    /*case '@':
                    case ',':
                        for (int j=L*26; j<L*27;j++) result += Trow[j];
                        break;f
                    default:
                        break;*/
                    default:
                        for (int j=L*26; j<L*27;j++) result += Trow[j];
                        break;
                }
            }
        result += "\n";
        }
    Console.WriteLine(result);
    }
}
