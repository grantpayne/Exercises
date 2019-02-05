using System;
using System.Collections.Generic;
using System.Text;

namespace file_io_part1_exercises.Classes
{
    class QuizQuestion
    {
        
        public string Question { get; set; }
        public List<string> Responses { get; set; }
        public int CorrectAnswer { get; set; }

        public QuizQuestion(string question, List<string> responses )
        {
            //assign passed-in question to Question property
            Question = question;

            //loop through responses list, log correct answer, and remove asterisk
            for (int i = 0; i < responses.Count; i++)
            {
                if (responses[i].EndsWith('*'))
                {
                    CorrectAnswer = i + 1;
                    responses[i] = responses[i].TrimEnd('*');
                    
                }
            }

            //save responses to Responses property
            Responses = responses;

        }
        
    }
}
