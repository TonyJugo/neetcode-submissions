 class Solution {
   public int[] TopKFrequent(int[] nums, int k) {
        //key là số và value là frequency
        var dict = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++){
            dict[nums[i]] = dict.GetValueOrDefault(nums[i], 0) + 1;
        }
        var list = dict.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();
        List<int> result = new List<int>();
        //tìm frequency max và trả về key
        for(int i = 0; i < k; i++){
            result.Add(list[i]);
        }
        return result.ToArray();

    }
}
