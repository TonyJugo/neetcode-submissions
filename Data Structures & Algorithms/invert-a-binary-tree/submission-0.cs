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
    public TreeNode InvertTree(TreeNode root) {
        //complexity là O(n) goi ham toi nut cuoi cung
        // if(root == null) return null;
        // TreeNode temp = root.right;
        // root.right = root.left;
        // root.left = temp;
        // InvertTree(root.left);
        // InvertTree(root.right);
        // return root;
        if(root == null) return null;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count > 0){
            TreeNode cur = queue.Dequeue();
            TreeNode temp = cur.right;
            cur.right = cur.left;
            cur.left = temp;
            if(cur.left != null)
            queue.Enqueue(cur.left);
            if(cur.right != null)
            queue.Enqueue(cur.right);
        }
        return root;
    }
}
