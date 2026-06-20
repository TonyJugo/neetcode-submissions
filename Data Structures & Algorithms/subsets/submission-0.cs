public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> result = new List<List<int>>();
        List<int> current = new List<int>();
        BackTrack(nums, result, current, 0);
        return result;
    }
    private void BackTrack(int[] nums, List<List<int>> result, List<int> current, int startIndex){
        result.Add(new List<int>(current));
        for(int i = startIndex; i < nums.Length; i++){
            current.Add(nums[i]);
            BackTrack(nums, result, current, i+1);
            current.RemoveAt(current.Count-1);
        }        
    }
}
