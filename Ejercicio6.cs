using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("Deleveled"));
            Console.Readkey();
        }

        public static bool IsPalindrome(string str)
        {
            string forward = "";
            foreach (char c in str.ToLower())
                if (char.IsLetter(c))
                    forward += c;

            char[] temp = forward.ToCharArray();
            Array.Reverse(temp);
            string reverese = new string(temp);
            return forward == reverese;
        }
    }
}
