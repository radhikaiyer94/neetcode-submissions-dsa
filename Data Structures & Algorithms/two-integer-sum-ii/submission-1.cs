public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int n = numbers.Length;
        for(int l = 0; l < n; l++) {
            int diff = target - numbers[l];
            int r = l + 1;
            while(r < n && diff > numbers[r]) {
                r++;
            }
            if(r != n && diff == numbers[r]) {
                return new int[]{l+1, r+1};
            }
        }
        return new int[]{-1, -1};
    }
}
