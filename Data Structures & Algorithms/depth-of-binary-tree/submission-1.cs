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
    public int MaxDepth(TreeNode root) {
        // if(root == null) return 0;
        // Queue<TreeNode> queue = new Queue<TreeNode>();
        // queue.Enqueue(root);
        // int deep = 0;
        // while(queue.Count > 0){
        //     deep++;
        //     int total = queue.Count;
        //     for(int i = 0; i < total; i++){
        //         TreeNode tmp = queue.Dequeue();
        //         if(tmp.left != null) queue.Enqueue(tmp.left);
        //         if(tmp.right != null) queue.Enqueue(tmp.right);
        //     }
        // }
        // return deep;
        // if(root == null) return 0;
        // return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
        if(root == null) return 0;
        Stack<(TreeNode, int)> stack = new Stack<(TreeNode, int)>();
        stack.Push((root, 1));
        int res = 0;
        while(stack.Count > 0){
            var curTuple = stack.Pop();
            TreeNode cur = curTuple.Item1;
            int curDepth = curTuple.Item2;
            res = Math.Max(res, curDepth);
            if(cur.right != null) stack.Push((cur.right, curDepth+1));
            if(cur.left != null) stack.Push((cur.left, curDepth+1)); 
        }
        return res;

    }
}
