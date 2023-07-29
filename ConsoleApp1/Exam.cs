using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Exam
    {
        public int TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }
        public Exam(int timeOfExam, int numberOfQuestions)
        {
            TimeOfExam = timeOfExam;
            NumberOfQuestions = numberOfQuestions;
        }

        public void ExamFunctionality()
        {
            Console.WriteLine("Exam");

        }
      
        public override string ToString()
        {
            return $"Time:{TimeOfExam} \nNoOfQuestions:{NumberOfQuestions}";
        }
    }
}
