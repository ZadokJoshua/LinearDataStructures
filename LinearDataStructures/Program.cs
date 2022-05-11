using Data_Structures;

var newQueue = new CustomQueue<int>();
newQueue.Enqueue(1);
newQueue.Enqueue(6);
newQueue.Enqueue(4);
newQueue.Enqueue(3);
newQueue.Dequeue();

var newStack = new CustomStack<int>();
newStack.Push(0);
newStack.Push(2);
newStack.Push(7);
newStack.Push(1);
newStack.Push(3);
newStack.Peek(1);
