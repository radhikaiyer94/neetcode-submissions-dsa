public class MinStack {

    Stack<int> st;
    Stack<int> minSt;
    public MinStack() {
        this.st = new Stack<int>();
        this.minSt = new Stack<int>();
    }
    
    public void Push(int val) {
        st.Push(val);
        var minVal = Math.Min(val, minSt.Count == 0? val : minSt.Peek());
        minSt.Push(minVal);
    }
    
    public void Pop() {
        st.Pop();
        minSt.Pop();
    }
    
    public int Top() {
        return st.Peek();
    }
    
    public int GetMin() {
        return minSt.Peek();
    }
}
