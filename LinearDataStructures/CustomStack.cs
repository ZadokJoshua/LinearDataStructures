namespace Data_Structures
{
    public class CustomStack<T>
    {
        public ListNode<T> StackTop { get; set; }

        public CustomStack()
        {
            this.StackTop = null;
        }

        public void Push(T item)
        {
            var newNode = new ListNode<T>(item);
            if(StackTop == null)
            {
                newNode.NextNode = null;
            }
            else
            {
                newNode.NextNode = StackTop;
            }
            StackTop = newNode;
            Console.WriteLine($"{item} push to the Stack");
        }

        public void Pop(T item)
        {
            if(StackTop == null)
            {
                Console.WriteLine("Cannot Delete because stack is empty.");
                return;
            }

            Console.WriteLine($"{StackTop.Value} has been popped.");
            StackTop = StackTop.NextNode;
        }

        public void Peek(T item)
        {
            if(StackTop == null)
            {
                Console.WriteLine("Stack is empty.");
                return;
            }

            Console.WriteLine($"{this.StackTop.Value} is the stack top");
        }
    }
}