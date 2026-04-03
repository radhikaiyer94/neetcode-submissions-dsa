public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int maxArea = 0;

        for(int i = 0; i < heights.Length; i++) {
            int minHeight = heights[i];
            for(int j = i; j >= 0; j--) {
                minHeight = Math.Min(minHeight, heights[j]);
                int currArea = minHeight * (i - j + 1);
                maxArea = Math.Max(maxArea, currArea);
            }
        }

        return maxArea;
    }
}
