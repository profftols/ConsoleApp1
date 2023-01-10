using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Node<T>
    {
        public Node (T item)
        {
            Item = item;
        }
        public T Item { get; set; }
        public Node<T> NextItem { get; set; }
        public Node<T> PrevItem { get; set; }
    }
}
