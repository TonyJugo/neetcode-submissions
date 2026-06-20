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
        // int length = nums.Length;
        // int[] res = new int[length];
        // int prod = 1;
        // int count = 0;
        // foreach(var num in nums){
        //     if(num == 0){
        //         count++;
        //     }else{
        //         prod *= num;
        //     }
        // }
        
        // if(count > 1){
        //     return new int[length];
        // }
        // if(count == 1){
        //     for(int i = 0; i < length; i++){
        //         res[i] = nums[i] == 0 ? prod : 0; 
        //     }
        // }
        // if(count == 0){
        // for(int i = 0; i < length; i++){
        //     res[i] = prod / nums[i];
        // }
        // }
        // return res;
        //3. prefix & suffix (tích trái, tích phải)  O(n)
        int length = nums.Length;
        int[] pref = new int[length];
        int[] suff = new int[length];
        int[] res = new int[length];
        for(int i = 0; i < length; i++){
            pref[i] = i==0 ? 1 : pref[i-1] * nums[i-1]; 
        }
        
        for(int i = length-1; i >= 0; i--){
            suff[i] = i==(length-1)? 1 : suff[i+1] * nums[i+1];

        }
        for(int i = 0; i < length; i++){
            res[i] = suff[i] * pref[i];
        }
        return res;
        //4. pref and suffix optimal O(n) and O(1)
        // int length = nums.Length;
        // int[] res = new int[length];
        // for(int i = 0; i < length; i++){
        //     res[i] = i==0 ? 1 : res[i-1] * nums[i-1];
        // }
        // int postfix = 1;
        // for(int i = length-1; i >= 0; i--){
        //     res[i] *= postfix;
        //     postfix *= nums[i];
        // }
        // return res;
    }
}
