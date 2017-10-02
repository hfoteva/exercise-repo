using System;
namespace Different_5_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if ((a > b) || ((b - a) < 5)){
                Console.WriteLine("No");
            }
            else
            {
                for(int i =a; i<=b; i++)
                {
                    for(int j = i+1; j<=b; j++)
                    {
                        for(int k = j+1; k<=b; k++)
                        {
                            for(int t = k+1; t<=b; t++)
                            {
                                for(int z = t+1; z<=b; z++)
                                {
                                    Console.WriteLine("{0} {1} {2} {3} {4}", i, j, k, t, z);             
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
