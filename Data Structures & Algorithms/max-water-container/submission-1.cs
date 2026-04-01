public class Solution {
    public int MaxArea(int[] heights) {
        int n = heights.Length;
        int i = 0, j = n-1;
        int max = int.MinValue;
        while(i < j) {
            int area = Math.Min(heights[i], heights[j]) * (j - i);
            max = Math.Max(max, area);
            if(heights[i] <= heights[j]) {
                i++;
            }
            else {
                j--;
            }
            // else {
            //     i++;
            //     j--;
            // }
        }
        return max;
    }
}
