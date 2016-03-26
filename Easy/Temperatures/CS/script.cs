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
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string temps = Console.ReadLine(); // the n temperatures expressed as integers ranging from -273 to 5526
        string[] Temps = temps.Split(' ');
        int[] tempsI = new int[n];
        int temp1, temp2;
        //int min=0;
        //int imin=0;
        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
        if (n>0) {
            for(int k = 0; k < n; k++){
                tempsI[k] = int.Parse(Temps[k]);
            }
            
            for (int i=0;i<n-1;i++){
                if (tempsI[i] < 0) 
                    temp1 = -tempsI[i];
                else
                    temp1 = tempsI[i];
                for (int j=i+1;j<n;j++){
                    if (tempsI[j] < 0)
                        temp2 = -tempsI[j];
                    else
                        temp2 = tempsI[j];
                    if (temp2 < temp1) {
                        int temp = tempsI[i];
                        tempsI[i] = tempsI[j];
                        tempsI[j] = temp;
                        temp = temp1;
                        temp1 = temp2;
                        temp2 = temp;
                    } else if (temp2 == temp1) {
                        if (tempsI[i] < tempsI[j]){
                            int temp = tempsI[i];
                            tempsI[i] = tempsI[j];
                            tempsI[j] = temp;
                            temp = temp1;
                            temp1 = temp2;
                            temp2 = temp;
                        } 
                    }
                }
            }
            Console.WriteLine(tempsI[0].ToString());
        } else {
            Console.WriteLine("0");
        }
    }
}
