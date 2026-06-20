public class Solution {
    public int LengthOfLongestSubstring(string s) {
        //1. brute force
        //duyet 
        int res = 0;
        for(int i = 0; i < s.Length; i++){
            HashSet<char> set = new HashSet<char>();
            for(int j = i; j < s.Length; j++){
                if(set.Contains(s[j])) break;
                set.Add(s[j]);
            }
            res = Math.Max(res, set.Count);
        }
        return res;
    }
}
