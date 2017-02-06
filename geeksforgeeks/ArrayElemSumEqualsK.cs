//Given an array A and a key x, print a pair of elements which sum to x
public struct ans{
    public int num1, num2;
}

public class Program
{
    public static void Main(string[] args)
    {
        int []A = {23,12,3,544,56,567,435234,63,6,569,567,84,6724,62345};
        int x = 1136; // method must return 569 and 567
        Program p = new Program();
        ans a = p.getSumPair(A, x);
        Console.WriteLine(a.num1 + " " + a.num2);
    }

    private ans getSumPair(int[] A, int x){
        Dictionary<int,bool> d = new Dictionary<int,bool>();
        ans a = new ans();
        foreach(int i in A){
            bool b = false;
            if(d.TryGetValue(x - i, out b)){
                a.num1 = i;
                a.num2 = x-i;
                return a;
            }
            else
            {
                d.Add(i,true);
            }
        }
        return a;
    }
}
