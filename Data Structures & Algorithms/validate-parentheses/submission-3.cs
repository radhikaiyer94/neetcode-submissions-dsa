public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new Stack<char>();
        Dictionary<char, char> map = new Dictionary<char, char>();
        map.Add(')', '(');
        map.Add('}', '{');
        map.Add(']', '[');
        foreach(char c in s)  {
            if(!map.ContainsKey(c)) {
                st.Push(c);
            }
            else if(st.Count > 0 && st.Peek() == map[c]) {
                st.Pop();
            }
            else {
                return false;
            }
        }   
        return (st.Count() == 0);
    }
}
