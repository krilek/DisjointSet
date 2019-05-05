using System;
using System.Collections.Generic;
using static DisjointSet.KruskalAlgorithm;

namespace DisjointSet
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Node<int>> sets = new List<Node<int>>();
            for (int i = 0; i < 10; i++)
            {
                sets.Add(new Node<int>(i));
                Console.WriteLine(sets[i].ToString());
            }
            List<Tuple<int, int>> tuples = new List<Tuple<int, int>>
            {
                new Tuple<int, int>(1,2),
                new Tuple<int, int>(3,4),
                new Tuple<int, int>(5,4),
                new Tuple<int, int>(1,5),
                new Tuple<int, int>(6,7),
                new Tuple<int, int>(8,9),
                new Tuple<int, int>(6,8),
                new Tuple<int, int>(7,4),
                //
                //new Tuple<int, int>(0,1),
                //new Tuple<int, int>(2,3),
                //new Tuple<int, int>(1,2),
                //new Tuple<int, int>(5,6),
                //new Tuple<int, int>(7,8),
                //new Tuple<int, int>(3,5),
                //new Tuple<int, int>(0,7),
                
            };
            foreach (Tuple<int,int> tuple in tuples)
            {
                DisjointSet<int>.Union(DisjointSet<int>.FindSet(sets[tuple.Item1]), DisjointSet<int>.FindSet(sets[tuple.Item2]));
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(sets[i].ToString());
            }
            Console.WriteLine("Kruskal Algorithm: ");
            // KruskalTests
            /*    10 
                0--------1 
                |  \     | 
               6|   5\   |15 
                |      \ | 
                2--------3 
                    4       */
            Console.WriteLine(@"
            10 
        0--------1 
        |  \     | 
       6|   5\   |15 
        |      \ | 
        2--------3 
             4       ");
            List<Edge> edges = new List<Edge>
            {
                new Edge(0,1,10),
                new Edge(0,2,6),
                new Edge(0,3,5),
                new Edge(1,3,15),
                new Edge(2,3,4)
            };
            Kruskal(4, edges);

            Console.Write("New Graph\n");
            //Graph in file

            List<Edge> edges2 = new List<Edge>
            {
                new Edge(0,1,4),
                new Edge(0,7,8),

                new Edge(1,7,11),
                new Edge(1,2,8),

                new Edge(2,3,7),
                new Edge(2,8,2),
                new Edge(2,5,4),

                new Edge(3,4,9),
                new Edge(3,5,14),

                new Edge(4,5,10),

                new Edge(5,6,2),

                new Edge(6,7,1),
                new Edge(6,8,6),

                new Edge(7,8,7),
            };
            Kruskal(9, edges2);

        }
    }
}
