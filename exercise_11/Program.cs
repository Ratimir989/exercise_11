using System;

namespace exercise_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Попробуйте угадать число от 1 до 146");
            int rate = int.Parse(Console.ReadLine());
            if (rate > 146)
            {
                Console.WriteLine("неверное число");
            }
            else
            {
                Random rnd = new Random();
                int value = rnd.Next(1, 146);
                if (rate > value)
                {
                    Console.WriteLine("меньше");
                }
                else if (rate < value)
                {
                    Console.WriteLine("больше");
                }
                else
                {
                    Console.WriteLine($"вы угадали это число {value}");
                }
                Console.WriteLine(value);
            }
        }
    }
}
