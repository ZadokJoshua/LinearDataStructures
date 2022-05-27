namespace CSharpAlgorithms
{
    public class LinkedListAlgorithms<T>
    {
        LinkedList<T> listy = new LinkedList<T>();

        // Addlast - to add data to the back
        // AddFirst - to add data to the front
        // Contains - to see if a certain piece of data is in a list
        // .Count - to  access how many items are in the list
        // Remove, RemoveFirst or RemoveLast - to remove items in the list 

        public void AddNodeToFirst(T item)
        {
            listy.AddFirst(item);
        }

        public void AddNodeToLast(T item)
        {
            listy.AddLast(item);
        }

        public bool CheckForNodeInList(T item)
        {
            return listy.Contains(item);
        }

        public void RemoveNodeInList(T item)
        {
            if (CheckForNodeInList(item))
            {
                listy.Remove(item);
                Console.WriteLine("{0} has been removed", item);
            }
            else
            {
                Console.WriteLine("{0} cannot be found", item);
            }
        }

        public void RemoveFirst()
        {
            listy.RemoveFirst();
        }

        public void RemoveLast()
        {
            listy.RemoveLast();
        }

        public void Print()
        {
            if (listy.Count > 0)
            {
                foreach (T item in listy)
                {
                    Console.Write(item + "-->");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("List is empty");
            }
        }
    }
}
