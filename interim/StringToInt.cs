public class StringToInt {
    public int MyAtoi(string str) { //"12345"
        int min = 0, result = 0;
        bool negFlag = false;
        
        if(String.IsNullOrEmpty(str))
            return 0;
        
        str = str.Trim();
        
        if(str[0] == '-'){
            negFlag = true;
            min = 1;
        }
        else if(str[0]=='+'){
            min = 1;
        }
        
        for(int i = min; i < str.Length; i++){
            int num = 1;
            for(int j =0;j<str.Length-i-1;j++)
                num *= 10;
            switch(str[i]){
                case '0': result += 0;break;
                case '1': result += 1* num;break;
                case '2': result += 2* num;break;
                case '3': result += 3* num;break;
                case '4': result += 4* num;break;
                case '5': result += 5* num;break;
                case '6': result += 6* num;break;
                case '7': result += 7* num;break;
                case '8': result += 8* num;break;
                case '9': result += 9* num;break;
                default:
                        for(int k=0;k<str.Length-i;k++)
                            result/=10;
                        return negFlag?-1*result:result;
            }
        }
        return negFlag?-1*result:result;
    }
}
