/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public bool IsValidBST(TreeNode root) {
        List<int> res = new List<int>();
        dfs(root, res);
        for(int i = 0; i < res.Count - 1; i++) {
            if(res[i+1] <= res[i]) {
                return false;
            }
        }
        return true;
    }

    public void dfs(TreeNode root, List<int> values) {
        if(root == null) return;

        dfs(root.left, values);
        values.Add(root.val);
        dfs(root.right, values);
    }
}
