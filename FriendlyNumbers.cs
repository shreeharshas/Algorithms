/*
For x = 220 and y = 284, the output should be
friendly_numbers(x, y) = "Yes".

The proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110, which add up to 284; and the proper divisors of 284 are 1, 2, 4, 71 and 142, which add up to 220.

Input/Output

[time limit] 3000ms (cs)
[input] integer x

Constraints:
1 ≤ x ≤ 105.

[input] integer y

Constraints:
1 ≤ y ≤ 105.

[output] string

"Yes" if x and y are friendly and "No" otherwise.
*/

string friendly_numbers(int x, int y) {
    long sum_x = 0L, sum_y = 0L;
    if(x==0||y==0||x==y)
        return "No";
    
    List<int> pDivX = GetProperDivisors(x);
    List<int> pDivY = GetProperDivisors(y);
    
    sum_x= pDivX.Sum();
    sum_y= pDivY.Sum();
    Console.WriteLine(sum_x+","+sum_y);
    return (sum_x==y&&sum_y==x?"Yes":"No");
}

List<int> GetProperDivisors(int x){
    List<int> retVal = new List<int>();
    for(int i=1;i<=x/2;i++){
        if(x%i==0){
            retVal.Add(i);
        }
    }
    return retVal;
}
