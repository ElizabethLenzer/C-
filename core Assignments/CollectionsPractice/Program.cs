using System;
using System.Collections.Generic;

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

            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[3]);
            flavors.RemoveAt(3);
            Console.WriteLine(flavors.Count);
            foreach(string flavor in flavors)
            {
                Console.WriteLine(flavor);
            }

            //User Info Dictionary
            Random rand = new Random();
            Dictionary<string,string> favorites = new Dictionary<string,string>();
            foreach (string person in myNames)
            {
                favorites.Add(person, flavors[rand.Next(flavors.Count)]);
            }
            foreach (var person in favorites)
            {
                Console.WriteLine(person.Key + person.Value);
            }
        }
    }
}
