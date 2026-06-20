public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        //1. sorting O(n*nlogn)
        // var dict = new Dictionary<string, List<string>>();
        // foreach(var str in strs){
        //     char[] strChar = str.ToCharArray();
        //     Array.Sort(strChar);
        //     var sortedStr = new string(strChar);
        //     if(!dict.ContainsKey(sortedStr)){
        //         dict[sortedStr] = new List<string>();
        //     }
        //     dict[sortedStr].Add(str);
        // }
        // return dict.Values.ToList();
        //2 biến số thành key
        var dict = new Dictionary<string,List<string>>();
        foreach(var str in strs){
            int[] nums = new int[26];
            char[] strChar = str.ToCharArray();
            foreach(var c in strChar){
                nums[c-'a']++;
            }
            string key = string.Join(',',nums);
            if(!dict.ContainsKey(key)){
                dict[key] = new List<string>();
            }
            dict[key].Add(str);
        }
        return dict.Values.ToList();
    }
}
