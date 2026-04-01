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
    List<List<int>> result;
    public List<List<int>> LevelOrder(TreeNode root) {
        result = new List<List<int>>();
        getLevelOrder(root, 0);
        return result;
    }

    public void getLevelOrder(TreeNode root, int level) {
        if(root == null) return;

        if(result.Count < (level + 1)) {
            result.Add(new List<int>());
        }
        result[level].Add(root.val);

        getLevelOrder(root.left, level + 1);

        getLevelOrder(root.right, level + 1);
    }
}
