/*Based on hackerrank question at https://www.hackerrank.com/challenges/reduced-string */

using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        string s = Console.ReadLine();
        Console.WriteLine(new Solution().reduce(s));
    }
    
    private string reduce(string s){
        
        if(string.IsNullOrEmpty(s))
            return("Empty String");
        
        if(s.Length==1)
            return(s);
        
        if(s.Length==2)
            if(s[0]==s[1])
                return("Empty String");
            else
                return(s);
            
        for(int i=0;i<s.Length-1;i++){
            if(s[i]==s[i+1]){
                string s2 = s.Remove(i,1);
                return reduce(s2.Remove(i,1));
            }
        }
        //Console.WriteLine("oops "+ s);
        return s;
    }
}
