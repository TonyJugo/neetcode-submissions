public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        PriorityQueue<(int value, int index),int> maxHeap = new PriorityQueue<(int, int),int>();
        int l = 0, r = l;
        int c = 0;
        List<int> res = new List<int>();
        while(r < nums.Length){
            maxHeap.Enqueue((nums[r], r), -nums[r]);
            if(r-l+1 > k){
                l++;
            }
            //ta khong chu dong xoa, ma khi ta gia tri tren dinh dang anh huong toi ket qua thi ta xoa
            while(maxHeap.Peek().index < l){
                maxHeap.Dequeue();
            }
            if(r-l+1 == k){
                res.Add(maxHeap.Peek().value);
                c++;
            }
            r++;
        }
        return res.ToArray();
    }
}
