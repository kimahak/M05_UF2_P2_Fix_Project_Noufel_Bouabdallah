using System;
using System.Linq;
using System.Text;

namespace Palindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a text");
            string response = Console.ReadLine();
            Console.WriteLine(IsPalindrome(response));
        }       
        
        public static bool IsPalindrome(string text)
        {
            if (text.Length % 2 != 0)
                return false;
            string halfA = text.Substring(0, text.Length / 2);
            string halfB = text.Substring(text.Length / 2, text.Length / 2);
            halfB = new string(halfB.Reverse().ToArray());
            return halfA == halfB;
        }
    }
}
