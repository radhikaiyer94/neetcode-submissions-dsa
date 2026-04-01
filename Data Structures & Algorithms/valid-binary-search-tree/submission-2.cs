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
    int prev;
    public bool IsValidBST(TreeNode root) {
        this.prev = Int32.MinValue;
        return ValidateBST(root);
    }

    public bool ValidateBST(TreeNode root) {
        if(root == null) return true;

        bool left = ValidateBST(root.left);
        if(prev >= root.val) {
            return false;
        }
        prev = root.val;

        return left && ValidateBST(root.right);
    }
}
