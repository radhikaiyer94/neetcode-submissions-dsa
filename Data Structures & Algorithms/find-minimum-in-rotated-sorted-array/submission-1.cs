public class Solution {
    public int FindMin(int[] nums) {
        int n = nums.Length;
        int low = 0;
        int high = n-1;
        int res = nums[0];

        while(low <= high) {
            if(nums[low] < nums[high]) { 
                //i.e. the range of array b/w low and high is sorted
                res = Math.Min(res, nums[low]);
                break;
            }
            int mid = low + (high-low)/2;
            res = Math.Min(res, nums[mid]);
            if (nums[mid] >= nums[low]) {
                //left space is sorted, search for min in right space
                low = mid + 1;
            }
            else {
                //right space is sorted, search for min in left space
                high = mid - 1;
            }
        }
        return res;
    }
}
