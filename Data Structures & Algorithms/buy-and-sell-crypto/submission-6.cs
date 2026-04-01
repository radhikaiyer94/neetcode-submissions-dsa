public class Solution {
    public int MaxProfit(int[] prices) {
        int max_profit = 0;
        int buy = prices[0];

        foreach(int sell in prices) {
            max_profit = Math.Max(max_profit, sell - buy);
            buy = Math.Min(buy, sell);
        }

        return max_profit;
    }
}
