using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    class Queue
    {
        public Node front;

        /// <summary>
        /// UC 3 : Enqueues the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        public void Enqueue(int value)
        {
            Node newNode = new Node(value);
            if (front == null)
            {
                front = newNode;
            }
            else
            {
                Node temp = front;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
           
        }
        /// <summary>
        /// UC 3 : Dequeues from the queue.
        /// </summary>
        /// <param name="value">The value.</param>
        public void Dequeue()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Node temp = this.front;
            front = front.next;
            Console.WriteLine("Dequeued value: " + temp.data);
        }


        /// <summary>
        /// Displays the queue contents from front to rear.
        /// </summary>
        public void Display()
        {
            Node temp = front;
            if (temp == null)
                Console.WriteLine("Stack is empty");
            else
            {
                
                while (temp != null)
                {
                    Console.Write("->"+temp.data + " ->");
                    temp = temp.next;
                }               
            }
        }
    }
}
