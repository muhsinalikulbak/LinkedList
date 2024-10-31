using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedList<T>
    {
        private Node<T> head = null;

        public void AddFirst(T content)
        {
            if (head is null)
            {
                head = new Node<T>(content);
                return;
            }
            Node<T> node = new Node<T>(content);
            node.Next = head;
            head = node;
        }
        public void AddLast(T content)
        {
            if (head is null)
            {
                head = new Node<T>(content);
                return;
            }
            Node<T> node = new Node<T>(content);
            var last = lastNode();
            last.Next = node;
        }
        public void DeleteFirst()
        {
            if (head is null)
                return;
            head = head.Next;
        }
        public void DeleteLast()
        {
            if (head is null)
                return;
            var last = head;
            var prev = head;
            while (last.Next is not null)
            {
                prev = last;
                last = last.Next;
            }
            prev.Next = null;
        }
        private Node<T> lastNode()
        {
            var last = head;
            while (last.Next is not null)
            {
                last = last.Next;
            }
            return last;
        }
        public void Iterator()
        {
            if (head is null)
                return;
            var temp = head;
            while (temp is not null)
            {
                Console.WriteLine(temp.Content);
                temp = temp.Next;
            }
        }
    }
}
