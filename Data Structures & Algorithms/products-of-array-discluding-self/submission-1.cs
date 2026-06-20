public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        //1. brutal force O(n^2)
        // int[] res = new int[nums.Length];
        // int product = 1;
        // for(int i = 0; i < nums.Length; i++){
        //     product = 1;
        //     for(int j = 0; j < nums.Length; j++){
        //         if(j != i){
        //             product *= nums[j];
        //         }
        //     }
        //     res[i] = product;
        // }
        // return res;
        //2. division
        int length = nums.Length;
        int[] res = new int[length];
        int prod = 1;
        int count = 0;
        foreach(var num in nums){
            if(num == 0){
                count++;
            }else{
                prod *= num;
            }
        }
        
        if(count > 1){
            return new int[length];
        }
        if(count == 1){
            for(int i = 0; i < length; i++){
                res[i] = nums[i] == 0 ? prod : 0; 
            }
        }
        if(count == 0){
        for(int i = 0; i < length; i++){
            res[i] = prod / nums[i];
        }
        }
        return res;
    }
}
