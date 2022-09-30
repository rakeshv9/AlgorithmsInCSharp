//Given the root of a binary tree, return the level order traversal of its nodes' values.
//(i.e., from left to right, level by level).

----------------------------------------------------------------------------------------



 // Definition for a binary tree node.
  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }
  
public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var result = new List<IList<int>>();
        if(root == null)
            return result;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count > 0){
            int size = queue.Count;
            List<int> currentLevelNodes = new List<int>();
            for(int i=0; i< size; i++){ //loop through nodes at each level
                TreeNode node = queue.Dequeue();
                currentLevelNodes.Add(node.val);
                if(node.left != null) //append left node it it not null
                 {
                     queue.Enqueue(node.left);
                }
                if(node.right != null) //append left node it it not null
                 {
                  queue.Enqueue(node.right);
                 }
            }
             result.Add(currentLevelNodes); //at the end of each level, append all nodes to result
        }
        return result;
    }
}
