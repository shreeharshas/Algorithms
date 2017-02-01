/*
https://leetcode.com/problems/valid-parentheses/
Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
The brackets must close in the correct order, "()" and "()[]{}" are all valid but "(]" and "([)]" are not.
*/
public class ValidParentheses {
    public bool IsValid(string s) {
        int a=0,b=0,c=0;
        
        Stack<char> stk = new Stack<char>();
        for(int i=0;i<s.Length;i++){
            switch(s[i]){
                case '(':
                        stk.Push('(');
                        a++;
                        break;
                case ')':
                        if(stk.Count==0)
                            return false;
                        if(stk.Peek()=='[' || stk.Peek()=='{')
                            return false;
                        else{
                            if(a==0)
                                return false;
                            else
                                stk.Pop();//a--;
                        }
                        break;
                case '[': 
                        stk.Push('[');
                            b++;
                        break;
                case ']': 
                        if(stk.Count==0)
                            return false;
                        if(stk.Peek()=='(' || stk.Peek()=='{')
                            return false;
                        else{
                            if(b==0)
                                return false;
                            else
                                stk.Pop();//a--;
                        }
                        break;
                case '{': 
                        stk.Push('{');
                            c++;
                        break;
                case '}': 
                        if(stk.Count==0)
                            return false;
                        if(stk.Peek()=='[' || stk.Peek()=='(')
                            return false;
                        else{
                            if(c==0)
                                return false;
                            else
                                stk.Pop();//a--;
                        }
                        break;
                default:
                        continue;
            }
        }
        
        return (stk.Count==0);
    }
}
