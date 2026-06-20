public class Solution {
    public int LargestRectangleArea(int[] heights) {
        Stack<int> stack = new Stack<int>();
        int max = 0;
        int n = heights.Length;
        for(int i = 0; i <= n; i++){
            int currentHeight = i == n ? 0 : heights[i];
            while(stack.Count > 0 &&  currentHeight < heights[stack.Peek()]){
                int popHeight = heights[stack.Pop()];
                int width = stack.Count > 0 ? i-stack.Peek()-1 : i;
                max = Math.Max(max, popHeight * width);
            }
            stack.Push(i);
        }
        return max;
    }
}
