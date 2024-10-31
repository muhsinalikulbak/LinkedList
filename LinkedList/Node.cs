using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Node<T>
    {
        private T content;
        private Node<T> next;
        public Node(T content)
        {
            this.content = content;
            this.next = null;
        }

        public T Content { get => content; set => content = value; }
        public Node<T> Next { get => next; set => next = value; }
    }
}