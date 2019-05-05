using System;
using System.Collections.Generic;
using System.Text;

namespace DisjointSet
{
    public static class DisjointSet<T> where T : struct
    {
        public static Node<T> FindSet(Node<T> x)
        {
            if (x != x.Parent)
            {
                x.Parent = FindSet(x.Parent);
            }
            return x.Parent;
        }
        public static void Union(Node<T> x, Node<T> y)
        {
            var xRoot = x;
            var yRoot = y;
            if (xRoot == yRoot) return;
            
            if(xRoot.Rank < yRoot.Rank)
            {
                var temp = xRoot;
                xRoot = yRoot;
                yRoot = temp;
            }
            yRoot.Parent = xRoot;
            if(xRoot.Rank == yRoot.Rank)
            {
                xRoot.Rank++;
            }
        }
    }
}
