using System;
namespace Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = 0;
            int t = 0;
            int d = 0;
            int s = 0;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    if ((i + j) == c) { z = i; t = j; d = 1; }
                    s = s + 1;
                }
            }
            if (d != 1)
            {
                Console.WriteLine("{0} combinations - neither equals {1}", s, c);
            }
            else
            {
                Console.WriteLine("Number found! {0} + {1} = {2}", z, t, c);
            }
        }
    }
}