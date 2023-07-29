using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class FinalExam:Exam
    {

        public FinalExam(int timeOfExam, int numberOfQuestions) : base(timeOfExam, numberOfQuestions)
        {

        }

        #region Exam Functionality
        public new void ExamFunctionality()
        {
            int QuestionType;
            bool flag;
            List<Question> _Questions = new List<Question>();
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                do
                {
                    Console.WriteLine($"Please Enter Type of Question {i + 1} (1 for True|False | 2 for Mcq) ");
                    flag = int.TryParse(Console.ReadLine(), out QuestionType);
                }
                while (!flag || !(QuestionType == 1 || QuestionType == 2));


                if (QuestionType == 1)
                {
                    T_FQuestion t_FQuestion = new T_FQuestion();
                    t_FQuestion.QuestionCearte();
                    _Questions.Add(t_FQuestion);
                }
                else if (QuestionType == 2)
                {
                    MCQOneChoise mCQOneChoise = new MCQOneChoise();
                    mCQOneChoise.QuestionCearte();
                    _Questions.Add(mCQOneChoise);
                }



            }
            


            #region Starting The Exam
            Console.WriteLine("Do You Want To Start Exam (Y|N):");
            if (Char.Parse(Console.ReadLine()) == 'y')
            {
                Console.Clear();
                Stopwatch sw = new Stopwatch();
                sw.Start();
                ShowExam(_Questions);
                Console.WriteLine($"Your Elapsed Time In The Exam is: {sw.Elapsed}");


            }
            #endregion

        } 
        #endregion


        #region Show Exam
        public void ShowExam(List<Question> _Questions)
        {
            for (int i = 0; i < _Questions.Count; i++)
            {
                int UserAnswer;
                bool flag;

                Console.WriteLine($"{_Questions[i].QuestionHeader}    ");
                Console.WriteLine($"Q{i + 1}: {_Questions[i].QuestionBody}          {_Questions[i].Marks} Mark");

                for (int j = 0; j < _Questions[i].AnswersList.Length; j++)
                {
                    Console.WriteLine($"\n{j + 1}. {_Questions[i].AnswersList[j].AnswerText} ");

                }
                do
                {
                    Console.Write("Enter Your Answer:  ");
                    flag = int.TryParse(Console.ReadLine(), out UserAnswer);
                }
                while (!flag || !(UserAnswer > 0));

                _Questions[i].UerAnwer = UserAnswer;

                Console.WriteLine("--------------------------------------------------------------------------");
            }
            Console.Clear();
            CalcScore(_Questions);
        }
        #endregion

        #region Calculate Score
        public void CalcScore(List<Question> _Questions)
        {
            int Score = 0, Total = 0;
            for (int i = 0; i < _Questions.Count; i++)
            {
                if (_Questions[i].UerAnwer == _Questions[i].CorrectAnswer)
                {
                    Score += _Questions[i].Marks;
                }

                Total += _Questions[i].Marks;
            }
            PrintScore(_Questions, Score, Total);
        }
        #endregion

        #region Print Score
        public void PrintScore(List<Question> _Questions, int score, int total)
        {
            string Answer = "";
            Console.WriteLine("Your Answers:");
            for (int i = 0; i < _Questions.Count; i++)
            {
                for (int j = 0; j < _Questions[i].AnswersList.Length; j++)
                {
                    if (_Questions[i].UerAnwer == _Questions[i].AnswersList[j].AnswerId)
                    {
                        Answer = _Questions[i].AnswersList[j].AnswerText;
                    }
                }
                Console.WriteLine($"Q{i + 1}: {_Questions[i].QuestionBody} : {Answer}");
            }

            Console.WriteLine("\n------------------------------------------------------------\n");

            Console.WriteLine($"Your Total Score: {score} of {total}");




        }

        #endregion

    }
}
