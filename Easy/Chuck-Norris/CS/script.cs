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
        int flag =0;
        string result = "";
        string temp = "";
        string MESSAGE = Console.ReadLine();
        char[] message = MESSAGE.ToCharArray();
        //string[] message = new string[MESSAGE.Length];

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        foreach (char element in message) {
            if (Convert.ToString(element,2).Length < 7)
                for (int i=0; i<7-Convert.ToString(element,2).Length; i++) {
                temp += "0";
                }
            temp += Convert.ToString(element, 2);
            
        }
        char[] BinMessage = temp.ToCharArray();
        char[] pila = new char[BinMessage.Length];
        int testa = 1;
        pila[0] = BinMessage[0];
        if(pila[0] == '0')  flag = 0;
        else    flag = 1;
        for (int i=1; i<BinMessage.Length; i++) {
            if(BinMessage[i] == pila[testa-1]) {
                pila[testa] = BinMessage[i];
                testa++;
            } else {
                if (flag == 0)  result += "00 ";
                else    result += "0 ";
                for (int j=testa; j>0; j--) {
                    result += "0";
                }
                result += " ";
                testa = 1;
                pila[0] = BinMessage[i];
                if(pila[0] == '0')  flag = 0;
                else    flag = 1;
            }
        }
    if (flag == 0)  result += "00 ";
    else    result += "0 ";
    for (int j=testa; j>0; j--) {
        result += "0";
    }
    Console.WriteLine(result);
    }
}
