using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class T_FQuestion : Question
    {
        public T_FQuestion()
        {

        }
        public T_FQuestion(string _QuestionHeader, string _QuestionBody, int _Marks, Answer[] _AnsweList, int _CorrectAnswer) : base(_QuestionHeader, _QuestionBody, _Marks, _AnsweList, _CorrectAnswer)
        {

        }
        #region Create Question
        bool flag;
        public void QuestionCearte()
        {
            int Mark, CorrectAnswerId;
            QuestionHeader = "True | False Question ";
            Console.WriteLine("Enter The Body Of Question");
            QuestionBody = Console.ReadLine();
            do
            {
                Console.WriteLine("Enter The Mark Of Question");
                flag = int.TryParse(Console.ReadLine(), out Mark);
            }
            while (!flag || !(Mark > 0));

            Marks = Mark;

            do
            {
                Console.WriteLine("Enter The Correct Answer Of Question: 1 for True || 2 for False");
                flag = int.TryParse(Console.ReadLine(), out CorrectAnswerId);
            }
            while (!flag || !(CorrectAnswerId == 1 || CorrectAnswerId == 2));


            CorrectAnswer = CorrectAnswerId;



            AnswersList = new Answer[2]
            {
                new Answer() {AnswerId=1 , AnswerText="True"},
                new Answer() {AnswerId= 2 ,AnswerText="False"},
            };


            Console.Clear();
        } 
        #endregion
        public override string ToString()
        {
            return $"QuestionBody:{QuestionBody} Mark:{Marks} correctanswer:{CorrectAnswer}";
        }

    }
}
