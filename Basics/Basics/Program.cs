using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] test = new string[] { "xdddd", "D:" };
            int[] test2 = new int[] { 3,4,5,6 };
            float[] test3 = new float[] { 3.1f,4.1f,5.1f,6.1f };
            double[] test4 = new double[] { 3.1d, 4.1d, 5.1d, 6.1d };
            bool[] test5 = new bool[] { false, true };

            Loop(test);
            Loop(test2);
            Loop(test3);
            Loop(test4);
            Loop(test5);
            
            Console.ReadKey();
            var d = Console.ReadLine();
            System.Console.WriteLine(d);
            System.Console.ReadLine();
            System.Console.ReadLine();
        }

        /// <summary>
        /// Console logs whats in text
        /// </summary>
        static void Loop(string[] text)
        {
            foreach (var t in text)
            {
                Console.WriteLine(t);
            }
        }
        /// <summary>
        /// Console logs whats in text
        /// </summary>
        static void Loop(int[] text)
        {
            foreach (var t in text)
            {
                Console.WriteLine(t);
            }
        } 
        /// <summary>
        /// Console logs whats in text
        /// </summary>
        static void Loop(double[] text)
        {
            foreach (var t in text)
            {
                Console.WriteLine(t);
            }
        } 
        /// <summary>
        /// Console logs whats in text
        /// </summary>
        static void Loop(float[] text)
        {
            foreach (var t in text)
            {
                Console.WriteLine(t);
            }
        }

        /// <summary>
        /// Console logs whats in text
        /// </summary>
        static void Loop(bool[] text)
        {
            foreach (var t in text)
            {
                Console.WriteLine(t);
            }
        }
    }
}