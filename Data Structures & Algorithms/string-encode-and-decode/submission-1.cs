public class Solution {

    public string Encode(IList<string> strs) {
        // 1.encode thành number+#+string
        // if(strs.Count == 0) return "";
        // int[] sizes = new int[strs.Count];
        // for(int i = 0; i < strs.Count; i++){
        //     sizes[i] = strs[i].Length;
        // }
        // string result = "";
        // foreach(var size in sizes){
        //     result += size.ToString() + ',';
        // }
        // result += "#";
        // foreach(var str in strs){
        //     result += str;
        // }
        // return result;
        //2. encode thành number#string + number#string
        string res = "";
        foreach(var str in strs){
            res = res + str.Length + "#" + str;
        }
        return res;
    }

    public List<string> Decode(string s) {
        //decode 1
    //    if(s.Length == 0) return new List<string>();
    //    List<int> sizes = new List<int>();
    //    List<string> res = new List<string>();
    //    int i = 0;
    //    string cur = "";
    //    while(s[i] != '#'){
    //     cur = "";
    //     while(s[i] != ','){
    //         cur += s[i];
    //         i++;
    //     }
    //     sizes.Add(int.Parse(cur));
    //     i++;
    //    }
    //    i++;
    //    foreach(var size in sizes){
    //     res.Add(s.Substring(i, size));
    //     i += size;
    //    }
    //    return res;
    // decode 2
    if(s.Length == 0) return new List<string>();
    List<string> res = new List<string>();
    int i = 0;
    int j = 0;
    while(i < s.Length){
        j = i;
        while(s[j] != '#'){
            j++;
        }
        int size = int.Parse(s.Substring(i,j-i));
        string toAdd = s.Substring(j+1,size);
        res.Add(toAdd);
        i += j-i+1+toAdd.Length;
    }
    return res;

   }
}
