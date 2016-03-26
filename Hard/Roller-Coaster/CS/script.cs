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
        string[] inputs = Console.ReadLine().Split(' ');
        Queue<int> coda = new Queue<int>();
        int L = int.Parse(inputs[0]);
        int C = int.Parse(inputs[1]);
        int N = int.Parse(inputs[2]);
        long money=0;
        int counter=0,element,position;
        for (int i = 0; i < N; i++)
        {
            coda.Enqueue(int.Parse(Console.ReadLine()));
        }
        while(C!=0) {
            position = coda.Count;
            while(position!=0) {
                element = coda.Peek();
                if (counter+element > L) {
                    money+=counter;
                    break;
                } else {
                    counter += element;
                    coda.Enqueue(coda.Dequeue());
                }
                position--;
            }
            C--;
            if(position == 0) {
                money+=counter;
                if ((C/N)>0) {
                    money += (money*(C-(C%N)));
                    C = C%N;
                }
            }
            counter=0;
        }
        Console.WriteLine(money);
    }
}
