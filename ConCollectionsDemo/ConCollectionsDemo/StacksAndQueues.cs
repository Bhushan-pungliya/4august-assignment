using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConCollectionDemo
{
    class StacksAndqueues
    {
        static void Main()
        {
            Queue que = new Queue();
            que.Enqueue("add");
            que.Enqueue("items");
            que.Enqueue("into");
            que.Enqueue("the ");
            que.Enqueue("queue");
            Console.WriteLine("elements of the queue");
            //foreach (var item in que)
            //{
            //    Console.WriteLine(item);
            //}
            while (que.Count > 0)
            {
                Console.WriteLine(que.Dequeue());
            }
            //Console.WriteLine(que.Peek());
            Console.WriteLine("elements in the queue:{0}", que.Count);
            Console.WriteLine("elements of the stack");
            Stack myStack = new Stack();

            // Inserting the elements into the Stack 
            myStack.Push("lunch");
            myStack.Push("break");
            myStack.Push("is");
            myStack.Push("over");
            myStack.Push("now");
            Console.Write("Total number of elements in the Stack are : ");

            Console.WriteLine(myStack.Count);

            Console.WriteLine("Deleting the element form the stack");
            while (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Pop());
            }
            Console.Write("Total number of elements in the Stack are : ");

            Console.WriteLine(myStack.Count);
            Console.Read();
        }
    }
}