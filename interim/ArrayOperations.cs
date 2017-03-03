/*
Methods to left shift array arr of size n, d times
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    static void Main(String[] args) {
        string s = Console.ReadLine();
        int n = Convert.ToInt32(s.Split(' ')[0]);
        int d = Convert.ToInt32(s.Split(' ')[1]);
        
        string inputStr = Console.ReadLine();
        int[] arr= inputStr.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
        int[] arr2 = new int[arr.Length];
        for(int i=0;i<arr.Length;i++){
            int j = (i+d)%arr.Length;
            arr2[i] = arr[j];
        }
        
        for(int i=0;i<arr.Length;i++){
            arr[i] = arr2[i];
        }
        
        for(int i=0;i<arr.Length;i++){
            Console.Write(arr[i] + " ");
        }
    }
}
