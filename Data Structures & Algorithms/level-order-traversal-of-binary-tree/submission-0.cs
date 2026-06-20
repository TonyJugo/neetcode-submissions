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
    public List<List<int>> LevelOrder(TreeNode root) {
        if(root == null) return [];
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        List<List<int>> res = new List<List<int>>();
        int level = -1;
        while(queue.Count > 0){
            level++;
            int levelSize = queue.Count;
            List<int> levelList = new List<int>();
            for(int i = 0; i < levelSize; i++){
                TreeNode cur = queue.Dequeue();
                levelList.Add(cur.val);
                if(cur.left != null) queue.Enqueue(cur.left);
                if(cur.right != null) queue.Enqueue(cur.right);
            }
            res.Add(levelList);
        }
        return res;
    }
}
