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
        if(root == null) return true;
        return dfs(root, int.MinValue, int.MaxValue);
    }
    private bool dfs(TreeNode root, int min, int max){
        if(root == null) return true;
        if(root.val <= min || root.val >= max) return false;
        bool left = dfs(root.left, min, root.val);
        bool right = dfs(root.right, root.val, max);
        return left && right;
    }
}
