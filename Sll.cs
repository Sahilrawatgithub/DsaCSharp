using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSA_core;

namespace Strings
{
    internal class Sll
    {
        private Node head;

        public void Addfirst(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }

            newNode.Next = head;
            head = newNode;
        }

        public void Addlast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }

            Node temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }

        public void PrintList()
        {
            if (head == null)
            {
                Console.WriteLine("The list is empty");
            }
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.Data + " --> ");
                temp = temp.Next;
            }

            Console.WriteLine("Null\n");
        }

        public void Delete(int data)
        {
            if (head == null)
            {
                Console.WriteLine("List is already empty");
                return;
            }

            if (head.Data == data)
            {
                head = head.Next;
                return;
            }

            Node temp = head;

            while (temp.Next != null)
            {
                if (temp.Next.Data == data)
                {
                    temp.Next = temp.Next.Next;
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("No such element in list.");
        }

        public void InsertAt(int index, int data)
        {
            Node NewNode = new Node(data);
            ;
            if (index == 0)
            {

                NewNode.Next = head;
                head = NewNode;
                return;
            }

            Node temp = head;

            for (int i = 0; temp != null && i < index - 1; i++)
            {
                temp = temp.Next;
            }


            if (temp == null)
            {
                Console.WriteLine("Index out of bounds");
                return;
            }

            NewNode.Next = temp.Next;
            temp.Next = NewNode;
        }
    }

}
