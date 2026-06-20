public class Solution {
    public bool hasDuplicate(int[] nums) {
        //1. brute force O(n^2)
        // for(int i = 0; i < nums.Length-1; i++){
        //     for(int k = i+1; k <= nums.Length-1;k++){
        //         if(nums[i] == nums[k])
        //         return true;
        //     }
        // }
        // return false;
        //2. sorting O(nlogn)
        // Array.Sort(nums);
        // for(int i = 0; i < nums.Length-1;i++){
        //     if(nums[i] == nums[i+1])
        //     return true;
        // }
        // return false;
        //3.hash set
        // var set = new HashSet<int>();
        // for(int i = 0; i < nums.Length; i++){
        //     if(!set.Add(nums[i]))
        //     return true;
        // }
        // return false;
        //4. hash set length
        if(nums.Length != nums.ToHashSet().Count())
        return true;
        return false;
    }
}