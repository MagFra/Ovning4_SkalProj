using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne
{
    public static class CheckParanthesis
    {
        private static readonly List<char> lefts = new(4) { '(', '[', '{', '<' };
        private static readonly List<char> rights = new(4) { ')', ']', '}', '>' };
        // ToDo: Seeing the above I realize there must be exceptions for brackets inside quotations like ')' or "]".
        public static void Do()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

            string? testText = string.Empty;
            char key = 'j';
            bool testResult;
            bool loop = true;
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("Om du anger en text med en varierande uppsättning av olika sorterters paranteser ()[]{}, så testar jag om de utgör korrekt matchade par.");
                testText = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(testText)) 
                {
                    testResult = BracketsConforms(testText);
                    Console.WriteLine("Texten du skrev är " + (testResult ? "korrekt." : "felaktig!"));
                }
                Console.WriteLine("Vill du testa fler texter (j)");
                key = Console.ReadKey().KeyChar;
                if (char.ToUpper(key) != 'J') { loop = false; }
            }

        }
        private static bool BracketsConforms(string textWithBrackets)
        {
            if (string.IsNullOrWhiteSpace(textWithBrackets))
            {
                throw new ArgumentException("Text is missing.", nameof(textWithBrackets));
            }
            Stack<int> brackets = new Stack<int>();
            textWithBrackets = textWithBrackets.Trim();
            foreach (char c in textWithBrackets)
            {
                if (lefts.Contains(c)) 
                { 
                    brackets.Push(lefts.IndexOf(c));
                }
                if (rights.Contains(c))
                {
                    if(!brackets.TryPop(out int result)) { return false; }
                    if(result!= rights.IndexOf(c)) { return false; } 
                }
            }

            return true;
        }
    }
}
