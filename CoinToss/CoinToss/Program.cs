using System;

namespace CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNBr = rand.Next(1, 3);
            Console.WriteLine($"{randomNBr}");
        }
    }
}
