public class Solution {
    public int CharacterReplacement(string s, int k) {
        int left = 0;
        int maxLength = 0;
        int[] charCount = new int[26];
        int maxFreqCharCount = 0;
        for(int right = 0; right < s.Length; right++) {
            charCount[s[right] - 'A']++;
            maxFreqCharCount = Math.Max(maxFreqCharCount, charCount[s[right] - 'A']);
            int charsToReplace = (right - left + 1) - maxFreqCharCount;
            if(charsToReplace > k) {
                charCount[s[left] - 'A']--;
                left++;
            }
            maxLength = Math.Max(maxLength, right - left + 1);
        }
        return maxLength;
    }
}
