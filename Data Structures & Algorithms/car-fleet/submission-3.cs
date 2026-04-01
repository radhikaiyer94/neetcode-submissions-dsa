public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length;
        int[][] pairs = new int[n][];
        for(int i = 0; i < n; i++) {
            pairs[i] = new int[2] {position[i], speed[i]}; 
        }
        Array.Sort(pairs, (a,b)=> b[0].CompareTo(a[0]));
        Stack<float> stack = new Stack<float>();
        for(int i = 0; i < n; i++) {
            var curr = (float)(target - pairs[i][0])/pairs[i][1];
            if(stack.Count > 0 && curr <= stack.Peek()) {
                continue;
            }
            stack.Push(curr);
        }
        return stack.Count;
    }
}
