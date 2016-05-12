/* File           : FindIndex.cs
 Author         : Shree Harsha Sridharamurthy
 Author email   : s.shreeharsha@gmail.com
 Disclaimer     : For use by concerned personnel only. Released under MIT License - permitted to use this but need to quote the source origin.
 Program        : Solution for hackerrank question posted here: https://www.hackerrank.com/challenges/pangrams

Program to check if a string is a pangram
*/


//Program Start

using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var inp = Console.ReadLine();
        bool isPangram = new Solution().runPangramCheck(inp.ToString());
        Console.WriteLine(isPangram==true ? "pangram" : "not pangram");
    }
    public bool runPangramCheck(string s){
        List<char> alphaPresent = new List<char>();
        //Console.WriteLine(s);
        foreach(char c in s){
            if(Char.IsLetter(c)){
                //dictPrinter(alphaPresent);
                if(!alphaPresent.Contains(Char.ToLower(c))){
                    alphaPresent.Add(Char.ToLower(c));
                }
                if(alphaPresent.Count==26){
                    return true;
                }
            }
            //Console.WriteLine();
        }
        return false;
    }
    
    public void dictPrinter(List<char> l){
        l.Sort();
        foreach(char c in l){
            Console.Write(c);
        }
    }
}
