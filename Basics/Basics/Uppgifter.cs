using System;
using System.Collections.Generic;

namespace Basics
{
    static class Uppgifter
    {
        public static void Uppgift01()
        {
            System.Console.WriteLine("Running uppgift 1");
            int[] a = {1,2,3,4};
            for (int i = 0; i < a.Length; i++)
                System.Console.WriteLine(a[i]);
        }

        public static void Uppgift02()
        {
            System.Console.WriteLine("Running uppgift 2");
            int[] a = {1,2,3,4};
            for (int i = a.Length-1; i >= 0; i--)
                System.Console.WriteLine(a[i]);
        }
        public static void Uppgift03(int toFind, int[] ArrayInt)
        {
            System.Console.WriteLine("Running uppgift 3");
            for (int i = 0; i < ArrayInt.Length; i++)
                if(ArrayInt[i] == toFind)
                    System.Console.WriteLine(i);
        }

        public static int[] Uppgift04(int[] ar)
        {
            System.Console.WriteLine("Running uppgift 4");
            int[] b = {};
            b = ar;
            System.Console.WriteLine(b);
            return b;
        }

        public static void Uppgift05(int[] a)
        {
            System.Console.WriteLine("Running uppgift 5");
            // int[] a = {1,2,3,1,1,5};

            int count = 0;
            Dictionary<int, int> Checker = new Dictionary<int, int>();

            for (int i = 0; i < a.Length; i++)
            {
                if(Checker.ContainsKey(a[i]))
                    count++;
                else
                    Checker.Add(a[i], a[i]);
            }
            System.Console.WriteLine($"Found {count}");
        }

    }
}