using System;
using System.IO;

namespace TextFile
{
    class program
    {
        static void Main(string[] args)
        {
            var filepath = @"E:\New folder\people.txt";


            var people = File.ReadAllLines(filepath).Select(line => new Person 
            { 
                FirstName = line.Split(',')[0],  
                LastName = line.Split(',')[1],
                Url = line.Split(',')[2],
            }
            ).ToList();

            Console.WriteLine("Read from text file...");
            foreach (var person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}: {person.Url}");
            }


            people.Add(new Person { FirstName = "hastii", LastName = "hast", Url = "hh.hh.com" });
            
            var output=new List<string>();

            foreach (var person in people)
            {
                output.Add($"{person.FirstName},{person.LastName},{person.Url }");
            }
            Console.WriteLine("Writing to text file...");
            File.WriteAllLines(filepath, output);
            Console.WriteLine("all entries writeen");

            Console.ReadLine();
        }
    }
}
