# File           : FindIndex.cs
# Author         : Shree Harsha Sridharamurthy
# Author email   : s.shreeharsha@gmail.com
# Disclaimer     : For use by concerned personnel only. Released under MIT License - permitted to use this but need to quote the source origin.
# Program        : Solution for hackerrank question posted here: https://www.hackerrank.com/challenges/tutorial-intro
/*
Sample program to find index of an array having the given value 
*/


//Program Start

using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        string V = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        string[] inArr = Console.ReadLine().Split(' ');
        int index = -1;
        
        for(int i = 0; i < n; i++){
            if(inArr[i] == V){
                index = i;
                break; //stop if found: increases average case performance from O(n) to O(n-k) where k is the index at successful match
            }
        }        
        Console.WriteLine(index);
    }
}
