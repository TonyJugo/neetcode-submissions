public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        //list position va speed
        List<int[]> list = new List<int[]>();
        for(int i = 0; i < position.Length; i++){
            list.Add(new int[]{position[i], speed[i]});
        }
        list.Sort((a,b) => b[0].CompareTo(a[0]));
        Stack<double> stack = new Stack<double>();
        foreach(var car in list){
            double time = (double)(target-car[0]) / car[1];
            //thoi gian ve dich bang nhau hoac nho hon xe dang truoc thi tinh la 1 doan xe
            //cu dung dit nhau la thanh 1 doan xe
            if(stack.Count > 0 && time <= stack.Peek()){

            }else{
                stack.Push(time);
            }
        }
        return stack.Count();
    }
}
