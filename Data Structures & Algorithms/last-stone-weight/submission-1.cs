public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int,int> queue = new PriorityQueue<int,int>();
        for(int i = 0; i < stones.Length; i++){
            queue.Enqueue(stones[i], -stones[i]);
        }
        while(queue.Count > 1){
            int y = queue.Dequeue();
            int x = queue.Dequeue();
            if(x < y){
                y = y - x;
                queue.Enqueue(y, -y);
            }
        }
        return queue.Count == 1 ? queue.Dequeue() : 0; 
    }
}
