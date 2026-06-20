public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //1. brute force O(n^2)
        // for(int i =0; i < nums.Length-1; i++){
        //     for(int k = i+1; k < nums.Length; k++){
        //         if(nums[i] + nums[k] == target){
        //             return [i,k];
        //         }
        //     }
        // }
        // return [0,0];
        //2. List sort O(nlogn)
        // List<int[]> B = new List<int[]>(); 
        // for(int i = 0; i < nums.Length; i++){
        //     B.Add([i, nums[i]]);
        // }
        // B.Sort((a,b) => a[1].CompareTo(b[1])); 
        // int sum = 0;
        // for(int i = 0, k = nums.Length-1; i < k;){
        //     sum = B[i][1] + B[k][1];
        //     if(sum == target){
        //         return new int[]{Math.Min(B[i][0], B[k][0]), Math.Max(B[i][0],B[k][0])};
        //     }else if(sum < target){
        //         i++;
        //     }else{
        //         k--;
        //     }
        // }
        // return [0,0];
        //3. hash map O(n) - 2 pass
        // var dict = new Dictionary<int,int>();
        // for(int i = 0; i < nums.Length; i++){
        //     dict[nums[i]] = i;
        // }
        // int diff = 0;
        // for(int i = 0; i < nums.Length; i++){
        //     diff = target - nums[i];
        //     if(dict.ContainsKey(diff)){
        //         return[i,dict[diff]];
        //     }
        // }
        // return [0];
        //4. hash map - one pass O(n)
        var dict = new Dictionary<int,int>();
        int diff = 0;
        for(int i = 0; i < nums.Length; i++){
            diff = target - nums[i];
            //trước đó có diff trong dict ko ?
            if(dict.ContainsKey(diff)){
                return [dict[diff],i];
            }
            //ko có thì thêm nums[i] vô
            dict[nums[i]] = i;
        }
        return [0];
    }
}
