public class MinValueInSortedArrayWithDuplicates {
    private int minVal;
    public int FindMin(int[] nums) {
        return modifiedBinarySearch(nums, low, mid, high);
    }
    
    private int modifiedBinarySearch(int []nums, int low, int mid, int high){
        if(nums.Length==0)
            return;
        minVal = nums[0];
        
        if(nums[0]<nums[nums.Length-1]){//array not rotated
            return nums[0];
        }
        
        
        if(nums[low]>nums[low+1]){
            minVal = nums[low+1];
            return;
        }
        
        int low = 0;
        int high = nums.Length-1;
        int mid = (low+high)/2;
        
/*        l   m   h
          567801234   */
        if(low<mid){
            if(mid>high){
                modifiedBinarySearch(nums, mid, (mid+high)/2, high);
            }
            else{
                modifiedBinarySearch(nums, low, (low+mid)/2, mid);
            }
        }
        else{
            
        }
    }
}
