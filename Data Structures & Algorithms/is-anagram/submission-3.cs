public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        Dictionary<char, int> map = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++) {
            if(!map.ContainsKey(s[i])) {
                map.Add(s[i], 0);
            }
            map[s[i]]++;
            
            if(!map.ContainsKey(t[i])) {
                map.Add(t[i], 0);
            }
            map[t[i]]--;
        }

        foreach(var val in map) {
            if(val.Value != 0) return false;
        }
        
        return true;
    }
}
