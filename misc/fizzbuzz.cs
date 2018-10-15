/* FizzBuzz - prints "fizz" for multiples of 3, "buzz" for multiples of 5, 
"fizzbuzz" for multiples of both and the number itself if none of these*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string output = "";
            for(int i=1;i<=100;i++){
                if(i%3 == 0) {output = "fizz";}
                if(i%5 == 0) {output += "buzz";}
                if(output=="") {output += (i+" ");}
                Console.WriteLine(output);
                output="";
            }
        }
    }
}
