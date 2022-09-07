using System.Text;

public class BinaryTreeLevelOrder
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
        public BinaryTree() { }

        public List<List<int>> LevelOrder(Node root) {
            var result = new List<List<int>>();
            if(root == null) return result;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            
            while(queue.Count > 0){
            int size = queue.Count; 
            List<int> currentLevelNodes = new List<int>();
            for(int i=0; i< size; i++){
                Node currentNode = queue.Dequeue();
                currentLevelNodes.Add(currentNode.key);
                if(currentNode.left != null)
                    queue.Enqueue(currentNode.left);
                if(currentNode.right != null)
                    queue.Enqueue(currentNode.right);    
                }
                result.Add(currentLevelNodes);
            }
            return result;
        }
    }

    //Binary Tree Construction using Node class
    //        5 
    //       / \
    //      7    9
    //     /\    /\
    //   12  3  4  10


    //Level Order Taraversal of the Binary Tree is: [[5], [7, 9], [12, 3, 4, 10]]

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
        var levelOrder = btree.LevelOrder(root);

        Console.WriteLine("Level order traversal of the binary tree is:");
           foreach (var sublist in levelOrder)
        {
            foreach (var value in sublist)
            {
                Console.Write(value);
                Console.Write("->");
            }
            Console.WriteLine();
        }
    }
}
