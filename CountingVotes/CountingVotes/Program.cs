using System;
using System.Collections.Generic;
using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the file full path");
        string path = Console.ReadLine();

        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                Dictionary<string, int> dictionary = new Dictionary<string, int>();

                while (!sr.EndOfStream)
                {
                    string[] votingRecord = Console.ReadLine().Split(',');
                    string candidate = votingRecord[0];
                    int votes = int.Parse(votingRecord[1]);

                    if (dictionary.ContainsKey(candidate))
                    {
                        dictionary[candidate] += votes;
                    }
                    else
                    {
                        dictionary[candidate] = votes;
                    }
                }

                foreach(var item in dictionary)
                {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }
            }
        }
        catch(IOException e)
        {
            Console.WriteLine("An error ocurred");
            Console.WriteLine(e.Message);
        }
    }
}