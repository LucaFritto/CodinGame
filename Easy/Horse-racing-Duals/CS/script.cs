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
    static void MergeSort(int[] inputArray)
    {
        int left = 0;
        int right = inputArray.Length - 1;
        InternalMergeSort(inputArray, left, right);
    }
    static void InternalMergeSort(int[] inputArray, int left, int right)
    {
        int mid = 0;
        if (left < right)
        {
            mid = (left + right) / 2;
            InternalMergeSort(inputArray, left, mid);
            InternalMergeSort(inputArray,(mid + 1), right);
            MergeSortedArray(inputArray, left, mid, right);
        }
    }
    static void MergeSortedArray(int[] inputArray, int left, int mid, int right)
    {
        int index = 0;
        int total_elements = right-left+1; //BODMAS rule
        int right_start = mid + 1;
        int temp_location = left;
        int[] tempArray = new int[total_elements];
    
        while ((left <= mid) && right_start <= right)
        {
            if (inputArray[left] <= inputArray[right_start])
            {
                tempArray[index++] = inputArray[left++];
            }
            else
            {
                tempArray[index++] = inputArray[right_start++];
            }
        }
        if (left > mid)
        {
            for(int j = right_start; j <= right; j++)
                tempArray[index++] = inputArray[right_start++];
        }
        else
        {
            for(int j = left; j <= mid; j++)
                tempArray[index++] = inputArray[left++];
        }
        for (int i = 0, j = temp_location; i < total_elements; i++, j++)
        {
            inputArray[j] = tempArray[i];
        }
    }
    
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] pi = new int[N];
        int difference=10000000;
        for (int i = 0; i < N; i++)
        {
            pi[i] = int.Parse(Console.ReadLine());
        }
        MergeSort(pi);
        for (int i=0;i<N-1;i++) {
            if ((pi[i+1]-pi[i]) < difference)
                difference = pi[i+1]-pi[i];
        }
        Console.WriteLine(difference);
    }
}
