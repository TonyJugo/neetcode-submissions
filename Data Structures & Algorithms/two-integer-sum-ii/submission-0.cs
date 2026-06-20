public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        for(int i = 0; i < numbers.Length; i++){
            dict[numbers[i]] = i;
        }
        for(int i = 0; i < numbers.Length; i++){
            int diff = target - numbers[i];
            if(dict.ContainsKey(diff)){
                return [Math.Min(dict[diff],i)+1, Math.Max(dict[diff],i)+1];
            }
        }
        return [];
    }
}
