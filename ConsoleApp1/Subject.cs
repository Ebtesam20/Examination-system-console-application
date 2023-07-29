using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; } = string.Empty;
        public string ExamSubject { get; set; }
        public Subject(int subjectId, string examSubject)
        {
            SubjectId = subjectId;
            ExamSubject = examSubject;
        }
        public Subject(int subjectId, string subjectName, string examSubject)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
            ExamSubject = examSubject;
        }


        #region Create Exam
        public void CreateExam()
        {
            int ExamType;
            bool flag;
            int ExamTime;
            int QuestionNumbers;

            do
            {
                Console.WriteLine("Please Enter Type of Exam (1 for Practical | 2 for Final)");
                flag = int.TryParse(Console.ReadLine(), out ExamType);
            }
            while (!flag || !(ExamType == 1 || ExamType == 2));

            do
            {
                Console.WriteLine("Please Enter Time of Exam ");
                flag = int.TryParse(Console.ReadLine(), out ExamTime);
            }
            while (!flag || !(ExamTime > 0));

            do
            {
                Console.WriteLine("Please Enter Number of Questions ");
                flag = int.TryParse(Console.ReadLine(), out QuestionNumbers);
            }
            while (!flag || !(QuestionNumbers > 0));


            #region Check For The Exam Type

            if (ExamType == 1)
            {
                PracticalExam practicalExam = new PracticalExam(ExamTime, QuestionNumbers);
                //Console.WriteLine(practicalExam);
                Console.Clear();
                practicalExam.ExamFunctionality();
            }
            else if (ExamType == 2)
            {
                FinalExam finalExam = new FinalExam(ExamTime, QuestionNumbers);
                //Console.WriteLine(finalExam);
                Console.Clear();
                finalExam.ExamFunctionality();
            }
            else
            {
                Console.WriteLine("Please Enter (1 for Practical | 2 for Final) only");

            } 
            #endregion


        } 
        #endregion
    }
}
