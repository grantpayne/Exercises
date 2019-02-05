using file_io_part1_exercises.Classes;
using System;
using System.Collections.Generic;
using System.IO;


namespace file_io_part1_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the fully qualified name of the file to read in for quiz questions");

            //call data fetching method
            List<QuizQuestion> questionList = FetchQuestionData(Console.ReadLine());
            
            //initalize scoring varibles
            int correctResponses = 0;
            int totalQuestions = 0;

            //ask questions
            foreach (QuizQuestion question in questionList)
            {
                //print out question
                Console.WriteLine(question.Question);

                //print out responses
                for (int i = 0; i < question.Responses.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {question.Responses[i]}");
                }
                
                //prompt user for response and save it
                Console.Write("\nYour Answer: ");
                int userResponse = int.Parse(Console.ReadLine());

                //check for correct response and adjust score/total questions
                if (userResponse == question.CorrectAnswer)
                {
                    Console.WriteLine("RIGHT!\n");
                    correctResponses++;
                    totalQuestions++;
                }
                else
                {
                    Console.WriteLine("WRONG!\n");
                    totalQuestions++;
                }
                
            }
            //display final score
            Console.WriteLine($"You got {correctResponses} answer(s) correct out of the" +
                $"{totalQuestions} questions asked.");
            Console.ReadLine();
        }

        public static List<QuizQuestion> FetchQuestionData(string filePath)
        {
            List<QuizQuestion> questionList = new List<QuizQuestion>();
            try
            {
                using (StreamReader quizRead = new StreamReader(filePath))
                {
                    //cycle through each question-line in file
                    while (!quizRead.EndOfStream)
                    {
                        //read question-line
                        string questionLine = quizRead.ReadLine();

                        //split up question by pipe-delimiting into list
                        List<string> seperatedQuestion = new List<string>(questionLine.Split('|'));

                        //save first element as question
                        string question = seperatedQuestion[0];

                        //remove first element (question) to leave responses only in list
                        seperatedQuestion.RemoveAt(0);

                        //instantiate new QuizQuestion and add to questionList
                        questionList.Add(new QuizQuestion(question, seperatedQuestion));


                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(ex.Message);
            }

            return questionList;
        }
    }
}
