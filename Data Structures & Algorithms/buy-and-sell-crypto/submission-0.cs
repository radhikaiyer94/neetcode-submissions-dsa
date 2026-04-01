public class Solution {
    public int MaxProfit(int[] prices) {
        int n = prices.Length;
        int maxProfit = 0, low = 0, high = low + 1;
        while(high < n) {
            if(prices[high] < prices[low]) {
                low++;
            }
            else {
                maxProfit = Math.Max(maxProfit, prices[high] - prices[low]);
                high++;
            }
        }
        return maxProfit;
    }
}
