public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        char[] s1Char = s1.ToCharArray();
        Array.Sort(s1Char);
        string s1Sorted = new string(s1Char);
        for(int i = 0; i < s2.Length; i++){
            for(int j = i; j < s2.Length; j++){
                string subString = s2.Substring(i,j-i+1);
                char[] subChar = subString.ToCharArray();
                Array.Sort(subChar);
                string subSorted = new string(subChar);
                if(subSorted == s1Sorted) return true;
            }
        }
        return false;
    }

}
