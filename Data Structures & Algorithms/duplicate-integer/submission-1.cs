public class Solution {
    public bool hasDuplicate(int[] nums) {
        for(int i = 0; i < nums.Length-1; i++){
            for(int k = i+1; k <= nums.Length-1;k++){
                if(nums[i] == nums[k])
                return true;
            }
        }
        return false;
    }
}