using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            PalindromeFinder p = new PalindromeFinder();
            while(true)
            {
                Console.Write("Enter a word:");
                var value = Console.ReadLine();
                if (value == "q")
                    break;
                try
                {
                    if (p.IsPalindrome(value))
                    {
                        Console.WriteLine("Yey! The word is a palindrome");
                    }
                    else
                    {
                        Console.WriteLine("Nooeee, the word is not a palindrome");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
