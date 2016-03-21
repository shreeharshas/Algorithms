# File           : readMultiNumbers.cs
# Author         : Shree Harsha Sridharamurthy
# Author email   : s.shreeharsha@gmail.com
# Disclaimer     : For use by concerned personnel only. Released under MIT License - permitted to use this but need to quote the source origin.
# Program        : Solution for hackerrank question posted here:https:https://www.hackerrank.com/challenges/read-multiple-lines-input
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
class Solution {
  static void Main(String[] args) {
    int numberOfLines;
    int firstNum;
    int secondNum;
    int sum;
        
    numberOfLines = Int32.Parse(Console.ReadLine());
        
    while (numberOfLines > 0) {
        string[] nums = Console.ReadLine().Split(' ');
        firstNum = Int32.Parse(nums[0]);
        secondNum = Int32.Parse(nums[1]);            
        sum = firstNum + secondNum;            
        Console.WriteLine(sum);
        numberOfLines = numberOfLines - 1;
    }
  }
}
