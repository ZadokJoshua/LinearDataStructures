namespace Data_Structures
{
    public class CustomQueue<T>
    {
        public ListNode<T> Head;
        public ListNode<T> Tail;

        public CustomQueue()
        {
            this.Head = this.Tail = null;
        }

        // Enqueue
        public void Enqueue(T item)
        {
            var newNode = new ListNode<T>(item);

            if(this.Tail == null)
            {
                this.Head = this.Tail = newNode;
            }
            else
            {
                this.Tail.NextNode = newNode;
                this.Tail = newNode;
            }

            Console.WriteLine($"{item} has been inserted into the queue.");
        }

        // Dequeue
        public void Dequeue()
        {
            if(this.Head == null)
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
        }

        // Contains


        // Clear
        public void Clear()
        {
            Head = Tail = null;
        }


    }
}