public class MinStack {
    private Stack<int> stack = null;
    private Stack<int> minStack = null;
    public MinStack() {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
        if(minStack.Count > 0){
            if(minStack.Peek() >= val){
                minStack.Push(val);
            }
        }else{
            minStack.Push(val);
        }
    }
    
    public void Pop() {
        if(stack.Count > 0) 
        {
            int val = stack.Pop();
            if(minStack.Count > 0 && minStack.Peek() == val){
                minStack.Pop();
            }
        }
    }
    
    public int Top() {
        if(stack.Count > 0) return stack.Peek();
        return -1;
    }
    
    public int GetMin() {
        // int min = int.MaxValue;
        // Stack<int> tmp = new Stack<int>();
        // while(stack.Count > 0){
        //     tmp.Push(stack.Peek());
        //     min = Math.Min(min, stack.Pop());
        // } 
        // while(tmp.Count > 0){
        //     stack.Push(tmp.Pop());
        // }    
        // return min;
        if(minStack.Count > 0) return minStack.Peek();
        return -1;
    }
}
