using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> 
            myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("mother", new Dictionary<string, string>() { { "name", "Ellen" }, { "age", "67" } });
            myFamily.Add("brother", new Dictionary<string, string>() { { "name", "Maxx" }, { "age", "33" } });
            myFamily.Add("wife", new Dictionary<string, string>() { { "name", "Lori" }, { "age", "33" } });
            myFamily.Add("child1", new Dictionary<string, string>() { { "name", "Simon" }, { "age", "2" } });
            myFamily.Add("child2", new Dictionary<string, string>() { { "name", "Lev" }, { "age", "2" } });

            foreach (var person in myFamily)
            {
                Console.WriteLine($"{person.Value["name"]} is my {person.Key} and is {person.Value["age"]}");
            }
        }
    }
}
