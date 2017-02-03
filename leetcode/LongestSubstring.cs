/*
Program to find the longest substring in a given string which has no repeating characters
Solution to question at https://leetcode.com/problems/longest-substring-without-repeating-characters/

Time Complexity: O(nm) --> moving along the length of the substring(m) for each input string's character(n)
Space Complexity: O(n) --> storing in the hashmap whether or not the character is repeating in the substring
*/
public class LongestSubstring {
    public int LengthOfLongestSubstring(string s) {
        //s = abcabcbb
        //int maxIndex = 0;
        int maxLength = 0;
        Dictionary<char,bool> l = null;
        for(int i=0;i<s.Length;i++){
            l = new Dictionary<char,bool>();
            int j=i;  //holds the start index of the largest substring found
            int count = 0;
            //Console.WriteLine("i:"+i);
            char cc = s[j];
            while(!l.ContainsKey(cc)){
                //Console.WriteLine("j:"+j+"s[j]:"+s[j]);
                count++;
                l[s[j++]]=true;
                if(j==s.Length){
                    if(count>maxLength){
                        //maxIndex = j;
                        maxLength = count;
                        return count;
                    }
                }
                else
                    cc=s[j];
            }
            if(count>maxLength){
                //maxIndex = j;
                maxLength = count;
            }
        }
        return maxLength;
    }
}
