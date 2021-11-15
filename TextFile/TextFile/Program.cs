using System;
using System.IO;

namespace TextFile
{
    class program
    {
        static void Main(string[] args)
        {
            var filepath = @"E:\New folder\people.txt";

           //List<string> lines= File.ReadAllLines(filepatch).ToList();
           // foreach (string line in lines) 
           // {
           //     Console.WriteLine(line);
           // }

           // lines.Add("madarjende,angal,nanat");

           // File.WriteAllLines(filepatch, lines);

            var people=new List<Person>();

            var lines = File.ReadAllLines(filepath).ToList();

            foreach (string line in lines)
            {
                var entries = line.Split(',');
                var newperson=new Person();

                newperson.FirstName = entries[0];
                newperson.LastName = entries[1];
                newperson.Url = entries[2];


                people.Add(newperson);
            }
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
