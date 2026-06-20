public class Solution {
    public int FindDuplicate(int[] nums) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++){
            dict[nums[i]] = dict.GetValueOrDefault(nums[i], 0) + 1;
        }
        int res = -1;
        foreach(var kv in dict){
            if(kv.Value > 1) res = kv.Key;
        }
        return res;
    }
}
