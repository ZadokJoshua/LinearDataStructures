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

        // AddItem method
        public void AddItem(T item)
        {
            if (Head is null)
            {
                Head = Tail = new ListNode<T>(item);
            }
            else
            {
                var temp = Tail;
                var newNode = new ListNode<T>(item, temp, null);
                Tail = newNode;
            }
        }

        // AddFirst Method
        public void AddFirst(T item)
        {
            if (Head == null)
            {
                Head = Tail = new ListNode<T>(item);
                Head.NextNode = Tail;
            }
            else
            {
                var temp = Head;
                var newNode = new ListNode<T>(item, null, temp);
                Head = newNode;
            }
        }

        //public void AddNode(ListNode<T> node)
        //{
        //    if (Head is null)
        //    {
        //        Head = Tail = node;
        //    }
        //    else
        //    {
        //        Tail.NextNode = node;
        //        Tail = node;
        //    }
        //}



        // AddLast Method
        public void AddLast(ListNode<T> node)
        {
            if (Tail == null)
            {
                Tail = Head = node;
                Head.NextNode = Tail;
            }
            else
            {
                node.NextNode = Head;
                Head = node;
            }
        }


        // Find
        public ListNode<T> Find(T item)
        {
            for(ListNode<T> current = Head; current.NextNode != null; current = current.NextNode)
            {
                if (current.Equals(item))
                {
                    return current;
                }
            }
            return null;
        }

        // Remove
        public void Remove(T item)
        {
            var nodeToRemove = Find(item);
            if (nodeToRemove is null)
            {
                return;
            }
            else if (nodeToRemove.Equals(Head))
            {
                var temp = Head.NextNode;
                Head.NextNode = null;
                Head = temp;
            }
            else if (nodeToRemove.Equals(Tail))
            {
                var temp = Tail.PreviousNode;
                Tail.PreviousNode = null;
                Tail = temp;
            }
            else
            {
                var prev = nodeToRemove.PreviousNode;
                var next = nodeToRemove.NextNode;
                if(prev != null) prev.NextNode = next;
                if(next != null) next.PreviousNode = prev;
                nodeToRemove.PreviousNode = nodeToRemove.NextNode = null;
            }




            //var currentItem = Head;
            //if (Head.Value.Equals(item))
            //{
            //    var temp = Head;
            //    Head = Head.NextNode;
            //    temp.NextNode = null;
            //}
        }

        

        // Clear
        public void Clear(T item)
        {
            Head = Tail = null;
        }
    }
}