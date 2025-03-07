using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DSA_core
{
    internal class StackLL
    {
        
            private Node top;
            int Size = 0;

            public void Push(int value)
            {
                Node newNode = new Node(value);


                newNode.Next = null;
                newNode.Prev = top;
                top = newNode;
            }

            public void Pop()
            {
                if (top == null)
                {
                    Console.WriteLine("Stack is empty");
                    return;
                }

                top.Prev.Next = null;
                top = top.Prev;

            }

            public void Peek()
            {
                Console.WriteLine(top.Data);
            }
            public void Display()
            {
                Node temp = top;
                while (temp != null)
                {
                    Console.WriteLine(temp.Data);
                    temp = temp.Prev;
                }
            }

        }
    }
