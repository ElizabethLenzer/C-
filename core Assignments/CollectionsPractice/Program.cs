using System;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //ARRAY ITERATING
            int[] numArray = new int[10];
            int[] NewArr = {0,1,2,3,4,5,6,7,8,9};

            //String of Names
            string[] myNames = new string[]{"Tim", "Martin", "Nikki", "Sarah"};

            //Boolean true and false
            bool[] boolArray = new bool[10];
            for(int i = 0; i<boolArray.Length; i++)
            {
                if (i % 2 == 0)
                {
                    boolArray[i] = true;
                }
                else boolArray[i] = false;
            }
            foreach (Boolean statement in boolArray)
            {
                Console.WriteLine(statement);
            }

            //List of Flavors
            List<string> flavors = new List<string>();
            flavors.Add("Chocolate");
            flavors.Add("Vanilla");
            flavors.Add("Strawberry");
            flavors.Add("Mint");
            flavors.Add("Mango");

            Console.WriteLine(flavors.count);
            

        }
    }
}
