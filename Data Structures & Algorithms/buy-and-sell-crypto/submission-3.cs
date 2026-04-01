public class Solution {
    public int MaxProfit(int[] prices) {
        int max_profit = 0;
        int n = prices.Length;

        for(int i = 0; i < n-1; i++) {
            int profit = 0;
            for(int j = i+1; j < n; j++) {
                if(prices[j] > prices[i]) {
                    profit = Math.Max(profit, prices[j] - prices[i]);
                }
            }
            max_profit = Math.Max(max_profit, profit);
        }

        return max_profit;
    }
}
