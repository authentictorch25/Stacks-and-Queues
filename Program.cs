using System;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
            queue.Dequeue();
            queue.Display();
            queue.Dequeue();
            queue.Display();

            Console.ReadKey();
        }
    }
}
