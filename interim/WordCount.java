public class WordCount{
public static void main(String []args){
   //args = practice makes perfect. get perfect by practice. just practice!"
   
   HashMap<String, Integer> result = new HashMap<String, Integer>();
   //Regex
   args.replace("!", "");
   args.replace(".", "");
   
   //args = practice makes perfect get perfect by practice just practice"
   
   String[] array = args.split(" "); //9 strings separately
   
   for(int i=0;i<array.length;i++){------------------------->O(n)
      if(result.containsKey(array[i])){
         int count = result.get(array[i]);
         result.put(array[i], ++count);
      }
      else{
         result.put(array[i], 1);
      }
   }
   
   TreeMap<Integer, ArrayList<String>> hmapNew = new TreeMap<>(Collections.reverseOrder());
   for(EntrySet<String, Integer> es : result.getEntrySet()){------------->O(n)
      if(hmapNew.containsKey(es.getValue())){
         ArrayList<String> al = hmapNew.get(es.getValue());
         al.add(es.getKey());
         hmapNew.put(es.getValue(), al);
      }
      else{
         ArrayList<String> al = new ArrayList<String>();------------>O(n)
         al.add(es.getKey());
         hmapNew.put(es.getValue(), al);
      }
   }
   
   for(EntrySet<Integer, ArrayList<String>> finalES : hmapNew.getEntrySet()){--->O(n)
      for(int x=0;x<finalES.getValue().length;x++){--->O(k)
         System.out.println(finalES.Value.get(x)+":"+es.getKey());
      }      
   }
}
   
//O(n.k) n->strings k->average number of strings in the arraylist
}
