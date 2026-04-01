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
    int maxLength = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        if(root == null) return 0;

        findDiameter(root);
        return maxLength;
    }

    public int findDiameter(TreeNode root) {
        if(root == null) {
            return 0;
        }

        int left = findDiameter(root.left);

        int right = findDiameter(root.right);

        maxLength = Math.Max(maxLength, left + right);
        return Math.Max(left, right) + 1;
    }

}
