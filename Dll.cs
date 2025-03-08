using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Dll
    {
        private Node head;


        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            newNode.Prev = null;
            if (head != null)
            {
                head.Prev = newNode;
            }
            head = newNode;

        }

        public void Display()
        {
            Node node = head;
            while (node != null)
            {
                Console.Write(node.Data + " --> ");

                node = node.Next;
            }
            Console.WriteLine("null");
        }

        public void AddLast(int data)
        {
            Node node = new Node(data);

            Node temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            temp.Next = node;
            node.Prev = temp;

        }

        public void Delete(int data)
        {
            if (head == null)
            {
                return;
            }
            Node temp = head;

            while (temp != null && temp.Data != data)
            {
                temp = temp.Next;
            }

            if (temp == null)
            {
                Console.WriteLine("no such element exists");
            }

            if (temp.Prev.Next != null)
            {
                temp.Prev.Next = temp.Next;
            }
            if (temp.Next != null)
            {
                temp.Next.Prev = temp.Prev;
            }
        }

        public void RemoveAt(int index)
        {
            if (head == null)
            {
                return;
            }

            if (index < 0)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            Node temp = head;
            int count = 0;

            while (temp != null && count < index)
            {
                temp = temp.Next;
                count++;
            }
            if (temp == null)
            {
                Console.WriteLine("Index out of range");
                return;
            }

            if (temp == head)
            {
                head.Next.Prev = null;
                head = head.Next;
                if (head != null)
                {
                    head.Prev = null;
                }
            }

            if (temp.Prev != null)
            {
                temp.Prev.Next = temp.Next;
            }
            if (temp.Next != null)
            {
                temp.Next.Prev = temp.Prev;
            }
        }

        public void sort(Dll list)
        {
            bool swapped = true;
            do
            {
                swapped = false;
                Node temp = head;

                while (temp != null && temp.Next != null)
                {
                    if (temp.Data > temp.Next.Data)
                    {
                        int t = temp.Data;
                        temp.Data = temp.Next.Data;
                        temp.Next.Data = t;
                        swapped = true;
                    }
                    temp = temp.Next;
                }
            }
            while (swapped);
        }
    }
}
