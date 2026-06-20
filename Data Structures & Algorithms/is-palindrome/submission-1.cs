public class Solution {
    public bool IsPalindrome(string s) {
        if(s.Length == 0) return true;
        string sTrim = "";
        for(int i = 0; i < s.Length; i++){
            // if(!Regex.IsMatch(s[i].ToString(), "[A-Za-z0-9]")) continue;
            if(!char.IsLetterOrDigit(s[i])) continue;
            sTrim += s[i];
        } 
        string sTrimRevert = "";  
        for(int j = sTrim.Length-1; j >= 0; j--){
            sTrimRevert += sTrim[j];
        }
        return sTrim.ToLower() == sTrimRevert.ToLower();
    }
}
