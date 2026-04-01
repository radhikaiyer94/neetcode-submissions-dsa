public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0) return 0;
        int maxLen = 1;
        Array.Sort(nums);
        int currLen = 1;
        for(int i = 1; i < nums.Length; i++) {
            if(nums[i] == nums[i-1]) {
                continue;
            }
            if(nums[i] - nums[i-1] == 1) {
                currLen++;
                maxLen = Math.Max(currLen, maxLen);
            }
            else {
                currLen = 1;
            }
        }
        return maxLen;
    }
}
