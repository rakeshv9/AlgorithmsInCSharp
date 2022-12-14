using System.Text;

public class BinaryTreePreOrderTraversal
{
    public class Node
    {
        public int key;
        public Node left, right;

        public Node(int item)
        {
            key = item;
            left = right = null;
        }
    }
    
    public class BinaryTree 
    {
        StringBuilder sb = new StringBuilder();
        //Constructor
        public BinaryTree() { }

        public string PreOrderTraversal(Node root)
        {
            PreOrder(root, sb);
            return sb.ToString();
        }

        public void PreOrder(Node root, StringBuilder sb){
                if(root == null)
                    return;

                sb.Append(root.key + "->");
                PreOrder(root.left, sb);
                PreOrder(root.right, sb);
        }
    }

    //Binary Tree Construction using Node class
    //        5
    //       / \
    //      7    9
    //     /\    /\
    //   12  3  4  10
    //          /\
    //        13  1

    //Preorder Traversal is: 5->7->12->3->9->4->13->1->10

    public static void Main(string[] args)
    {
        Node root = new Node(5);
        root.left = new Node(7);
        root.right = new Node(9);
        root.left.left = new Node(12);
        root.left.right = new Node(3);
        root.right.left = new Node(4);
        root.right.right = new Node(10);
        root.right.left.left = new Node(13);
        root.right.left.right = new Node(1);

        BinaryTree btree = new BinaryTree();
        string preOrder = btree.PreOrderTraversal(root);

        Console.WriteLine($"PreOrder Traversal is: {preOrder}");
    }
}
