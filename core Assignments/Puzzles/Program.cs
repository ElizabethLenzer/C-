using System;
using System.Collections.Generic;


namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArray();
            TossCoin();
            TossMultipleCoins(5);
            Names();
        }
        public static void RandomArray()
        {
            int[] randArray = new int[10];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                randArray[i] = rand.Next(5,25);
            }
            int min = randArray[0];
            int max = randArray[0];
            int sum = 0;
            foreach (var i in randArray)
            {
                if(i < min)
                    min = i;
                if (i > max)
                    max = i;
                sum += i;
            }
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(sum);
        }
        public static int TossCoin()
        {
            Console.WriteLine("Tossing A Coin");
            Random rand = new Random();
            int coin = rand.Next(1);
            if (coin == 1)
            {
                Console.WriteLine("Heads");
                return 1;
            }
            Console.WriteLine("Tails");
            return 0;
        }
        public static double TossMultipleCoins(int num)
        {
            int sum = 0;
            for (int i = 0; i < num; i++)
            {
                sum += TossCoin();
            }
            return (double) sum/num;
        }
        public static List<string> Names(){
            List<string> s = new List<string>(){"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            Random rand = new Random();
            for (int n = s.Count-1; n > 0; n--)
            {
                int r = rand.Next(n+1);
                var temp = s[r];
                s[r] = s[n];
                s[n] = temp;
            }
            foreach(var str in s)
                Console.WriteLine(str);
            for (int i = s.Count-1; i >= 0; i--)
            {
                if (s[i].Length <5)
                    s.RemoveAt(i);
            }
            return s;
        }
    }
}
