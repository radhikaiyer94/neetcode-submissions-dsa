public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> freqMap = new Dictionary<int, int>();
        int min = int.MaxValue;
        int max = int.MinValue;
        for(int i = 0; i < nums.Length; i++) {
            if(!freqMap.ContainsKey(nums[i])) {
                freqMap.Add(nums[i], 0);
            }
            freqMap[nums[i]]++;
        }
        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
        foreach(KeyValuePair<int, int> entry in freqMap) {
            min = Math.Min(min, entry.Value);
            max = Math.Max(max, entry.Value);
            if(!map.ContainsKey(entry.Value)) {
                map.Add(entry.Value, new List<int>());
            }
            map[entry.Value].Add(entry.Key);
        }
        int count = 0;
        int[] result = new int[k];
        for(int i = max; i >= min && count < k; i--) {
            if(map.ContainsKey(i)) {
                foreach(int val in map[i]) {
                    if(count < k) {
                        result[count++] = val;
                    }
                }
            }
        }
        return result;
    }
}
