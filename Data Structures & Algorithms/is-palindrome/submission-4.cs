public class Solution {
    public bool IsPalindrome(string s) {
        // if(s.Length == 0) return true;
        // string sTrim = "";
        // for(int i = 0; i < s.Length; i++){
        //     // if(!Regex.IsMatch(s[i].ToString(), "[A-Za-z0-9]")) continue;
        //     if(!char.IsLetterOrDigit(s[i])) continue;
        //     sTrim += s[i];
        // } 
        // string sTrimRevert = "";  
        // for(int j = sTrim.Length-1; j >= 0; j--){
        //     sTrimRevert += sTrim[j];
        // }
        // return sTrim.ToLower() == sTrimRevert.ToLower();
        //1. brute force solution
        string a = "";
        for(int i = 0; i < s.Length; i++){
            if(!char.IsLetterOrDigit(s[i])) continue;
            a+=s[i];
        }
        return a.ToLower() == new string(a.ToLower().Reverse().ToArray());
        //2. two pointer
        // if(s.Length == 0) return true;
        // int i = 0;
        // int j = s.Length-1;
        // while(i < j){
        //     while(i < j && !char.IsLetterOrDigit(s[i])){
        //         i++;
        //     }
        //     while(j > i && !char.IsLetterOrDigit(s[j])){
        //         j--;
        //     }
        //     if(char.ToLower(s[i]) != char.ToLower(s[j])) return false;
        //     i++;
        //     j--;
        // }
        // return true;
    }
}
