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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root == q || root == p || root == null) return root;
        TreeNode leftA = LowestCommonAncestor(root.left, p, q);
        TreeNode rightA = LowestCommonAncestor(root.right, p, q);
        if(leftA != null && rightA != null) return root;
        return leftA != null ? leftA : rightA;
    }
}
