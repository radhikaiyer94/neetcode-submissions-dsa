public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>(nums);
        int maxLen = 0;
        int curLen = 0;
        for(int i = 0; i < nums.Length; i++) {
            if(!set.Contains(nums[i] - 1)) {
                while(set.Contains(nums[i] + curLen)) {
                    curLen++;
                }
                maxLen = Math.Max(curLen, maxLen);
            }
            curLen = 0;
        }
        return maxLen;
    }
}
