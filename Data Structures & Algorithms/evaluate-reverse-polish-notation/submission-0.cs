public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        for(int i = 0; i < tokens.Length; i++) {
           
            if(tokens[i] == "+") {
                int val1 = stack.Pop();
                int val2 = stack.Pop();
                stack.Push(val1 + val2);
            }
            else if(tokens[i] == "*") {
                int val1 = stack.Pop();
                int val2 = stack.Pop();
                stack.Push(val1 * val2);
            }
            else if(tokens[i] == "-") {
                int val2 = stack.Pop();
                int val1 = stack.Pop();
                stack.Push(val1 - val2);
            }
            else if(tokens[i] == "/") {
                int val2 = stack.Pop();
                float val1 = stack.Pop();
                stack.Push((int)(val1 / val2));
            }
            else {
                stack.Push(int.Parse(tokens[i]));
            }
        }
        return stack.Pop();
    }
}
