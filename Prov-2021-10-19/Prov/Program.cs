using System;

namespace Prov
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            // Uppgift01();
            Uppgift02();
            Uppgift03();
            var b = Uppgift04();
            foreach (var item in b)
            {
                System.Console.Write($"{item}, ");
            }
        }

        static bool Uppgift01()
        {
            string age;
            System.Console.WriteLine("Skriv in ditt ålder:");
            age = System.Console.ReadLine();

            if(age.Length <= 0)
            {
                System.Console.WriteLine("Du måste skriva in något");
                Uppgift01();
                return false;
            }
            
            var ageInt = Convert.ToInt32(age);

            if(ageInt <= 15)
            {
                System.Console.WriteLine("Du måste vänta lite till innan du kan ta mopedkörtet");
                return false;
            }
            
            System.Console.WriteLine("Du kan ta mopedkört :)");
            return true;
        }


        static int SortByChar(char a)
        {
            switch(a)
            {
                case 'A':
                {
                    return 10;
                }

                case 'J':
                {
                    return 9;
                }

                case 'M':
                {
                    return 8;
                }

                case 'N':
                {
                    return 7;
                }
            }

            return 0;
        }
        static bool Uppgift02()
        {
            // Idk, too lazy because no good libraries that I know that I can use for this method,
            // Don't even know the alphabetic order LMAOOO
            // Tried to give each CHAR a value of ranking, and the higher rank would go first,
            // Could figure it out on javascript or c++ since I know more stuff there
            // But get a little stuck on c#, just won't click in my head.
            string[] family = { "Matteus", "Marina", "Johanna", "Alexander", "Nettan" };
            string[] sortedFamily = new string[family.Length];
            sortedFamily[0] = family[0];
            for (int i = 1; i < family.Length; i++)
            {
                var Now = SortByChar(family[i][0]);
                var Before = SortByChar(family[i-1][0]);
                System.Console.WriteLine($"Now {Now}, Before {Before}");
                if(Now > Before)
                {
                    sortedFamily[i] = (family[i-1]);
                    sortedFamily[i-1] = (family[i]);
                }
                else
                {
                    sortedFamily[i] = family[i];
                }
            }

            foreach (var familyMember in sortedFamily)
            {
                System.Console.WriteLine(familyMember);
            }
            return true;
        }

        static void Uppgift03()
        {
            int[] siffor = {18,19,39,49,999,30,60,10};

            for (int i = 0; i < siffor.Length; i++)
            {
                if(siffor[i] >= 39)
                    System.Console.WriteLine(siffor[i]);
            }
        }

        static int[] Uppgift04()
        {
            int[] a = {3, -7, 1, 7, 5,88,77,67,4,8};

            for (int i = 0; i < a.Length; i++)
            {
                int indexNow = i;

                for (int x = 0; x < a.Length; x++)
                {
                    if(!(x==indexNow))
                    {
                        System.Console.WriteLine($"Checking {i}, {x}");
                        if(a[i]+a[x] == -2)
                            return new int[] { i, x };
                    }
                }
            }
            
            return null;
        }
    }
}
