public class Solution {
    public bool IsValid(string s) {
        // while(s.Contains("[]") || s.Contains("{}") || s.Contains("()")){
        //     s = s.Replace("[]", "");
        //     s = s.Replace("()", "");
        //     s = s.Replace("{}", "");
        // }
        // return s == string.Empty;
        Dictionary<char,char> dict = new Dictionary<char,char>(){ {')','('}, {']', '['}, {'}','{'}};
        Stack<char> stack = new Stack<char>();
        foreach(char c in s){
            //gap ngoac mo thi them vao stack
            if(!dict.ContainsKey(c)){
                stack.Push(c);
            }
            //gap ngoac dong thi pop ra
            if(dict.ContainsKey(c)){
                if(stack.Count > 0 && stack.Peek() == dict[c])
                stack.Pop();
                else{
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
}
