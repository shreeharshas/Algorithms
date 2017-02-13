public class Solution {
    private int minVal;
    public int FindMin(int[] nums) {
        if(nums.Length==0)
            return -1;
        if(nums.Length==1)
            return nums[0];
        if(nums.Length==2)
            return Math.Min(nums[0],nums[1]);
        int? x = modifiedBinarySearch(nums, 0, (nums.Length-1)/2, nums.Length-1);
        if(x==null)
            return nums[0];
        else
            return Math.Min((int)x,minVal);
    }
    
    private int? modifiedBinarySearch(int []nums, int low, int mid, int high){
        if(nums.Length==0)
            return null;
        minVal = Math.Min(minVal, nums[0]);
        
        if(nums[0]<nums[nums.Length-1]){//array not rotated
            return nums[0];
        }
        if(low > mid){
            minVal = mid;
                return modifiedBinarySearch(nums, low, (low+mid)/2, mid);
        }
        else if(low<mid){
            minVal = low;
                return modifiedBinarySearch(nums, mid, (mid+high)/2, high);
        }
        else{//low = mid
            if(mid==high){
                minVal = nums[0];
                return null;
            }
            else{
                return modifiedBinarySearch(nums, mid, (mid+high)/2,high);
            }
        }
    }
}
