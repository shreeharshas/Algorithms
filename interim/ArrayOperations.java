/*
To implement a generic code for array functions such as:

1. finding the duplicate values
2. finding missing element in a series of numbers
3. checking if it has a palindromic sequence of numbers
*/
import java.util.*;

public class ArrayOperations{
	private int[] arr;
	
	public ArrayOperations() {
		arr = new int[]{1,2,2,3,4,5,6};
	}
	
	public static void main(String[] args) {
		System.out.println("Duplicate value is:" + new ArrayParser().getDuplicate());
	}
	
	public int getMissing(){
		int min = 0;
		int max = arr.length -1;
		
	}
	
	public int getDuplicate() {
		int dup = arr[0];
		for(int i=1; i<arr.length; i++){
			dup = dup ^ arr[i];
		}
		return dup;
	}
}
