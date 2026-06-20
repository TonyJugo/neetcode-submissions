public class Solution {
    public int CharacterReplacement(string s, int k) {
        //1. brute force
        //y tuong tim max frequency và L - max phải <= k thi cap nhat L
        // int res = 0;
        // for(int i = 0; i < s.Length; i++){
        //     Dictionary<char,int> dict = new Dictionary<char,int>();
        //     int maxF = 0;
        //     for(int j = i; j < s.Length; j++){
        //         dict[s[j]] = dict.GetValueOrDefault(s[j], 0) + 1;
        //         maxF = Math.Max(maxF, dict[s[j]]);
        //         if(j-i+1 - maxF <= k){
        //             res = Math.Max(res, j-i+1);
        //         }
        //     }
        // }
        // return res;
        //2. sliding window
        int res = 0;
        //cho moi ki tu lam vua 1 lần
        for(int i = 0; i < s.Length; i++){
            int l = 0;
            int count = 0;
            for(int r = 0; r < s.Length; r++){
                if(s[r] == s[i]){
                    count++;
                }
                //neu da vuot qua dieu kien
                //thi gioi han lai cua so de dem tiep
                while(r-l+1 - count > k){
                    if(s[l] == s[i]){
                        count--;
                    }
                    l++;
                }
                res = Math.Max(res, r-l+1);
            }
        }
        return res;
    }
}
