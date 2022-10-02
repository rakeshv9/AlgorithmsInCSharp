
// Given the root of a binary tree, return its maximum depth.
// A binary tree's maximum depth is the number of nodes along the longest path from the root 
// node down to the farthest leaf node.

// Example 1:

// Input: root = [3,9,20,null,null,15,7]
// Output: 3


public class Blind75Questions
{  
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
  
 public int MaxDepth(TreeNode root) {
       if(root == null){
        return 0;
       }

       Queue<TreeNode> queue = new Queue<TreeNode>();
       queue.Enqueue(root);
       int maxDepth = 0;
       while(queue.Count > 0){
           int size = queue.Count;
           for(int i=0; i< size; i++){
                TreeNode node = queue.Dequeue();
                if(node.left != null)
                    queue.Enqueue(node.left);
                if(node.right != null)
                    queue.Enqueue(node.right);
           }
            maxDepth++;
       }
       return maxDepth; 
    }
    
    public static void Main(string[] args)
    {
      Blind75Questions obj = new Blind75Questions();
      TreeNode root = new TreeNode(4);
      root.left = new TreeNode(2);
      root.right = new TreeNode(7);
      root.left.left = new TreeNode(1);
      root.left.right = new TreeNode(3);
      root.right.left = new TreeNode(6);
      root.right.right = new TreeNode(9);
      root.left.left.left = new TreeNode(10);

      int maxDepth = obj.MaxDepth(root);
      Console.WriteLine("Max depth of given binary tree is:" + maxDepth);
    }
  }
