// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");


// 1-255 FOR LOOP
        for (int val = 1; val <= 255; val++)
        {
            Console.WriteLine(val);
        }

// 1-100 but are divisable by 3 and 5
        for (int val = 1; val <= 100; val++)
        {
            if (val % 3 == 0 && val % 5 == 0)
            {
                continue;
            }
            else if (val % 3 == 0 || val % 5 == 0)
            {
                Console.WriteLine(val);
            }
        }

// Same loop as above but replacing print values to fizz and buzz and fizzbuzz
        for (int val = 1; val <= 100; val++)
        {
            if (val % 3 == 0 && val % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (val % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (val % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
        }



    }
}