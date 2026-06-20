public class Solution {
    public int LongestConsecutive(int[] nums) {
        //1. brute force
        // int res = 0;
        // HashSet<int> set = new HashSet<int>(nums);
        // for(int i = 0; i < nums.Length; i++){
        //     int cur = nums[i];
        //     int streak = 0;
        //     while(set.Contains(cur)){
        //         cur++;
        //         streak++;
        //     }
        //     res = Math.Max(res, streak);
        // }
        // return res;
        //2. sorting
        if(nums.Length == 0) return 0;
        int res = 1;
        Array.Sort(nums,(a,b) => a.CompareTo(b));
        int streak = 1;
        for(int i = 0; i< nums.Length; i++){
            if(i == 0) continue;
            int cur = nums[i];
            if(cur == nums[i-1]) continue;
            if(cur == nums[i-1] +1){
                streak++;
            }else{
                streak = 1;
            }
            res = Math.Max(res, streak);
        }
        return res;
    }
}
