using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        //Create array of running sum. Total sum is last element of array. Then find element closest to sum / 2

        int[] cumulativeArray = new int[A.Length];
        cumulativeArray[0] = A[0];
        for(int i = 1; i < A.Length; i++)
        {
            cumulativeArray[i] = cumulativeArray[i - 1] + A[i];
        }

        int totalSum = cumulativeArray[A.Length - 1];

        //Loop through cum array until sum - cum is min. i.e. Until sum - cum gets larger than the previous.
        int minDiff = int.MaxValue;
        for(int i = 0; i < cumulativeArray.Length - 1; i++)
        {
            int diff = Math.Abs(totalSum - cumulativeArray[i] - cumulativeArray[i]);
            if(diff < minDiff)
            {
                minDiff = diff;
            }
            
        }
        return minDiff;
    }
}