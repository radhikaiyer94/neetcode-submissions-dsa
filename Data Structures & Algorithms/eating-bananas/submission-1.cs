public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int maxVal = 0;
        int n = piles.Length;
        for(int i = 0; i < n; i++) {
            maxVal = Math.Max(maxVal, piles[i]);
        }
        int low = 1;
        int high = maxVal;
        int k = maxVal;
        while(low <= high) {
            int mid = low + (high-low)/2;
            int hours = calcHours(piles, mid);
            if(hours <= h) {
                k = mid;
                high = mid - 1;
            }
            else {
                low = mid + 1;
            }
        }
        return k;
    }

    private int calcHours(int[] piles, int k) {
        int hoursRequired = 0;

        foreach(int pile in piles) {
            hoursRequired += (int)Math.Ceiling((double)pile/k);
        }

        return hoursRequired;
    }
}
