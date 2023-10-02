using System;
using System.Text;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList.Do();
                        break;
                    case '2':
                        ExamineQueue.Do();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis.Do();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }



        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
            string text = string.Empty;
            char key = 'j';
            bool loop = true;
            while (loop) 
            {
                Console.Clear() ;
                Console.WriteLine("Skriv en valfri text så vänder jag på den!");
                text = Console.ReadLine()! ;
                Console.WriteLine(ReverseText( text )+"\n");
                Console.WriteLine("Vill du att jag ska vända på fler? (J/j)");
                key = Console.ReadKey().KeyChar;
                if (char.ToUpper(key) != 'J') { loop = false; }
                
            }
        }

        static string ReverseText(string? text) 
        {
            if (string.IsNullOrWhiteSpace(text)) { return string.Empty; }
            Stack<char> chars = new(0);
            text = text.Trim();
            foreach (char c in text) { chars.Push(c); }
            StringBuilder temp = new();
            while(true)
            {
                if (!chars.TryPop(out char c)) { break; }
                temp.Append(c);
            }
            return temp.ToString();
        }

    }
}

