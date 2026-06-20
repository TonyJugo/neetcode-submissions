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
    List<int> list = new List<int>();
    public int KthSmallest(TreeNode root, int k) {
        if(root == null) return 0;
        dfs(root);
        return list[k-1];
    }
    private void dfs(TreeNode root){
        if(root == null) return;
        dfs(root.left);
        list.Add(root.val);
        dfs(root.right);
    }
}
