/*
Based on question at https://leetcode.com/problems/letter-combinations-of-a-phone-number/?tab=Description
* high memory consumption to be fixed
*/
public class Solution {
    public List<string> LetterCombinations(string digits) {
        Dictionary<char, char[]> map = new Dictionary<char, char[]>(){
          {'1', new char[]{' '}}, {'2',new char[]{'a','b','c'}}, {'3', new char[]{'d','e','f'}},
          {'4', new char[]{'g','h','i'}},{'5',new char[]{'j','k','l'}}, {'6', new char[]{'m','n','o'}},
          {'7', new char[]{'p','q','r','s'}}, {'8', new char[]{'t','u','v'}}, {'9', new char[]{'w','x','y','z'}}
        };
        
        
        List<string> outp = new List<string>();
        //string inp = Console.ReadLine();

        foreach(char ch in digits){
            char[] val;
            map.TryGetValue(ch, out val);
            //Console.WriteLine(val[0]);
            if(outp.Count==0){
                //Console.WriteLine("Count 0");
                for(int i=0;i<val.Length;i++){
                    string s = val[i].ToString();
                    outp.Add(s);
                }
            }
            else{
                for(int i=0;i<outp.Count;i++){
                    string res = outp[i].ToString();
                    foreach(char c in val){
                        string s = res+c.ToString();
                        outp.Add(s);
                    }
                }
            }
        }
        return outp;
    }
}
