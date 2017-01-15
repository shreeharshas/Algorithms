import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class groupAnagrams {
    public List<List<String>> groupAnagrams(String[] strs) {
        HashMap<String, List<String>> mp = new HashMap<>();
        for(String ss : strs){
        	char[] ca = ss.toCharArray();
        	Arrays.sort(ca);
        	String sorted = new String(ca);
        	
        	if(!mp.containsKey(sorted)){
        		mp.put(sorted, new ArrayList<String>());
        	}
        	mp.get(sorted).add(ss);
        }       
        
        List<List<String>> ll = new ArrayList<>();
        for(Map.Entry<String, List<String>> e : mp.entrySet()){
        	ll.add(e.getValue());
        }
        return ll;
    }
}