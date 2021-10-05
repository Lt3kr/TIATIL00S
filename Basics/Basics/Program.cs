using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new findPair().run();
            System.Console.WriteLine(a);
            // askForText();
        }

        static int lengthOfString(string text)
        {
            return text.Split(" ").Length;
        }

        static void askForText()
        {
            System.Console.WriteLine("Write a sentence");
            string text = System.Console.ReadLine();
            System.Console.WriteLine($"Your sentence has {lengthOfString(text)} words");
        }
    }
}