public class Solution {
    public int Trap(int[] height) {
        //1. brute force O(n^2)
        // if(height == null || height.Length == 0) return 0;
        // int res = 0;
        // for(int i = 0; i < height.Length-1; i++){

        //     int leftMax = height[i];
        //     for(int j = 0; j < i; j++){
        //         leftMax = Math.Max(leftMax,height[j]);
        //     }
 
        //     int rightMax = height[i];
        //     for(int k = height.Length-1; k > i; k--){
        //         rightMax = Math.Max(rightMax, height[k]);
        //     }
 
        //     res += Math.Min(leftMax,rightMax) - height[i];
        // }
        // return res;
        //2. PREFIX & SUFFIX
        // if(height == null || height.Length == 0) return 0;
        // int[] pref = new int[height.Length];
        // pref[0] = height[0];
        // for(int i = 1; i < height.Length; i++){
        //     pref[i] = Math.Max(height[i],pref[i-1]);
        // }
        // int[] suff = new int[height.Length];
        // suff[height.Length-1] = height[height.Length-1];
        // for(int i = height.Length-2; i >= 0; i--){
        //     suff[i] = Math.Max(suff[i+1],height[i]);
        // }
        // int[] nums = new int[height.Length];
        // int res = 0;
        // for(int i = 0; i < nums.Length; i++){
        //     nums[i] = Math.Min(pref[i], suff[i]) - height[i];
        //     res += nums[i];
        // }
        // return res;
        // 3. stack
        //y tuong duyet mang, tim tuong trai phai, khi gap tuong phai thì bat dau tinh vung nuoc
        //stack se luu index cua buc tuong 
        //khi duyet thi se giu buc tuong ben trai
        if(height == null || height.Length == 0) return 0;
        int n = height.Length;
        int res = 0;
        Stack<int> stack = new Stack<int>();
        for(int i = 0; i < n; i++){
            while(stack.Count > 0 && height[i] >= height[stack.Peek()]){
                int mid = height[stack.Pop()];
                if(stack.Count > 0){
                    int right = height[i];
                    int left = height[stack.Peek()];
                    int toAdd = Math.Min(right,left) - mid;
                    int w = i - stack.Peek() - 1;
                    res += w*toAdd;
                }
            }
            stack.Push(i);
        }
        return res;
    }
}
