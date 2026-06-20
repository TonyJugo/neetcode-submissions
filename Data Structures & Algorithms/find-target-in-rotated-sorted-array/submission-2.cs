public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0;
        int r = nums.Length-1;
        while(l < r){
            int mid = l + (r-l)/2;
            if(nums[mid] > nums[r]){
                l = mid + 1;
            }else{
                r = mid;
            }
        }
        int result = binarySearch (nums, target, l, nums.Length-1); 
        if(result == -1){
            return binarySearch (nums, target, 0, l-1);
        }
        return result;
    }
    public int binarySearch(int[] nums, int target, int l, int r){
        while(l <= r){
            int mid = l + (r-l)/2;
            if(nums[mid] > target){
                r = mid - 1;
            }else if(nums[mid] < target){
                l = mid + 1;
            }else{
                return mid;
            }
        }
        return -1;
    }
}
