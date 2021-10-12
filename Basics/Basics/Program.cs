using System;

namespace Basics
{
    using static Uppgifter;
    class Program
    {
        static void Main(string[] args)
        {
            // var a = new findPair().run();
            // System.Console.WriteLine(a);
            // System.Console.WriteLine(typeof(int));
            // int[] b = {1,2,3};
            Uppgift01();
            Uppgift02();
            // Should be 4
            Uppgift03(10, new int[] { 1, 2, 5, 20, 10, 3 });
            Uppgift04(new int[] { 1, 2, 5, 20, 10, 3 });
            Uppgift05(new int[] { 2,2,2,1,5,4,3,6,1 });
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