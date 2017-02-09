/*
Program to check if a number is prime or not
.NET framework 4.5 and above

Space Complexity: O(√n) where n is the input number
Time Complexity: O(n)
*/  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Solution
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(new Program().checkPrime(4));
            Console.WriteLine(new Program().checkPrime(273457263));
            Console.WriteLine(new Program().checkPrime(234809));
        }
        
        bool checkPrime(int n){
            if(n%2==0||n==1||n==2||n==0)
                return false;
            
            HashSet<int> nums = new HashSet<int>();
            
            int limit = (int)Math.Ceiling(Math.Sqrt(n));
            for(int i=2;i<limit;i++){                   // O(√n)
                nums.Add(i);
            }
            
            for(int i=2;i<limit;i++){                   // O(√n)
                if(nums.Contains(i)){
                    if(n%i==0){
                       Console.WriteLine(n+" is not a prime number, it is divisible by "+nums.First());
                        return false;
                    }
                   else{
                       nums.RemoveWhere(c=>c%i==0);     //O(√n)
                   }
                }
            }
            if(nums.Count==0)
                return true;
            else
                Console.WriteLine(n+" is not a prime number, it is divisible by "+nums.Count +" integers, the first being "+nums.First());
            return false;
        }
    }
}
