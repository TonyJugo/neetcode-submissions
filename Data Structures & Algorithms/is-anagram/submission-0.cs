public class Solution {
    public bool IsAnagram(string s, string t) {
        //1.brute force (so sánh 2 chuỗi đã sort)
        // if(s.Length != t.Length) return false;
        // char[] ss = s.ToCharArray();
        // Array.Sort(ss);
        // char[] tt = t.ToCharArray();
        // Array.Sort(tt); 
        // if(ss.SequenceEqual(tt))
        // return true;
        // return false;
        //2.hash map (đếm số kí tự giữa 2 chuỗi)
        // if(s.Length != t.Length)
        // return false;
        // var sCount = new Dictionary<char, int>();
        // var tCount = new Dictionary<char, int>();
        // for(int i = 0; i < s.Length; i++){
        //     sCount[s[i]] = sCount.GetValueOrDefault(s[i])+1;
        //     tCount[t[i]] = tCount.GetValueOrDefault(t[i])+1;
        // }
        // if(sCount.Count() == tCount.Count() && !sCount.Except(tCount).Any())
        // return true;
        // return false;
        //3. Hash table 
        if(s.Length != t.Length) 
        return false;
        var nums = new Dictionary<char,int>();
        for(int i = 0; i < s.Length; i++){
            nums[s[i]]= nums.GetValueOrDefault(s[i])+1;
            nums[t[i]]= nums.GetValueOrDefault(t[i])-1;
        }
        foreach(var kv in nums){
            if(kv.Value != 0) return false;
        }
        return true;
    }
}
