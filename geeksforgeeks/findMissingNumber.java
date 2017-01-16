import java.util.*;
import java.lang.*;
import java.io.*;

class Ideone
{
	static int calls = 0;
	public static void main (String[] args) throws java.lang.Exception
	{
		int[] a = {2,3,4,5,7,8};
		Ideone i = new Ideone();
		System.out.println("Missing element from the array:"+i.findMissing(a,0,a.length-1)+" Number of times looped:"+calls);
	}
	
	Integer findMissing(int[] a, int start, int end){
		calls++;
		if(end-start<=1){
			return null;
		}
		
		int trnctdAvg = (a[end]+a[start])/2;
		int diffIndx = trnctdAvg - a[start];
		if(a[start+diffIndx]!=trnctdAvg)    //check if the number exists at the corresponding index else that is missing
			return trnctdAvg;
		else{                               //check both sides of the array
			Integer leftRetVal = findMissing(a,start, start+diffIndx);
			Integer rightRetVal = findMissing(a, start+diffIndx, end); 
			return (leftRetVal==null)?rightRetVal:leftRetVal; //return non null value
		}
	}
}
