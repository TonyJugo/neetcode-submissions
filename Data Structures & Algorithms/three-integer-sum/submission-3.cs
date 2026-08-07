public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<List<int>> res = new List<List<int>>();
        for(int k = 0; k < nums.Length-1; k++){
            if(k > 0 && nums[k] == nums[k-1]) continue;
            int i = k+1, j = nums.Length-1;
            while(i < j){
                int sum = nums[k] + nums[i] + nums[j];
                if(sum == 0){
                    res.Add(new List<int>(){nums[k],nums[i],nums[j]});
                    i++;
                    j--;
                    while(i < j && nums[i] == nums[i-1]){
                        i++;
                    }
                }else if(sum < 0){
                    i++;
                }else{
                    j--;
                }
            }
        }
        return res;
    }
}
