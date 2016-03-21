# File           : readMultiNumbers.cs
# Author         : Shree Harsha Sridharamurthy
# Author email   : s.shreeharsha@gmail.com
# Disclaimer     : For use by concerned personnel only. Released under MIT License - permitted to use this but need to quote the source origin.
# Program        : Solution for hackerrank question posted here:https:https://www.hackerrank.com/challenges/a-very-big-sum
/*# Details        : Read multiple pairs of integers and print the sum of each pair.

Sample Input

3
1 2
3 5
4 6
Sample Output

3
8
10
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        //int n = Convert.ToInt32(Console.ReadLine());
        Console.ReadLine();//just read and don't use anywhere (ignore)
        string[] arr_temp = Console.ReadLine().Split(' ');
        long[] arr = Array.ConvertAll(arr_temp,Int64.Parse);
        long sum = 0;
        for(int i=0;i<arr.Length;i++){
            sum += arr[i];
        }
        Console.WriteLine(sum);
    }
}
