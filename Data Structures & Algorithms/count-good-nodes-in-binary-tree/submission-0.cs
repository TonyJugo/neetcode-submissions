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
    public int res = 0;
    public int GoodNodes(TreeNode root) {
        if(root == null) return 0;
        return dfs(root, root.val);
        
    }
    private int dfs(TreeNode root, int max){
        if(root == null) return 0;
        int goodNode = 0;
        if(root.val >= max){
            goodNode = 1;
            max = root.val;
        }
        int left = dfs(root.left, max); 
        int right = dfs(root.right, max);
        return left+right+goodNode;
    }
}
