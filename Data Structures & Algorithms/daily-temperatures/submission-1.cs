public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int[]> stack = new Stack<int[]>();
        int[] result = new int[temperatures.Length];
        for(int i = 0; i < temperatures.Length; i++) {
            while(stack.Count > 0 && temperatures[i] > stack.Peek()[0]) {
                int[] popped = stack.Pop();
                result[popped[1]] = i - popped[1];
            }
            stack.Push(new int[2]{temperatures[i], i});
        }
        return result;
    }
}
