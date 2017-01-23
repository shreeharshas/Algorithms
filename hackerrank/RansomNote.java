/*Based on the question at the link:
https://www.hackerrank.com/challenges/ctci-ransom-note
*/
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
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
        
        for(int ransom_i=0; ransom_i < n; ransom_i++){
            String s = in.next();
            if(!magazine.containsKey(s)){
                System.out.println("No");
                return;
            }
            else{
                int count = magazine.get(s);
                magazine.put(s, --count);
                if(count<0){
                    System.out.println("No");
                    return;
                }
            }
        }
        System.out.println("Yes");
    }
}
