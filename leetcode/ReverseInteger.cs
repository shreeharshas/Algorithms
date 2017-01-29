/*
Code to reverse an integer
Based on question at leetcode at: https://leetcode.com/problems/reverse-integer/
*/

public class ReverseInteger {
    public int Reverse(int x) {
        StringBuilder sb = new StringBuilder(); // to hold the reverse order
        int d = 0;                              // to hold the last digit
        bool negFlag = false;                   // to ensure negative numbers are reversed along with the sign
        if(x<0){                                // check for negative input
            negFlag = true;                     
            x *= -1;                            // make x positive for reversing
        }
        while(x>0){                             // until all digits are rerversed one by one
              d = x%10;                         // take last digit
            sb.Append(d);                       // add it in reverse order
            x=x/10;                             // remove last digit
        }
        
        int outResult;                          // to match datatype
        if(Int32.TryParse(sb.ToString(),out outResult)){
            return negFlag?outResult*-1:outResult;  // check for negative and return integer value appropriately
        }
        else
            return 0;                           // default to zereo in erraneous conditions
    }
}
