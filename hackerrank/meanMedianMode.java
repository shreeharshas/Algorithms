import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        int n = s.nextInt();
        if(n<1)
            return;
        
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
            else{
                h.put(X[i],1);
            }
        }
        
        Arrays.sort(X);
        
        float mean = (float)sum/n;
        float median = (n%2==0)?(float)(X[n/2]+X[(n/2)-1])/2:X[n/2];
               
        HashMap.Entry<Integer, Integer> entry = h.entrySet().iterator().next();
        int mode = entry.getKey();
        int maxModeVal = entry.getValue();
        
        Iterator it = h.entrySet().iterator();
        while (it.hasNext()) {
            Map.Entry pair = (Map.Entry)it.next();
            int t_mode = (int)pair.getKey();
            int t_val = (int)pair.getValue();
            if(t_val > maxModeVal){
                maxModeVal = Math.max(t_val, maxModeVal);
                mode = t_mode;
            }
            else if(t_val==maxModeVal){
                mode = Math.min(mode,t_mode);
            }
        }
        System.out.println(mean);
        System.out.println(median);
        System.out.println(mode);
    }
}
