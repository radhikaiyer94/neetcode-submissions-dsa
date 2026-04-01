public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        int maxArea = 0;
        for( int i = 0; i <= n-1; i++) {
            int left = i;
            int right = i;
            for(int j = 0; j < i; j++) {
                if(height[j] > height[left]) {
                    left = j;
                }
            }
            for(int k = i+1; k <= n-1; k++) {
                if(height[k] > height[right]) {
                    right = k;
                }
            }
            //Console.WriteLine($"{i}, {left}, {right}");
            maxArea += Math.Min(height[left], height[right]) - height[i];
            //Console.WriteLine($"{maxArea}");
        }

        return maxArea;
    }
}
