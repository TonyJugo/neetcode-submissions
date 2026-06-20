public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int l = 1;
        int r = piles.Max();
        int res = int.MaxValue;
        while(l <= r){
            int k = l + (r-l)/2;
            double totalTime = 0;
            foreach(int pile in piles){
                totalTime += Math.Ceiling((double)pile / k);
            }
            //an qua cham thi phai tang toc do an len
            if(totalTime > h){
                l = k + 1;
            //an nhanh bang thoi gian hoac nhanh hon thi giam toc do an de tim min speed
            }else{
                r = k - 1;
                res = Math.Min(res, k);
            }
        }
        return res;
    }
}
