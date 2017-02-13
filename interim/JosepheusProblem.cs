using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string []args){
            List<int> alive = new List<int>();
            
            int n = 5;
            int removed = 0;
            int swordAt = 2;
            
            for(int i=1;i<=n;i++){
                alive.Add(i);
            }
            
            for(int i=1; alive.Count !=2; i++) {
                alive.Remove(swordAt);
                Console.WriteLine("Removed:"+(swordAt));
                i = (swordAt + 1) % alive.Count;
                swordAt = (i + 1) % alive.Count;
                removed++;
            }
            
            foreach(int i in alive) {
                Console.WriteLine(i + ",");
            }
        }
    }
}
