public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        //1. brute force
        // char[] s1Char = s1.ToCharArray();
        // Array.Sort(s1Char);
        // string s1Sorted = new string(s1Char);
        // for(int i = 0; i < s2.Length; i++){
        //     for(int j = i; j < s2.Length; j++){
        //         string subString = s2.Substring(i,j-i+1);
        //         char[] subChar = subString.ToCharArray();
        //         Array.Sort(subChar);
        //         string subSorted = new string(subChar);
        //         if(subSorted == s1Sorted) return true;
        //     }
        // }
        // return false;
        //2. dem so ki tu xuat hien 
        Dictionary<char,int> dict = new Dictionary<char,int>();
        for(int i = 0; i < s1.Length; i++){
            if(!dict.ContainsKey(s1[i])){
                dict[s1[i]] = 1;
            }else{
                dict[s1[i]] += 1;
            }
        }
        //duyet substring va dem so ki tu xuat hien, neu co so ki tu trung thi tang bien dem count so ki tu trung, neu so ki tu trung bang nhau thi la true
        int count1 = dict.Count;
        for(int i = 0; i < s2.Length; i++){
            int count2 = 0;
            Dictionary<char,int> dict2 = new Dictionary<char,int>();
            for(int j = i; j < s2.Length; j++){
                dict2[s2[j]] = dict2.GetValueOrDefault(s2[j], 0) + 1;
                if(!dict.ContainsKey(s2[j]) || dict[s2[j]] < dict2[s2[j]]) break;
                if(dict[s2[j]] == dict2[s2[j]]) count2++;
                if(count2 == count1) return true;
            }
        }
        return false;
    }

}
