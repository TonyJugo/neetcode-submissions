public class Solution {
    public string MinWindow(string s, string t) {
                //ta se dung mot bien dem
        //bien dem nay duoc dung de duy tri tinh hop le cua cua so
        //cua so se hop le khi bien dem bang voi so luong ki tu trong t
        int c = 0;
        int[] windowFreq = new int[128];
        int[] tFreq = new int[128];
        foreach(char ct in t){
            tFreq[ct]++;
        }
        int l = 0, r = l;
        string res = "";
        int min = int.MaxValue;
        int startIndex = 0;
        while(r < s.Length){
            windowFreq[s[r]]++;
            //neu ki tu hien tai la 1 trong cac ki tu trong chuoi t
            //va no phai <= so luong ki tu nay trong chuoi t
            if(tFreq[s[r]] > 0 && windowFreq[s[r]] <= tFreq[s[r]]){
                c++;
            }
            //khi cua so hop le ta se thu hep
            while(c == t.Length){
                if(r-l+1 < min){
                    min = r-l+1;
                    startIndex = l;
                    res = s.Substring(startIndex, min);
                }
                windowFreq[s[l]]--;
                if(tFreq[s[l]] > 0 && windowFreq[s[l]] < tFreq[s[l]]) c--;
                l++;
            }
            r++;
        }
        return res;
    }
}
