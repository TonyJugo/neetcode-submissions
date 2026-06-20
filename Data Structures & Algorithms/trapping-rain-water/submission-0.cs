public class Solution {
    public int Trap(int[] height) {
        if(height == null || height.Length == 0) return 0;
        int res = 0;
        for(int i = 0; i < height.Length-1; i++){
            //tìm left max
            //gán cho cột hiện tại để tránh res ra số âm
            int leftMax = height[i];
            for(int j = 0; j < i; j++){
                leftMax = Math.Max(leftMax,height[j]);
            }
            //tìm rightmax
            int rightMax = height[i];
            for(int k = height.Length-1; k > i; k--){
                rightMax = Math.Max(rightMax, height[k]);
            }
            // tính
            res += Math.Min(leftMax,rightMax) - height[i];
        }
        return res;
    }
}
