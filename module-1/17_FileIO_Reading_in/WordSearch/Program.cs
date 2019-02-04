using System;
using System.Collections.Generic;
using System.IO;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Ask the user for the search string
            Console.WriteLine("What is the search word you are looking for?");
            string searchWord = Console.ReadLine();
            Console.WriteLine("Should the seatch be case sensitive (Y/N)");
            char caseSensitive = char.Parse(Console.ReadLine());
            //2. Ask the user for the file path
            Console.WriteLine("What is fully qualified name of the file that should be searched?");
            string filepath = Console.ReadLine();
            //3. Open the file
            List<string> allLines = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader(filepath))
                {
                    //4. Loop through each line in the file
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] inputArray = line.Split('\n');
                        allLines.AddRange(inputArray);
                    }
                }
            }
            catch (IOException ex)
            {

                Console.WriteLine("Error reading the file");
                Console.WriteLine(ex.Message);
            }
            //5. If the line contains the search string, print it out along with its line number
            for (int i = 0; i < allLines.Count; i++)
            {
                if (caseSensitive == 'N')
                {

                    if (allLines[i].ToUpper().Contains(searchWord.ToUpper()))
                    {
                        Console.WriteLine($"{i + 1}) {allLines[i]}");
                    }

                }
                else
                {
                    if (allLines[i].Contains(searchWord))
                    {
                        Console.WriteLine($"{i + 1}) {allLines[i]}");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
