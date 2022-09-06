using System.Text;

public class BinaryTreeInOrderTraversal
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

        public string InOrderTraversal(Node root)
        {
            InOrder(root, sb);
            return sb.ToString();
        }

        public void InOrder(Node root, StringBuilder sb){
                if(root == null)
                    return;
                InOrder(root.left, sb);
                sb.Append(root.key + "->");
                InOrder(root.right, sb);
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

    //InOrder Traversal is: 12->7->3->5->13->4->1->9->10

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
        string inOrder = btree.InOrderTraversal(root);
        //Print inorder traversal
        Console.WriteLine($"InOrder Traversal is: {inOrder}");
    }
}
