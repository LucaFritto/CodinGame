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
        /*string[] inputs = Console.ReadLine().Split(' ');
        int L = int.Parse(inputs[0]);
        //Console.WriteLine(L);
        int C = int.Parse(inputs[1]);
        //Console.WriteLine(C);
        int N = int.Parse(inputs[2]);
        //Console.WriteLine(N);
        long money = 0;
        int group = 0;
        int postiVuoti = L;
        int[] groups = new int[N];
        for (int i = 0; i < N; i++)
        {
            groups[i] = int.Parse(Console.ReadLine());
            if (postiVuoti < groups[i]) {
                C--;
                postiVuoti = L;
            }  
            if (C == 0)
                break;
            money+=groups[i];
            postiVuoti-=groups[i]; 
        }
        if(money < L) {
            C--;
            postiVuoti = L;
        }
        int difference = (int.Parse(inputs[1])-C);
        long total = money; 
        while (C-difference >= 0) {
            total+=money;
            if (postiVuoti*2>L) {
                C -= (difference+1);
                postiVuoti = (L*2)-((L-postiVuoti)*2);
                continue;
            }
            C -= difference;
        }
        money = total;
        for(int i=0;i<C;i++){
            while (postiVuoti >= groups[group]) {
                money+=groups[group];
                postiVuoti-=groups[group];
                group++;
                if (group == N)
                    break;
            }
            postiVuoti=L;
        }
            
        Console.WriteLine(money);*/
    }
}
