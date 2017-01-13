public class LargeSum {
    public String addStrings(String num1, String num2) {
        int diff = num1.length() - num2.length();
        if(diff==0){
            return addWithCarry(num1, num2);
        }
        else if(diff>0){
            StringBuilder sb = new StringBuilder();
            for(int i =0;i<diff;i++){
                sb.append('0');
            }
            sb.append(num2);
            return addWithCarry(num1, sb.toString());
        }
        else if(diff<0){
            StringBuilder sb = new StringBuilder();
            for(int i =0;i<(-1*diff);i++){
                sb.append('0');
            }
            sb.append(num1);
            return addWithCarry(num1, sb.toString());
        }
        return "0";
    }
    
    private String addWithCarry(String num1, String num2){
        StringBuilder sb = new StringBuilder();
        int carry = 0;
        for(int i=0;i<num1.length();i++){
            int n1_i = num1.charAt(i);
            int n2_i = num2.charAt(i);
            
            int sum_i = n1_i + n2_i + carry;
            int digitAfterCarry = 0;
            if(sum_i > 10){
                carry = 1;
                digitAfterCarry = sum_i%10;
            }
            else{
                carry = 0;
                digitAfterCarry = sum_i;
            }
            sb.append(digitAfterCarry);
        }
        return sb.toString();
    }
}
