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
    
    public List<List<int>> LevelOrder(TreeNode root) {
        List<List<int>> result = new List<List<int>>();
        if(root == null) return result;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        int size = 0;
        int level = 0;
        queue.Enqueue(root);
        while(queue.Count > 0) {
            size = queue.Count;
            for(int i = 0; i < size; i++) {
                TreeNode cur = queue.Dequeue();
                if(result.Count < (level + 1)) {
                    result.Add(new List<int>());
                }
                result[level].Add(cur.val);
                if(cur.left != null) {
                    queue.Enqueue(cur.left);
                }
                if(cur.right != null) {
                    queue.Enqueue(cur.right);
                }   
            }
            level++;
        }
        
        return result;
    }

    // public void getLevelOrder(TreeNode root, int level) {
    //     if(root == null) return;

    //     if(result.Count < (level + 1)) {
    //         result.Add(new List<int>());
    //     }
    //     result[level].Add(root.val);

    //     getLevelOrder(root.left, level + 1);

    //     getLevelOrder(root.right, level + 1);
    // }
}
