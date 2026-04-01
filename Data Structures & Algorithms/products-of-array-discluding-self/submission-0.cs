public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] result1 = new int[n];
        int[] result2 = new int[n];
        result1[0] = 1;
        result2[n-1] = 1;
        for(int i = 1; i < n; i++) {
            result1[i] = result1[i-1] * nums[i-1];
        }
         for(int i = n-2; i >= 0; i--) {
            result2[i] = result2[i+1] * nums[i+1];
        }
        int[] result = new int[n];
        for(int i = 0; i < n; i++) {
            result[i] = result1[i] * result2[i];
        }
        return result;
    }
}
