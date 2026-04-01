public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int low = 0, high = rows * cols - 1;
        while(low <= high) {
            int mid = low + (high - low)/2;
            int cr = mid / cols;
            int cc = mid % cols;
            if(matrix[cr][cc] == target) {
                return true;
            }
            else if(matrix[cr][cc] > target) {
                high = mid - 1;
            }
            else {
                low = mid + 1;
            }
        }
        return false;
    }
}
