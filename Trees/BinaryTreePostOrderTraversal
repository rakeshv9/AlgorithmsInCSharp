using System.Text;

public class BinaryTreePostOrderTraversal
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

        public string PostOrderTraversal(Node root)
        {
            PostOrder(root, sb);
            return sb.ToString();
        }

        public void PostOrder(Node root, StringBuilder sb){
                if(root == null)
                    return;

                PostOrder(root.left, sb);
                PostOrder(root.right, sb);
                sb.Append(root.key + "->");
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

    //PostOrder Traversal is: 12->3->7->13->1->4->10->9->5

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
        string postOrder = btree.PostOrderTraversal(root);

        Console.WriteLine($"PostOrder Traversal is: {postOrder}");
    }
}
