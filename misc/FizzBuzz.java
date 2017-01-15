public class FizzBuzz {
    public List<String> fizzBuzz(int n) {
        List<String> retList = new ArrayList<String>();
        for(int i=1; i<=n; i++){
            if(i%15==0){
                retList.add("FizzBuzz");
            }
            else if(i%5==0){
                retList.add("Buzz");
            }
            else if(i%3==0){
                retList.add("Fizz");
            }
            else{
                retList.add(Integer.toString(i));
            }
        }
        return retList;
    }
}