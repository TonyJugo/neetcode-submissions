public class KthLargest {
    private int k;
    private int[] nums;
    private PriorityQueue<int,int> queue;
    public KthLargest(int k, int[] nums) {
        this.k = k;
        this.nums = nums;
        queue = new PriorityQueue<int,int>();
        foreach(int num in nums){
            queue.Enqueue(num, num);
        }
    }
    
    public int Add(int val) {
        queue.Enqueue(val, val);
        while(queue.Count > k){
            queue.Dequeue();
        }
        return queue.Peek();
    }
}
