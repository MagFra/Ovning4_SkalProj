using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne
{
    public static class ExamineQueue
    {
        private static readonly Queue<string> theQueue = new(0);
        private static readonly string testString = "Test string";

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        public static void Do()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            Console.Clear();
            Console.WriteLine("Examine the growth and decrease of a Queue as elements is Enqueued or Dequeued.");
            Console.WriteLine("Manipulate the Queue by:\n" +
                "Press + To Enqueue.\nPress - To Dequeue.\nPress - while zero to exit.");
            ExamineWrite();

            ConsoleKey key;
            bool loop = true;
            while (loop)
            {
                key = Console.ReadKey(intercept: true).Key;
                switch (key)
                {
                    case ConsoleKey.Add: { Add(); break; }
                    case ConsoleKey.Subtract:
                        {
                            if (theQueue.Count <= 0) { loop = false; break; };
                            Remowe();
                            break;
                        }
                }
            }
        }
        public static void Add()
        {
            theQueue.Enqueue(testString); 
            ExamineWrite();
            
        }

        public static void Remowe()
        {
            theQueue.Dequeue();
            ExamineWrite();
        }

        public static void ExamineWrite()
        {
            StringBuilder temp =new();
            foreach (var item in theQueue)
            {
                temp.Append(item + ", ");
            }
            string temp2 = temp.ToString();
            Console.WriteLine($"Count: {theQueue.Count}.\tQueue: {temp2}");
        }
    }
}
