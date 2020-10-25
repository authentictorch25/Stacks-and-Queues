using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    class Stack
    {
        public Node top;
        public void Push(int value)
        {
            Node newNode = new Node(value);
            if (top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }
            top = newNode;
            
        }
        public void Display()
        {
            Node temp = top;
            if (temp == null)
                Console.WriteLine("Stack is empty");
            else
            {
                while (temp != null)
                {
                    Console.WriteLine("| "+temp.data + " | ");
                    temp = temp.next;
                }
            }
        }
    }
}

