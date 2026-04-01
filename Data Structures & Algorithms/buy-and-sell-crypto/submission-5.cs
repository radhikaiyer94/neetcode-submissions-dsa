public class Solution {
    public int MaxProfit(int[] prices) {
        int max_profit = 0;
        int n = prices.Length;
        int buyIndex = 0;
        for(int i = 1; i <= n-1; i++) {
            if(prices[buyIndex] > prices[i]) {
                buyIndex = i;
            }
            else {
                max_profit = Math.Max(max_profit, prices[i] - prices[buyIndex]);
            }
        }

        return max_profit;
    }
}
