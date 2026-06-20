public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int> stack = new Stack<int>();
        int[] res = new int[temperatures.Length];
        for(int i = 0; i < temperatures.Length; i++){
            //nhiet do hom nay lon hon nhiet do hom qua thi tinh khoang cach truoc do
            while(stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()]){
                int prevIndex = stack.Pop();
                res[prevIndex] = i - prevIndex;
            }
            stack.Push(i);
        }
        return res;
    }
}
