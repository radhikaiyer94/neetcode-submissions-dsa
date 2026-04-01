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
    public int maxLevel = 0;
    public int MaxDepth(TreeNode root) {
        if(root != null) {
            findMaxDepth(root,0);
        }
        return maxLevel;
    }

    public void findMaxDepth(TreeNode root, int level) {
        if(root == null) {
            maxLevel = Math.Max(maxLevel, level);
            return;
        }

        findMaxDepth(root.left, level + 1);

        findMaxDepth(root.right, level + 1);
    }
}
