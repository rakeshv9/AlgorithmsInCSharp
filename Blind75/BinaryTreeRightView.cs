//Given the root of a binary tree, imagine yourself standing on the right side of it, 
//return the values of the nodes you can see ordered from top to bottom.

---------------------------------------------------------------------------------

using System.Text;

public class BinaryTreeLeftAndRightView
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
        StringBuilder result = new StringBuilder();
        //Constructor
        public BinaryTree() { }

        public string RightSideViewOfBinaryTree(Node root)
        {
            if(root == null) return string.Empty;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while(queue.Count > 0){
                int size = queue.Count;
                for(int i=0; i< size; i++){
                    Node currentNode = queue.Dequeue();
                    //You can change the order of adding nodes to the queue to print left or right view
                    //I am adding left nodes first to the queue, so I can check the last node in my queue size(rightmost node) and add it
                    if(currentNode.left != null){
                        queue.Enqueue(currentNode.left);
                    }
                    if(currentNode.right != null){
                        queue.Enqueue(currentNode.right);
                    }
                    if(i == size-1){ //append the rightmost node at each level to the stringbuilder
                        result.Append(currentNode.key + "->");
                    }
                }
             }
            return result.ToString();
        }
    }

    //Binary Tree Construction using Node class
    //        5 
    //       / \
    //      7    9
    //     /\    /\
    //   12  3  4  10


    //Right view of the binary tree is: 5->9->10

    public static void Main(string[] args)
    {
        Node root = new Node(5);
        root.left = new Node(7);
        root.right = new Node(9);
        root.left.left = new Node(12);
        root.left.right = new Node(3);
        root.right.left = new Node(4);
        root.right.right = new Node(10);

        BinaryTree btree = new BinaryTree();
        string rightView = btree.RightSideViewOfBinaryTree(root);

        Console.WriteLine($"Right view of the binary tree is: {rightView}");
    }
}
