public class Solution {
    public int Search(int[] nums, int target) {
        int n = nums.Length;
        int low = 0;
        int high = n-1;

        while (low <= high) {
            int mid = low + (high-low)/2;
            if (nums[mid] == target) {
                return mid;
            }
            else if (target < nums[mid]) {
                if(target >= nums[low] || nums[low] > nums[mid]) {
                    high = mid - 1;
                }
                else {
                    low = mid + 1;
                }
            }
            else {
                if(target <= nums[high] || nums[high] < nums[mid]) {
                    low = mid + 1;
                }
                else 
                {
                    high = mid - 1;
                }
            }
        }

        return -1;
    }
}
