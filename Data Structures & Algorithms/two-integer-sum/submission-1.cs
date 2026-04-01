public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] res = new int[2];
        Dictionary<int, int> map = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++) {
            int diff = target - nums[i];
            if(map.ContainsKey(diff)) {
                res[0] = map[diff];
                res[1] = i;
                return res;
            }
            if(!map.ContainsKey(nums[i])) {
                map.Add(nums[i], i);
            }
        }
        
        return res;
    }
}
