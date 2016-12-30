public class hammingdistance {
    public int hammingDistance(int x, int y) {
        String s1 = Integer.toBinaryString(x);
        String s2 = Integer.toBinaryString(y);
        int z = x ^ y;
        int count = 0;
        String s = Integer.toBinaryString(z);
        for(int i=0;i<s.length();i++){
            if(s.charAt(i)=='1')
                count++;
        }
        return count;
    }
}
