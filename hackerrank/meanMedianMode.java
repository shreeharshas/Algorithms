import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        int n = s.nextInt();
        int[] X = new int[n];
        int sum = 0;
        HashMap<Integer, Integer> h = new HashMap<>();
        for(int i=0;i<n;i++){
            X[i] = s.nextInt();
            sum+=X[i];
            if(h.containsKey(X[i])){
                int c = h.get(X[i]);
                h.put(X[i],++c);
            }
        }
        
        float mean = (float)sum/n;
        float median = (n%2==0)?(X[n/2]+X[(n+1)/2])/2:X[n/2];
        
        int mode = X[0];
        int maxVal = 0;
        Iterator it = h.entrySet().iterator();
        while (it.hasNext()) {
            Map.Entry pair = (Map.Entry)it.next();
            int v = (int)pair.getValue();
            maxVal = Math.max(v,maxVal);
            mode = (int)pair.getKey();
        }
        System.out.println(mean);
        System.out.println(median);
        System.out.println(mode);
    }
}
