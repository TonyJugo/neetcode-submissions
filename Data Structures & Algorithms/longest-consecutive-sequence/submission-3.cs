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
        //2. sorting -myself
        // if(nums.Length == 0) return 0;
        // int res = 1;
        // Array.Sort(nums,(a,b) => a.CompareTo(b));
        // int streak = 1;
        // for(int i = 0; i< nums.Length; i++){
        //     if(i == 0) continue;
        //     int cur = nums[i];
        //     if(cur == nums[i-1]) continue;
        //     if(cur == nums[i-1] +1){
        //         streak++;
        //     }else{
        //         streak = 1;
        //     }
        //     res = Math.Max(res, streak);
        // }
        // return res;
        //2. sorting - solution O(nlogn)
        if(nums.Length == 0) return 0;
        Array.Sort(nums);
        int res = 0;
        int cur = nums[0];
        int i = 0;
        int streak = 0;
        while(i < nums.Length){
            //check nếu gtri kì vòng ko = gtri hiện tại thì reset streak và gán gtri kì vọng cho hiện tại
            if(cur != nums[i]){
                streak = 0;
                cur = nums[i];
            }
            //tang i và bỏ qua duplicate
            while((i < nums.Length && cur == nums[i])){
                i++;    
            }
            //tăng gtri kì vòng và streak cho lần duyệt tiếp theo
            cur++;
            streak++;
            res = Math.Max(res,streak);
        }
        return res;

    }
}