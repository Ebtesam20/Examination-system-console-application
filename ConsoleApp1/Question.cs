using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Question
    {
        public string QuestionHeader { get; set; }
        public string QuestionBody { get; set; }
        public int Marks { get; set; }
        public int CorrectAnswer { get; set; }
        public int UerAnwer { get; set; }
        public int[] CorrectAnswers { get; set; }
        public int[] UserAnswers { get; set; }
        public int CorectAnswersCount { get; set; }
        public Answer[] AnswersList { get; set; }
        public Question()
        {

        }
        public Question(string _QuestionHeader,string _QuestionBody,int _Marks, Answer[] _AnsweList, int _CorrectAnswer)
        { 
            QuestionHeader = _QuestionHeader;
            QuestionBody = _QuestionBody;
            Marks = _Marks;
            AnswersList = _AnsweList;
            CorrectAnswer = _CorrectAnswer;
        }

        public Question(string _QuestionHeader, string _QuestionBody, int _Marks, Answer[] _AnsweList, int _CorrectAnswerCount, int _CorrectAnswer , int[] _UserAnswers)
        {
            QuestionHeader= _QuestionHeader;
            QuestionBody= _QuestionBody;
            Marks = _Marks;
            AnswersList= _AnsweList;
            CorectAnswersCount = _CorrectAnswerCount;
            CorrectAnswer= _CorrectAnswer;
            UserAnswers = _UserAnswers;
        }



    }
}
