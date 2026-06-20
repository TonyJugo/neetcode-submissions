public class Solution {
    public int MaxProfit(int[] prices) {
        //1. brute force
        // int res = 0;
        // for(int i = 0; i < prices.Length-1; i++){
        //     int buyMin = prices[i];
        //     for(int j = i + 1; j < prices.Length; j++){
        //         res = Math.Max(res, prices[j] - buyMin);
        //     }
        // }
        // return res; 
        //2. two pointer
        if(prices == null || prices.Length == 0) return 0;
        int res = 0;
        int l = 0; // ngay mua
        int r = 1; // ngay ban
        while(r < prices.Length){
            if(prices[l] < prices[r]){
                res = Math.Max(res, prices[r] - prices[l]);
            }else{
                l = r;
            }
            r++;
        }
        return res;
    }
}
