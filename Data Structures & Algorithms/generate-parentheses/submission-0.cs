public class Solution {  
    public List<string> GenerateParenthesis(int n) {
        List<string> result = new List<string>();
        BackTrack(n, 0, 0, "", result);
        return result;
    }

    private void BackTrack(int n, int opened, int closed, string cur, List<string> res) {
        if(opened == closed && opened == n) {
            res.Add(cur);
            return;
        }

        if(opened < n) {
            BackTrack(n, opened+1, closed, cur + "(", res);
        }
        if(closed < opened) {
            BackTrack(n, opened, closed + 1, cur + ")", res);
        }
    }
}
