import java.util.*;
import java.lang.*;
import java.io.*;

//The idea is to ensure that there are least number of comparisons - brute force method takes O(n) time but binary search method takes O(logn) time
public class FindMissingNumber {
//Using recursion:
	static int calls = 0;
	public static void main (String[] args) throws java.lang.Exception
	{
		int[] a = {0,1,2,3,4,5,7,8,9,10};
		FindMissingNumber i = new FindMissingNumber();
		System.out.println("Missing element from the array:"+i.findMissing(a)+"\nCallStack length:"+calls);
	}
	
	Integer findMissing(int []a){
		return findMissing(a, 0, a.length - 1);
	}
	Integer findMissing(int[] a, int start, int end){
		calls++;
		if(end-start<=1){
			if(a[end]-a[start]>1){
				return (a[end]+a[start])/2;
			}
			return null;
		}
		else{	
			int trnctdAvg = (a[end]+a[start])/2;			//10/2 = 5		//13/2=6
			int diffIndx = trnctdAvg - a[start];			//5-2 = 3		//6-5 = 1
			int indexToCheck = start + diffIndx;			//0+3 = 3		//3+1 = 4
			
			if(a[indexToCheck]>trnctdAvg)
				return findMissing(a, start, indexToCheck);
			else {
				return findMissing(a, indexToCheck, end); 
			}
		}
	}
}
