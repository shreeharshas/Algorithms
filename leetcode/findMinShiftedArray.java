public class findMinShiftedArray {
    public int findMin(int[] nums) {
        /*int low = 0;
        int high = nums.length-1;
        int mid = (low+high)/2;
        
        int key = 20;
        
        while(nums[low]<nums[high]){
            if(nums[mid]<nums[low]){
                high=mid;
                mid = (low+high)/2;
            }
            else if(nums[mid]>nums[high]){
                low=mid;
                mid=(low+high)/2;
            }
            else{
                low=mid;
                mid=(low+high)/2;
            }
            continue;            
        }
        return nums[mid];*/
        int n = nums.length;
        switch(n){
            case 0:    
                return 0;
            case 1:
                return nums[0];
            case 2:
                return Math.min(nums[0],nums[1]);
        }
        for(int i=1;i<=nums.length-1;i++){
            if(nums[i]<nums[i-1]){
                return nums[i];
            }
        }
        return nums[0];
    }
}
