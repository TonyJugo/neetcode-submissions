public class Solution {
    public int LongestConsecutive(int[] nums) {
        int res = 0;
        HashSet<int> set = new HashSet<int>(nums);
        for(int i = 0; i < nums.Length; i++){
            int cur = nums[i];
            int streak = 0;
            while(set.Contains(cur)){
                cur++;
                streak++;
            }
            res = Math.Max(res, streak);
        }
        return res;
    }
}
