public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
                // 1. brute force O(n^3)
        // HashSet<Tuple<int,int,int>> uniqueTriplet = new HashSet<Tuple<int,int,int>>();
        // List<List<int>> res = new List<List<int>>();
        // Array.Sort(nums);
        // for(int i = 0; i < nums.Length-2; i++){
        //     for(int k = i+1; k < nums.Length-1; k++){
        //         for(int j = k+1; j < nums.Length; j++){
        //             if(nums[i] + nums[k] + nums[j] == 0){
        //                 Tuple<int,int,int> triplet = Tuple.Create(nums[i],nums[k],nums[j]);
        //                 uniqueTriplet.Add(triplet);
        //             }
        //         }
        //     }
        // }
        // foreach(var tuple in uniqueTriplet){
        //     res.Add(new List<int>(){tuple.Item1, tuple.Item2, tuple.Item3});
        // }
        // return res;
        //2. hash map
        // Dictionary<int, int> dict = new Dictionary<int,int>();
        // Array.Sort(nums);
        // for(int i = 0; i < nums.Length; i++){
        //     dict[nums[i]] = dict.GetValueOrDefault(nums[i], 0) + 1;
        // }
        // List<List<int>> res = new List<List<int>>();
        // for(int i = 0; i < nums.Length-1; i++){
        //     dict[nums[i]]--;
        //     if(i > 0 && nums[i] == nums[i-1]) continue;
        //     for(int j = i+1; j < nums.Length; j++){
        //         dict[nums[j]]--;
        //         if(j>i+1 && nums[j] == nums[j-1]) continue;
        //         int target = 0 - (nums[i] + nums[j]);
        //         if(dict.ContainsKey(target) && dict[target] > 0){
        //             res.Add(new List<int>(){nums[i], nums[j], target});
        //         }
        //     }
        //     //restore nums[j]
        //     for(int k = i+1; k < nums.Length; k++){
        //         dict[nums[k]]++;
        //     }
        // }
        // return res;
        //3. two pointer
        List<List<int>> res = new List<List<int>>();
        Array.Sort(nums);
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] > 0) break;
            if(i > 0 && nums[i] == nums[i-1]) continue;
            int l = i+1;
            int r = nums.Length-1;
            while(l<r){
                int sum = nums[l] + nums[i] + nums[r];
                if(sum > 0){
                    r--;
                }else if(sum < 0){
                    l++;
                }else{
                    res.Add(new List<int>(){nums[i],nums[l],nums[r]});
                    l++;
                    r--;
                    //skip duplicate của l
                    while(l < r && nums[l] == nums[l-1]){
                       l++; 
                    }
                }
            }
        }
        return res;
    }
}
