/*
# File           : diagonalDifference.cs
# Author         : Shree Harsha Sridharamurthy
# Author email   : s.shreeharsha@gmail.com
# Disclaimer     : For use by concerned personnel only. Released under MIT License - permitted to use this but need to quote the source origin.
# Program        : Solution for hackerrank question posted here:https://www.hackerrank.com/challenges/angry-professor
# Description    : A Discrete Mathematics professor has a class of N students. Frustrated with their lack of discipline, he decides to cancel class if fewer than K students are present when class starts.

Given the arrival time of each student, determine if the class is canceled.

Input Format

The first line of input contains T, the number of test cases.

Each test case consists of two lines. The first line has two space-separated integers, N (students in the class) and K (the cancelation threshold). 
The second line contains NN space-separated integers (a1,a2,…,aN) describing the arrival times for each student.

Note: Non-positive arrival times (ai≤0) indicate the student arrived early or on time; positive arrival times (ai>0) indicate the student arrived aiai minutes late.

Output Format

For each test case, print the word YES if the class is canceled or NO if it is not.

Constraints

1≤T≤10
1≤N≤1000
1≤K≤N
−100≤ai≤100,where i∈[1,N]−
Note 
If a student arrives exactly on time (ai=0), the student is considered to have entered before the class started.

Sample Input

2
4 3
-1 -3 4 2
4 2
0 -1 2 1
Sample Output

YES
NO
Explanation:

For the first test case, K=3. The professor wants at least 33 students in attendance, but only 2 have arrived on time (−3 and −1). Thus, the class is canceled.
For the second test case, K=2. The professor wants at least 22 students in attendance, and there are 2 who have arrived on time (0 and −1). Thus, the class is not canceled.

*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int testCount = 0; testCount < t; testCount++){
            string[] nAndk = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(nAndk[0]); 
            int k = Convert.ToInt32(nAndk[1]);
            
            string[] studentsStr = Console.ReadLine().Split(' ');
            int[] students = Array.ConvertAll(studentsStr,Int32.Parse);
            
            if(k>n){
                Console.WriteLine("YES");
            }
            else{
                int goodCount = 0;
                for(int i=0;i<n;i++){
                    if(students[i] <= 0){
                        goodCount++;                        
                    }
                }
                //Console.WriteLine(goodCount+","+k);
                if(goodCount >= k){
                    Console.WriteLine("NO");
                }
                else{
                    Console.WriteLine("YES");
                }
            }                
        }
    }
}
