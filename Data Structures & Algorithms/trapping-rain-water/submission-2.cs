public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        if (n == 0) return 0;

        int left = 0;
        int right = n-1;
        int maxLeft = height[left];
        int maxRight = height[right];
        int maxArea = 0;
        while (left < right) {
            if (maxLeft < maxRight) { // minimum (maxLeft, maxRight)
                //move left pointer and update maxLeft
                left += 1;
                maxLeft = Math.Max(maxLeft, height[left]);
                maxArea += maxLeft - height[left];
            }
            else {
                //move right pointer and update maxRight
                right -= 1;
                maxRight = Math.Max(maxRight, height[right]);
                maxArea += maxRight - height[right];
            }
        }

        return maxArea;
    }
}
