public class Solution {
    public bool IsValidSudoku(char[][] board) {
        Dictionary<int, HashSet<char>> rows = new Dictionary<int, HashSet<char>>();
        Dictionary<int, HashSet<char>> cols = new Dictionary<int, HashSet<char>>();
        Dictionary<int, HashSet<char>> grids = new Dictionary<int, HashSet<char>>();
        for(int i = 0; i < 9; i++) {
            for(int j = 0; j < 9; j++) {
                if(board[i][j] == '.') {
                    continue;
                }
                if(rows.TryGetValue(i, out var rSet) && rSet.Contains(board[i][j]) ||
                cols.TryGetValue(j, out var cSet) && cSet.Contains(board[i][j]) ||
                grids.TryGetValue(((i/3)*3+(j/3)), out var gSet) && gSet.Contains(board[i][j]))
                {
                    return false;
                }
                rows.TryAdd(i, new HashSet<char>());
                cols.TryAdd(j, new HashSet<char>());
                grids.TryAdd(((i/3)*3+(j/3)), new HashSet<char>());
                rows[i].Add(board[i][j]);
                cols[j].Add(board[i][j]);
                grids[((i/3)*3+(j/3))].Add(board[i][j]);
            }
        }
        return true;
    }
}
