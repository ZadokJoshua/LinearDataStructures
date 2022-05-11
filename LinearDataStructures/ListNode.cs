public class ListNode<T>
{

    public T Value { get; set; }
    public ListNode<T> PreviousNode { get; set; }
    public ListNode<T> NextNode { get; set; }

    public ListNode(T value)
    {
        Value = value;
    }

    public ListNode(T value, ListNode<T> previousNode) : this(value)
    {
        PreviousNode = previousNode;
    }


    public ListNode(T value, ListNode<T> previousNode, ListNode<T> nextNode) : this(value, previousNode)
    {
        NextNode = nextNode;
    }

}
