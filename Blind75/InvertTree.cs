
// Given the root of a binary tree, invert the tree, and return its root.
// Example 1:
// Input: root = [4,2,7,1,3,6,9]
// Output: [4,7,2,9,6,3,1]


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
  //Iterative Version
    public TreeNode InvertTree(TreeNode root) {
        if(root == null)
            return root;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count > 0){
            TreeNode node = queue.Dequeue();
            TreeNode temp = node.left;
            node.left = node.right;
            node.right = temp;
            if(node.left != null){
                queue.Enqueue(node.left);
            }
            if(node.right != null){
                queue.Enqueue(node.right);
            }
        }
        return root;
    }
 
  //Recursive Version
     public TreeNode InvertTree(TreeNode root) {
        if(root == null)
            return root;
        TreeNode left = InvertTree(root.left);
        TreeNode right = InvertTree(root.right);
        root.left = right;
        root.right = left;
        return root;
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

      TreeNode newRoot = obj.InvertTree(root);
    }
  }
