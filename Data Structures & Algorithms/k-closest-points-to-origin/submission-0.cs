public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[], double> queue = new PriorityQueue<int[], double>();
        for(int i = 0; i < points.Length; i++){
            double distance = Math.Sqrt(Math.Pow(0-points[i][0], 2) + Math.Pow(0-points[i][1], 2));
            queue.Enqueue(new int[]{ points[i][0], points[i][1]}, -distance);
            if(queue.Count > k){
                queue.Dequeue();
            }
        }
        int[][] res = new int[k][];
        int c = 0;
        while(queue.Count > 0){
            res[c++] = queue.Dequeue();
        }
        return res;
    }
}
