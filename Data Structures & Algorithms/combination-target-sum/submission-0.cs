public class Solution {
    List<List<int>> result;
    public List<List<int>> CombinationSum(int[] nums, int target) {
        result = new List<List<int>>();
        Backtrack(nums, 0, target, 0, new List<int>());
        return result;
    }

    private void Backtrack(int[] nums, int index, int target, int sum, List<int> list) {
        if (sum == target) {
            List<int> finalList = new List<int>(list);
            result.Add(finalList);
            return;
        }
        if (index >= nums.Length || sum > target) {
            return;
        }
            
        list.Add(nums[index]);
        Backtrack(nums, index, target, sum + nums[index], list);
        list.Remove(nums[index]);

        Backtrack(nums, index+1, target, sum, list);
    }
}
