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
    private int maxDiameter = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        if(root == null) return 0;
        MaxDepth(root);
        return maxDiameter;
    }
    public int MaxDepth(TreeNode root){
        if(root == null) return 0;
        int leftDepth = MaxDepth(root.left);
        int rightDepth = MaxDepth(root.right);
        maxDiameter = Math.Max(maxDiameter, leftDepth + rightDepth);
        return Math.Max(leftDepth, rightDepth) + 1;
    }
}
