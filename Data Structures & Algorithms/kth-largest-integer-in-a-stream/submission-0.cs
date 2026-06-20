public class KthLargest {
    PriorityQueue<int,int> queue;
    int k = 0;
    public KthLargest(int k, int[] nums) {
        queue = new PriorityQueue<int,int>();
        foreach(int num in nums){
            queue.Enqueue(num, num);
        }
        this.k = k;
    }
    
    public int Add(int val) {
        queue.Enqueue(val, val);
        while(queue.Count > k){
            queue.Dequeue();
        }
        return queue.Peek();
    }
}
