using System;
using System.Threading;

namespace task01
{
    internal static class Program
    {
        private static void Main()
        {
            var thread = new Thread(DrawSymbolChain);
            thread.Start();
            var thread2 = new Thread(DrawSymbolChain2);
            thread2.Start();
        }


        private static void DrawSymbolChain()
        {
            var r = new Random();
            const string symbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(symbols[r.Next(0, symbols.Length)]);
            for (var i = 0; i < r.Next(1, 5); i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(symbols[r.Next(0, symbols.Length)]);
            }
        }

        private static void DrawSymbolChain2()
        {
            var r = new Random();
            const string symbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(symbols[r.Next(0, symbols.Length)]);
            for (var i = 0; i < r.Next(1, 5); i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(symbols[r.Next(0, symbols.Length)]);
            }
        }
    }
}