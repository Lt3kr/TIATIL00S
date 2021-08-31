using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] test = new string[] { "xdddd", "D:" };
            int[] test2 = new int[] { 3,4,5,6 };

            Loop(test);
            Loop(test2);
            
            Console.ReadKey();
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
    }
}
