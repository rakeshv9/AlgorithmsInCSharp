// Given the root of a binary tree, determine if it is a valid binary search tree (BST).
// A valid BST is defined as follows:

// The left subtree of a node contains only nodes with keys less than the node's key.
// The right subtree of a node contains only nodes with keys greater than the node's key.
// Both the left and right subtrees must also be binary search trees.

// Input: root = [2,1,3]
// Output: true

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
    List<int> sortedlist = new List<int>();
    public bool IsValidBST(TreeNode root) {
      BuildSortedList(root); 
      //performing inorder traversal on BST gives an array/list with sorted values

     //traverse the list and check whether the elements are in sorted order or not
      for(int i=0; i< sortedlist.Count - 1; i++){
          if(sortedlist[i] >= sortedlist[i+1]){
              return false;
          }
      }
      return true;
    }

    public void BuildSortedList(TreeNode node){
        //Below code is basically performing inorder traversal on given BST
        if(node == null) return;
        BuildSortedList(node.left);
        sortedlist.Add(node.val);
        BuildSortedList(node.right);
    }

    public static void Main(string[] args)
    {
      Blind75Questions obj = new Blind75Questions();
      TreeNode root = new TreeNode(7);
      root.left = new TreeNode(5);
      root.right = new TreeNode(9);
      root.left.left = new TreeNode(3);
      root.left.right = new TreeNode(6);
      root.right.left = new TreeNode(8);
      root.right.right = new TreeNode(10);

      bool isValidBST = obj.IsValidBST(root);
      Console.WriteLine("Given BST is a valid BST:" + isValidBST);
    }
  }
