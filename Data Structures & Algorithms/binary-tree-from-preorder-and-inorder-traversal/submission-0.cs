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
    private int preorderIndex = 0;
    private Dictionary<int, int> dict = new Dictionary<int,int>();
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        for(int i = 0; i < inorder.Length; i++){
            dict[inorder[i]] = i; 
        }
        return BuildTree(preorder, 0, inorder.Length-1);
    }   
    private TreeNode BuildTree(int[] preorder, int left, int right){
        if(left > right) return null;
        int rootVal = preorder[preorderIndex];
        preorderIndex++;
        TreeNode root = new TreeNode(rootVal);
        int inorderIndex = dict[rootVal];
        root.left = BuildTree(preorder, left, inorderIndex-1);
        root.right = BuildTree(preorder, inorderIndex+1, right);
        return root;
    }
}
