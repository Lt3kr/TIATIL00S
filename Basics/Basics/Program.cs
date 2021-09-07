using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = (new findIndex()).run();
            
            System.Console.WriteLine((new int[] {1,2,3,4}));
            foreach (var item in number)
            {
                System.Console.WriteLine(item);    
            }
            // string[] test = new string[] { "xdddd", "D:" };
            // int[] test2 = new int[] { 21, 13, 51 };
            // float[] test3 = new float[] { 3.1f,4.1f,5.1f,6.1f };
            // double[] test4 = new double[] { 3.1d, 4.1d, 5.1d, 6.1d };
            // bool[] test5 = new bool[] { false, true };
            // Human human = new Human{ 
            //     firstName = "Matteus",
            //     lastName = "Westman",
            //     isDead = true
            // };

            // var isHumanAlive = int.Parse(System.Console.ReadLine());

            // // if()

            // if(!human.isDead)
            //     System.Console.WriteLine($"Human {human.fullName()} is alive!");
            // else
            //     System.Console.WriteLine($"Human {human.fullName()} is dead..");

            // Loop(test);
            // Loop(test2);
            // Loop(test3);
            // Loop(test4);
            // Loop(test5);
            
            // Console.ReadKey();
            // var d = Console.ReadLine();
            // System.Console.WriteLine(d);
            // System.Console.ReadLine();
            // System.Console.ReadLine();
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