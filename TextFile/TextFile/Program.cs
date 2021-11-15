using System;
using System.IO;

namespace TextFile
{
    class program
    {
        static void Main(string[] args)
        {
            string filepatch = @"E:\New folder\people.txt";

           //List<string> lines= File.ReadAllLines(filepatch).ToList();
           // foreach (string line in lines) 
           // {
           //     Console.WriteLine(line);
           // }

           // lines.Add("madarjende,angal,nanat");

           // File.WriteAllLines(filepatch, lines);

            List<Person> people=new List<Person>();

            List<string> lines = File.ReadAllLines(filepatch).ToList();

            foreach (string line in lines)
            {
                string[] entries = line.Split(',');
                Person newperson=new Person();

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
            
            List<string> output=new List<string>();

            foreach (var person in people)
            {
                output.Add($"{person.FirstName},{person.LastName},{person.Url }");
            }
            Console.WriteLine("Writing to text file...");
            File.WriteAllLines(filepatch, output);
            Console.WriteLine("all entries writeen");

            Console.ReadLine();
        }
    }
}
