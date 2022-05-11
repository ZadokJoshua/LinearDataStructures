namespace Data_Structures
{
    public class CustomQueue<T>
    {
        public ListNode<T> Head;
        public ListNode<T> Tail;
        public static int Count = 0;

        public CustomQueue()
        {
            Head = Tail = null;
        }

        // Enqueue
        public void Enqueue(T item)
        {
            var newNode = new ListNode<T>(item);

            if(Tail == null)
            {
                Head = Tail = newNode;
            }
            else
            {
                Tail.NextNode = newNode;
                Tail = newNode;
            }

            Console.WriteLine($"{item} has been inserted into the queue.");
            Count ++;
        }

        // Dequeue
        public void Dequeue()
        {
            if(Head == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            var temp = Head;
            Head = Head.NextNode;

            if(Head == null)
            {
                Tail = null;
            }

            Console.WriteLine($"Item deleted is {temp.Value}");
            Count --;
        }

        //// Contains
        public ListNode<T> Contain(T item)
        {
            bool containCondition = false;

            for (ListNode<T> current = Head; current.NextNode != null; current = current.NextNode)
            {
                if (Equals(current.Value, item))
                {
                    return current;
                }
            }
            return null;
        }

        // Clear
        public void Clear()
        {
            Head = Tail = null;
        }


    }
}