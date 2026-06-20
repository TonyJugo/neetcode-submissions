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
    public bool IsBalanced(TreeNode root) {
        // if(root == null) return true;
        // Queue<TreeNode> queue = new Queue<TreeNode>();
        // queue.Enqueue(root);
        // int height = -1;
        // while(queue.Count > 0){
        //     TreeNode cur = queue.Dequeue();
        //     int leftHigh = getHeight(cur.left);
        //     int rightHigh = getHeight(cur.right);
        //     if(Math.Abs(rightHigh - leftHigh) > 1) return false;
        //     if(cur.left != null) queue.Enqueue(cur.left);
        //     if(cur.right != null) queue.Enqueue(cur.right);
        // }
        // return true;
        if(root == null) return true;
        if(Math.Abs(getHeight(root.left)-getHeight(root.right)) > 1){
            return false;
        }
        return IsBalanced(root.left) && IsBalanced(root.right);
    }
    public int getHeight(TreeNode root){
        if(root == null) return 0;
        //chieu cao se bang do sau
        return Math.Max(getHeight(root.left), getHeight(root.right)) + 1;
    }
}
