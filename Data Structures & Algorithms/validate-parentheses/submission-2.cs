public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new Stack<char>();
        if(s.Length > 0 && s.Length % 2 == 0) {
            for(int i = 0; i < s.Length; i++) {
                if(s[i] == '(' || s[i] == '{' || s[i] == '[') {
                    st.Push(s[i]);
                }
                else if(s[i] == ')' && st.Count() > 0 && st.Peek() == '(') {
                    st.Pop();
                }
                else if(s[i] == '}' && st.Count() > 0 && st.Peek() == '{') {
                    st.Pop();
                }
                else if(s[i] == ']' && st.Count() > 0 && st.Peek() == '[') {
                    st.Pop();
                }
                else {
                    return false;
                }
            }
        }
        else {
            return false;
        }
        return (st.Count() == 0);
    }
}
