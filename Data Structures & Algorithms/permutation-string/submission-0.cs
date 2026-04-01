public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length > s2.Length) return false;
        int n = s1.Length;
        Dictionary<char, int> map = new Dictionary<char, int>();
        for(int i = 0; i < s1.Length; i++) {
            if(!map.ContainsKey(s1[i])) {
                map.Add(s1[i], 0);
            }
            map[s1[i]]++;
        }
        int match = 0;
        for(int i = 0; i < s2.Length; i++) {
            //incoming char
            if(map.ContainsKey(s2[i])) {
                map[s2[i]]--;
                if(map[s2[i]] == 0) {
                    match++;
                }
            }
            //outgoing char - after crossing s1.Length (n) letters
            if(i >= s1.Length && map.ContainsKey(s2[i - n])) {
                map[s2[i - n]]++;
                if(map[s2[i-n]] == 1) {
                    match--;
                }
            }
            if(match == map.Count) {
                return true;
            }
        }
        return false;
    }
}
