using System;

namespace Fact
{
    class Program
    {
        static ulong Factorial(ulong fact)
        {
            ulong result = 1;
            for (ulong z = 1; z <= fact; z++)
            {
                result *= z;
            }
            return result;
        }
        static void Table(ulong fact, string left, string middle, string right)
        {
            Console.Write(left);
            if (middle == "")
                Console.Write(fact);
            else
            {
                for (int i = 0; i < fact.ToString().Length; i++)
                    Console.Write(middle);
            }
            Console.WriteLine(right);
        }
        static void Main(string[] args)
        {
            ulong fact;
            Console.WriteLine("Введите число, факториал которого необходимо узнать.");
            while (!ulong.TryParse(Console.ReadLine(), out fact))
                Console.WriteLine("Введите данные корректно");
            Table(Factorial(fact), "╔", "═", "╗");
            Table(Factorial(fact), "║", "", "║");
            Table(Factorial(fact), "╚", "═", "╝");
        }
    }
}
