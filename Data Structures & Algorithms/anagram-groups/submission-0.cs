public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
        foreach(string str in strs) {
            char[] s = str.ToCharArray();
            Array.Sort(s);
            string sortedStr = new string(s);
            if(!map.ContainsKey(sortedStr)) {
                map.Add(sortedStr, new List<string>());
            }
            map[sortedStr].Add(str);
        }
        var result = new List<List<string>>();
        int i = 0;
        foreach(KeyValuePair<string, List<string>> entry in map) {
            result.Add(new List<string>());
            foreach(string s in entry.Value) {
                result[i].Add(s);
            }
            i++;
        }
        return result;
    }
}
