# File           : savePrisoner.cs
# Author         : Shree Harsha Sridharamurthy
# Author email   : s.shreeharsha@gmail.com
# Disclaimer     : For use by concerned personnel only. Released under MIT License - permitted to use this but need to quote the source origin.
# Program        : Solution for hackerrank question posted here:https://www.hackerrank.com/contests/101hack35/challenges/save-the-prisoner
# Details        :
/*A jail has N prisoners, and each prisoner has a unique id number, S, ranging from 1 to N. There are M sweets that must be distributed to the prisoners.

The jailer decides the fairest way to do this is by sitting the prisoners down in a circle (ordered by ascending S), and then, starting with some random S, distribute one candy at a time to each sequentially numbered prisoner until all M candies are distributed. For example, if the jailer picks prisoner S=2, then his distribution order would be (2,3,4,5,…,n−1,n,1,2,3,4,…) until all MM sweets are distributed.

But wait—there's a catch—the very last sweet is poisoned! Can you find and print the ID number of the last prisoner to receive a sweet so he can be warned?

Input Format

The first line contains an integer, T, denoting the number of test cases. 
The T subsequent lines each contain 3 space-separated integers: 
N (the number of prisoners), M (the number of sweets), and S (the prisoner ID), respectively.

Constraints

1≤T≤1001≤T≤100
1≤N≤1091≤N≤109
1≤M≤1091≤M≤109
1≤S≤1091≤S≤109
Output Format

For each test case, print the ID number of the prisoner who receives the poisoned sweet on a new line.

Sample Input

1 
5 2 1
Sample Output

2
Explanation

There are N=5 prisoners and M=2 sweets. Distribution starts at ID number S=1, so prisoner 1 gets the first sweet and prisoner 2 gets the second (last) sweet. Thus, we must warn prisoner 2 about the poison, so we print 2 on a new line.
*/

using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int T = Convert.ToInt32(Console.ReadLine());
        
		//loop the number of test cases
		for(int x=0;x<T;x++){
            var str = Console.ReadLine();
            
            string[] strNums = str.Split(' ');
			//new integer array to hold the numbers
            int[] intNums = new int[strNums.Length];
            for(int k = 0; k < strNums.Length; k++){
                intNums[k] = Convert.ToInt32(strNums[k]);
            }
			//only three numbers as per the requirement so assigning directly
            int N = intNums[0];
            int M = intNums[1];
            int S = intNums[2];
            //main logic to obtain the solution
            S = (S + M) % N;
            int W = S - 1;//value obtained from previous step is higher by one so reducing it
            //return the number (W) to warn the prisoner, if 0, it is the maximum number
			Console.WriteLine(W==0?N:W);
        }        
    }
}
