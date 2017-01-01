# File           : diagonalDifference.cs
# Author         : Shree Harsha Sridharamurthy
# Author email   : s.shreeharsha@gmail.com
# Disclaimer     : For use by concerned personnel only. Released under MIT License - permitted to use this but need to quote the source origin.
# Program        : Solution for hackerrank question posted here: https://www.hackerrank.com/challenges/diagonal-difference
/*
Given a square matrix of size N×NN×N, calculate the absolute difference between the sums of its diagonals.

Input Format

The first line contains a single integer, NN. The next NN lines denote the matrix's rows, with each line containing NN space-separated integers describing the columns.

Output Format

Print the absolute difference between the two sums of the matrix's diagonals as a single integer.

Sample Input

3
11 2 4
4 5 6
10 8 -12
Sample Output

15
Explanation

The primary diagonal is: 
11
      5
            -12

Sum across the primary diagonal: 11 + 5 - 12 = 4

The secondary diagonal is:
            4
      5
10
Sum across the secondary diagonal: 4 + 5 + 10 = 19 
Difference: |4 - 19| = 15
*/


//Program Start

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        for(int a_i = 0; a_i < n; a_i++){
           string[] a_temp = Console.ReadLine().Split(' ');
           a[a_i] = Array.ConvertAll(a_temp,Int32.Parse);
        }
        
        int d1Sum = 0, d2Sum = 0;
        for(int i=0;i<n;i++){
            d1Sum += a[i][i];
            d2Sum += a[i][n-1-i];
        }
        Console.WriteLine(Math.Abs(d1Sum - d2Sum));
    }
}

//Program End
