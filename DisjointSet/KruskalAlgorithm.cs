using System;
using System.Collections.Generic;
using System.Linq;

namespace DisjointSet
{
    public class KruskalAlgorithm
    {
        public class Edge
        {
            public readonly int U, V, Weight;

            public Edge(int u, int v, int weight)
            {
                U = u;
                V = v;
                Weight = weight;
            }

            public override string ToString()
            {
                return $"{U} - W:{Weight} - {V}";
            }
        }
        public static void Kruskal(int amountOfVertices, List<Edge> E)
        {
            List<Node<int>> V = new List<Node<int>>();
            for (int i = 0; i < amountOfVertices; i++)
            {
                V.Add(new Node<int>(i));
            }
            //Sort edges by their weight
            E = E.OrderBy(e => e.Weight).ToList();
            foreach (Edge edge in E)
            {
                Node<int> ru = DisjointSet<int>.FindSet(V[edge.U]);
                Node<int> rv = DisjointSet<int>.FindSet(V[edge.V]);
                if(ru != rv)
                {
                    Console.WriteLine(edge);    
                    DisjointSet<int>.Union(ru, rv);
                }
            }
        }

    }
}
