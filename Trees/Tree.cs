using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
	namespace SerializationDemo
	{
		class Tree
        {
            public int Nodes;
            public List<int>[] Edges;

            Tree(int Nodes)
            {
                this.Nodes = Nodes;
                Edges = new List<int>[Nodes];
                for(int i=0; i< Edges.Length; i++)
                {
                    Edges[i] = new List<int>();
                }
            }

            public void AddEdge(int Node, int Edge)
            {
                Edges[Node].Add(Edge);
            }

            public void DFS(int startNode)
            {
                bool[] visited = new bool[Nodes];
                DFSUtil(startNode, visited);
            }

            public void DFSUtil(int node, bool[] visited)
            {
                visited[node] = true;
                Console.WriteLine("\n" +node);
                foreach (int n in Edges[node])
                {
                    if (!visited[n])
                    {
                        DFSUtil(n, visited);
                    }
                }
            }

            static void Main(string[] args)
            {
                Tree tree = new Tree(8);
				tree.AddEdge(0, 1);
				tree.AddEdge(0, 2);
				tree.AddEdge(0, 4);
				tree.AddEdge(2, 1);
				tree.AddEdge(2, 3);
				tree.AddEdge(2, 6);
				tree.AddEdge(3, 1);
				tree.AddEdge(3, 5);
				tree.AddEdge(3, 7);
				tree.AddEdge(4, 1);
				tree.AddEdge(4, 0);
				tree.AddEdge(7, 3);
				tree.AddEdge(7, 6);
				Console.WriteLine("Starting DFS Traversal at Node 0");
                tree.DFS(0);
			}
        }
    }
}
