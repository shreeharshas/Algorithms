/*Based on the question at the link:
https://www.hackerrank.com/challenges/ctci-ransom-note
*/
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class RansomNote {

    public static void main(String[] args) {
        Solution sln = new Solution();
        Scanner in = new Scanner(System.in);
        int m = in.nextInt();
        int n = in.nextInt();
        
        if(m<n){
            System.out.println("No");
            return;
        }
        
        HashMap<String,Integer> magazine = new HashMap<String,Integer>();
        for(int magazine_i=0; magazine_i < m; magazine_i++){
            String s = in.next();
            if(magazine.containsKey(s)){
                magazine.put(s, magazine.get(s)+1);
            }
            else{
                magazine.put(s, 1);
            }
        }
        
        sln.printMap(magazine, -1);
        
        for(int ransom_i=0; ransom_i < n; ransom_i++){
            String s = in.next();
            if(!magazine.containsKey(s)){
                System.out.println("No");
                return;
            }
            else{
                int count = magazine.get(s);
                sln.printMap(magazine, ransom_i);
                if(count<0){
                    System.out.println("No");
                    return;
                }
                magazine.put(s, --count);
            }
        }
        System.out.println("Yes");
    }
    
    void printMap(HashMap<String, Integer> h, int i){
        System.out.println("\nLoop:"+i);
        for (HashMap.Entry<String, Integer> entry : h.entrySet()) {
            System.out.println(entry.getKey()+" : "+entry.getValue());
        }
    }
}
