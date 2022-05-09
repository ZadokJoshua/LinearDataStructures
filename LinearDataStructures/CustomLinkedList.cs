using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    public class CustomLinkedList<T>
    {
        public ListNode<T> Head { get; set; }
        public ListNode<T> Tail { get; set; }

        public void AddItem(T item)
        {
            if (Head is null)
            {
                Head = Tail = new ListNode<T>(item);
            }
            else
            {
                var temp = Tail;
                var newNode = new ListNode<T>(item, temp);
                Tail.NextNode = newNode;
                Tail = newNode;
            }
        }

        public void AddNode(ListNode<T> node)
        {
            if (Head is null)
            {
                Head = Tail = node;
            }
            else
            {
                Tail.NextNode = node;
                Tail = node;
            }
        }

        // AddFirst Method
        public void AddFirst(T item)
        {
            var newNode = new Node(item);
        }

        // AddLast Method
        public void AddLast(T item)
        {

        }

        // AddLast Method
        public void First(T item)
        {

        }

        // Find
        public void Find(T item)
        {

        }

        // Remove
        public void Remove(T item)
        {

        }

        // Clear
        public void Clear(T item)
        {

        }
    }
}