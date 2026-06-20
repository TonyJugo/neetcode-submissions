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
    public List<int> RightSideView(TreeNode root) {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        if(root == null) return [];
        queue.Enqueue(root);
        List<int> res = new List<int>();
        while(queue.Count > 0){
            int levelSize = queue.Count;
            for(int i = 0; i < levelSize; i++){
                TreeNode cur = queue.Dequeue();
                if(i == levelSize-1) res.Add(cur.val);
                if(cur.left != null) queue.Enqueue(cur.left);
                if(cur.right != null) queue.Enqueue(cur.right);
            }
        }
        return res;
    }
}
