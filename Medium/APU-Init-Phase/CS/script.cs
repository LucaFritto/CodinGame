using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Player
{
    static string Hor(int[,] arr, int i, int j){
        if (arr[i,j] == 1) return(i.ToString()+" "+j.ToString()+" ");
        else if(arr[i,j] == 0) return((-1).ToString()+" "+(-1).ToString()+" ");
        else return Hor(arr,i+1,j);
    }
    static string Ver(int[,] arr, int i, int j){
        if (arr[i,j] == 1) return(i.ToString()+" "+j.ToString()+" ");
        else if(arr[i,j] == 0) return((-1).ToString()+" "+(-1).ToString()+" ");
        else return Ver(arr,i,j+1);
    }
    static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine()); // the number of cells on the X axis
        int height = int.Parse(Console.ReadLine()); // the number of cells on the Y axis
        int[,] nodes = new int[width+1,height+1];
        for (int i = 0; i < height; i++)
        {
            int j =0;
            string line = Console.ReadLine(); // width characters, each either 0 or .
            foreach(char value in line) {
                if (value == '0') nodes[j,i] = 1;
                else nodes[j,i] = -1;
                j++;
            }
        }
        for (int j=0;j<height;j++) {
            string result = String.Empty;
            for(int i=0;i<width;i++) {
                if (nodes[i,j] == 1) result+= i.ToString()+" "+j.ToString()+" ";
                else continue;
                result += Hor(nodes,i+1,j);
                result += Ver(nodes,i,j+1);
                Console.WriteLine(result.Substring(0,result.Length-1));
                result = String.Empty;
            }
        }
    }
}
