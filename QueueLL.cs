using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_core
{
    internal class QueueLL
    {
        private Node start;
        private Node end;
        int size = 0;

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (start == null)
            {
                start = newNode;
                end = newNode;
                size++;
            }

            end.Next = newNode;
            newNode.Prev = end;
            end = newNode;

            size++;
        }

        public void Dequeue()
        {
            if (start == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Node temp = start;

            start.Next.Prev = null;
            start = start.Next;
            Console.WriteLine($"Dequeued {temp.Data} from queue.");
        }

        public void Peek()
        {
            if (start == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            Console.WriteLine(start.Data);
        }
    }
}
