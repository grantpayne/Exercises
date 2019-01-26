using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {

        private int totalMarks;
        public int TotalMarks
        {
            get
            {
                return totalMarks;
            }
            set
            {
                totalMarks = value;
            }
        }
        private int possibleMarks;
        public int PossibleMarks
        {
            get
            {
                return possibleMarks;
            }
        }
        private string submitterName;
        public string SubmitterName
        {
            get
            {
                return submitterName;
            }
        }
        private string letterGrade = "";
        public string LetterGrade
        {
            get
            {
                if ((double)TotalMarks / PossibleMarks > 0.90)
                {
                    letterGrade = "A";
                }
                else if ((double)TotalMarks / PossibleMarks >= 0.80)
                {
                    letterGrade = "B";

                }
                else if ((double)TotalMarks / PossibleMarks >= 0.70)
                {
                    letterGrade = "C";
                }
                else if ((double)TotalMarks / PossibleMarks >= 0.60)
                {
                    letterGrade = "D";
                }
                else
                {
                    letterGrade = "F";
                }

                return letterGrade;
            }
        }

        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            this.possibleMarks = possibleMarks;

            this.submitterName = submitterName;
        }

    }
}
