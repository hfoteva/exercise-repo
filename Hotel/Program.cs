using System;
namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            int nightCount = int.Parse(Console.ReadLine());
            double a = 0;
            double b = 0;
            double c = 0;
            switch (month)
            {
                case "May":
                case "October":
                    a = 50;
                    b = 65 * nightCount;
                    c = 75 * nightCount;
                    if (nightCount > 7)
                    {
                        a = a - (0.05 * a);
                        if (String.Equals(month, "October", StringComparison.Ordinal))
                        {
                            a = (nightCount - 1) * a;
                        }
                        else
                        {
                            a = nightCount * a;
                        }
                    }
                    else { a = nightCount * a; }
                    break;
                case "June":
                case "September":
                    a = 60;
                    b = 72;
                    c = 82 * nightCount;
                    if (nightCount > 14)
                    {
                        b = b - (0.10 * b);
                        b = nightCount * b;
                    }
                    else
                    {
                        b = nightCount * b;
                    }
                    if ((String.Equals(month, "September", StringComparison.Ordinal)) && (nightCount > 7))
                    {
                        a = a * (nightCount - 1);
                    }
                    else
                    {
                        a = a * nightCount;
                    }
                    break;
                case "July":
                case "August":
                case "December":
                    a = 68 * nightCount;
                    b = 77 * nightCount;
                    c = 89;
                    if (nightCount > 14)
                    {
                        c = c - (0.15 * c);
                        c = c * nightCount;
                    }
                    else
                    {
                        c = c * nightCount;
                    }
                    break;
                default: break;
            }
            Console.WriteLine("Studio: {0:F2} lv.", a);
            Console.WriteLine("Double: {0:F2} lv.", b);
            Console.WriteLine("Suite: {0:F2} lv.", c);
        }
    }
}