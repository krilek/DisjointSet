using System;
using System.Collections.Generic;
using System.Text;

namespace DisjointSet
{
    public class Node<T> where T : struct
    {
        public T Key { get; private set; }
        public Node<T> Parent { get; set; }
        public int Rank { get; set; }
        public Node(T key)
        {
            Key = key;
            Parent = this;
            Rank = 0;
        }

        public override string ToString()
        {
            return ToString(this);
        }
        private string ToString(Node<T> node)
        {
            if(node.Parent != node)
            {
                return $"{node.Key} - {ToString(node.Parent)}";
            }
            else
            {
                return $"{node.Key}";
            }
        }
    }
}
