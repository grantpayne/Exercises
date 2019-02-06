using System;
using System.Collections.Generic;
using System.IO;

namespace FileSplitter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Where is the input file (please include the path to the tile)? ");
            string inputFilePath = Console.ReadLine();
            Console.Write("How many lines of text (max) should there be in the split files? ");
            int maxLines = int.Parse(Console.ReadLine());
            string fileName = Path.GetFileName(inputFilePath);
            string fileNameNoExtension = Path.GetFileNameWithoutExtension(inputFilePath);
            string fileExtension = Path.GetExtension(inputFilePath);
            string fileDirectory = Path.GetDirectoryName(inputFilePath);
            

            Queue<string> lineList = new Queue<string>();
            //string shortInputFilePath = inputFilePath.



            try
            {
                using (StreamReader sr = new StreamReader(inputFilePath))
                {
                    while (!sr.EndOfStream)
                    {
                        lineList.Enqueue(sr.ReadLine());
                    }
                }
            }
            catch (IOException ex)
            {

                Console.WriteLine("Error reading the file");
                Console.WriteLine(ex.Message);
            }

            int filesNeeded = (int)Math.Ceiling(lineList.Count / (double)maxLines);

            Console.WriteLine($"The input file has {lineList.Count} lines of text.\n\n" +
                $"Each file that is created should have a sequential number assigned to it.\n\n" +
                $"For a {lineList.Count} line input file \"{fileName}\" " +
                $"this will produce {filesNeeded} output files.\n\n**GENERATING OUTPUT**\n");

            for (int i = 1; i <= filesNeeded; i++)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter($"{fileDirectory}\\{fileNameNoExtension}-{i}{fileExtension}", false))
                    {
                        Console.WriteLine($"Generating {fileNameNoExtension}-{i}{fileExtension}");
                        for (int j = 0; j < maxLines; j++)
                        {
                            if (lineList.Count > 0)
                            {
                                sw.WriteLine(lineList.Dequeue());
                            }
                        }


                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Error writing output file(s).");
                }
            }

            Console.ReadLine();
        }
    }
}
