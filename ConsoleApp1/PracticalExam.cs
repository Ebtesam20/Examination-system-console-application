using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PracticalExam : Exam
    {

        public PracticalExam(int timeOfExam, int numberOfQuestions) : base(timeOfExam, numberOfQuestions)
        {

        }
        #region Exam Functionality
        public new void ExamFunctionality()
        {
            List<Question> _Questions = new List<Question>();

            for (int i = 0; i < NumberOfQuestions; i++)
            {
                McqMultipleChoise mcqMultipleChoise = new McqMultipleChoise();
                mcqMultipleChoise.QuestionCearte();
                _Questions.Add(mcqMultipleChoise);

            }

            #region Starting The Exam
            Console.WriteLine("Do You Want To Start Exam (y|n):");
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

                Console.WriteLine($"{_Questions[i].QuestionHeader} ");
                Console.WriteLine($"Q{i + 1}: {_Questions[i].QuestionBody}           {_Questions[i].Marks} Mark");

                for (int j = 0; j < _Questions[i].AnswersList.Length; j++)
                {
                    Console.WriteLine($"\n{j + 1}. {_Questions[i].AnswersList[j].AnswerText} ");

                }

                Console.WriteLine($"\nChoose {_Questions[i].CorectAnswersCount} Answers\n");
                for (int k = 0; k < _Questions[i].CorectAnswersCount; k++)
                {
                    Console.Write($"Choose Answer No.{k + 1}: ");
                    do
                    {
                        flag = int.TryParse(Console.ReadLine(), out UserAnswer);
                    }
                    while (!flag);
                    _Questions[i].UserAnswers[k] = UserAnswer;

                }

                Console.WriteLine("--------------------------------------------------------------------------");
            }
            Console.Clear();

            PrintUserAnswers(_Questions);

        } 
        #endregion

        #region Print Answer Model
        public void PrintRightAnswers(List<Question> _Questions)
        {
            Console.WriteLine("The Answer Model is:");
            string[] AnswerModel = new string[15];

            for (int i = 0; i < _Questions.Count; i++)
            {
                Console.WriteLine($"Q{i + 1}: {_Questions[i].QuestionBody}");
                for (int j = 0; j < _Questions[i].CorectAnswersCount; j++)
                {
                    for (int k = 0; k < _Questions[i].AnswersList.Length; k++)
                    {
                        if (_Questions[i].CorrectAnswers[j] == _Questions[i].AnswersList[k].AnswerId)
                        {
                            AnswerModel[j] = _Questions[i].AnswersList[k].AnswerText;
                            Console.WriteLine(AnswerModel[j]);
                        }
                    }
                }
            }
        } 
        #endregion

        #region Print User Answer
        public void PrintUserAnswers(List<Question> _Questions)
        {
            Console.WriteLine("Your Answers are:");
            string[] EnteredAnswer = new string[20];

            for (int i = 0; i < _Questions.Count; i++)
            {
                Console.WriteLine($"Q{i + 1}: {_Questions[i].QuestionBody}");
                for (int j = 0; j < _Questions[i].UserAnswers.Length; j++)
                {
                    for (int k = 0; k < _Questions[i].AnswersList.Length; k++)
                    {
                        if (_Questions[i].UserAnswers[j] == _Questions[i].AnswersList[k].AnswerId)
                        {
                            EnteredAnswer[j] = _Questions[i].AnswersList[k].AnswerText;
                            Console.WriteLine(EnteredAnswer[j]);
                        }
                    }
                }
            }

            Console.WriteLine("\n------------------------------------------------------------\n");

            PrintRightAnswers(_Questions);
        } 
        #endregion




    }
}
