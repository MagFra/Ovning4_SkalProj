using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne
{
    public static class ExamineList
    {
        private static readonly List<string> theList = new(0);
        private static readonly string testValue = "TestValue";

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        public static void Do()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             */

            Console.Clear();
            Console.WriteLine("Examine the correlation between the number of positions used (Count) \n" +
                "and the number of positions available (Capacity) in a list of strings.");
            Console.WriteLine("Change the number of positions in the list by:\n" +
                "Press + To increment.\nPress - To decrement.\nPress - while zero to exit.");
            WriteSizes();
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
                            if (theList.Count <= 0) { loop = false; break; };
                            Remowe();
                            break;
                        }
                }
            }

            /*
             * Below you can see some inspirational code to begin working.
            */

            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}
        }

        private static void Remowe()
        {
            theList.Remove(testValue);
            WriteSizes();
        }
        private static void Add() 
        { 
            theList.Add(testValue); 
            WriteSizes();
        }
        private static void WriteSizes()
        {
            Console.WriteLine($"Count: {theList.Count}.\tCapacity: {theList.Capacity}.");
        }
    }
}
