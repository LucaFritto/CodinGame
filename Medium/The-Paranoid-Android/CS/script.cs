using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Player {
    static void Main(string[] args) {
        string[] inputs = Console.ReadLine().Split(' ');
        //inputs = Console.ReadLine().Split(' ');
        int exitPos = int.Parse(inputs[4]);
        int nbElevators = int.Parse(inputs[7]);
        int[] Elevators = new int[nbElevators+1];
        for (int i = 0; i < nbElevators; i++) {
            inputs = Console.ReadLine().Split(' ');
            Elevators[int.Parse(inputs[0])] = int.Parse(inputs[1]);
        }
        Elevators[nbElevators] = exitPos;
        while (true) {   
            inputs = Console.ReadLine().Split(' ');
            int cloneFloor = int.Parse(inputs[0]);
            int clonePos = int.Parse(inputs[1]);
            string direction = inputs[2]; 
            if (clonePos != -1) {
                if (clonePos-Elevators[cloneFloor] < 0 && direction == "LEFT"){
                    Console.WriteLine("BLOCK");
                } else if (clonePos-Elevators[cloneFloor] > 0 && direction == "RIGHT") {
                    Console.WriteLine("BLOCK");
                } else {
                    Console.WriteLine("WAIT");
                }
            } else {
                Console.WriteLine("WAIT");
            }
        }
    }
}
