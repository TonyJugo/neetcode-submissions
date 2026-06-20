public class Solution {
    public int LengthOfLongestSubstring(string s) {
        //1. brute force
        // int res = 0;
        // for(int i = 0; i < s.Length; i++){
        //     HashSet<char> set = new HashSet<char>();
        //     for(int j = i; j < s.Length; j++){
        //         if(set.Contains(s[j])) break;
        //         set.Add(s[j]);
        //     }
        //     res = Math.Max(res, set.Count);
        // }
        // return res;
        //2. sliding window
        // gap duplicate thi remove thg ben trai cho den het duplicate
        int l = 0;
        int res = 0;
        HashSet<char> set = new HashSet<char>();
        for(int r = 0; r < s.Length; r++){
            while(set.Contains(s[r])){
                set.Remove(s[l++]);
            }
            set.Add(s[r]);
            res = Math.Max(res, set.Count());
        }
        return res;
    }
}
