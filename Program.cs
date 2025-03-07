namespace DSA_core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stackll stack = new Stackll();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Pop();
            //stack.Peek();
            //stack.Display();


            QueueLL queue = new QueueLL();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Dequeue();
            queue.Peek();
        }
    }
}
