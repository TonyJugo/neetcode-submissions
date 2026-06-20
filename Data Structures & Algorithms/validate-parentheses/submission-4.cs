public class Solution {
    public bool IsValid(string s) {
        // while(s.Contains("()") || s.Contains("[]") || s.Contains("{}")){
        //     s = s.Replace("()", "");
        //     s = s.Replace("[]", "");
        //     s = s.Replace("{}", "");
        // }
        // return s == "";
        //y tuong them dau mo vao stack
        // khi gap dau dong thi stack phai la dau mo tuong ung ko thi false
        // khi 2 dau gap nhau thi lay het dau ra trong stack => valid khi stack == 0
        Dictionary<char,char> dict = new Dictionary<char,char>(){{')', '('}, {'}','{'}, {']','['} };
        Stack<char> stack = new Stack<Char>();
        foreach(char c in s){
            if(dict.ContainsKey(c)){
                if(stack.Count > 0 && stack.Peek() == dict[c]){
                    stack.Pop();
                }else{
                    return false;
                }
            }else{
                stack.Push(c);
            }
        }
        return stack.Count == 0;

    }
}
