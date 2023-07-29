using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class MCQOneChoise: Question
    {
        public MCQOneChoise()
        {
                
        }
        public MCQOneChoise(string _QuestionHeader, string _QuestionBody, int _Marks, Answer[] _AnsweList, int _CorrectAnswer) : base(_QuestionHeader, _QuestionBody, _Marks, _AnsweList, _CorrectAnswer)
        {

        }
        #region Create Question
        bool flag;
        string Choose;
        public void QuestionCearte()
        {
            int Mark, CorrectAnswerId;
            QuestionHeader = "MCQ One Choise Question ";
            Console.WriteLine("Enter The Body Of Question");
            QuestionBody = Console.ReadLine();
            do
            {
                Console.WriteLine("Enter The Mark Of Question");
                flag = int.TryParse(Console.ReadLine(), out Mark);
            }
            while (!flag || !(Mark > 0));

            Marks = Mark;

            int ChoisesLength;
            do
            {
                Console.Write("Enter The Length of Choices:");
                flag = int.TryParse(Console.ReadLine(), out ChoisesLength);
            }
            while (!flag || !(ChoisesLength > 0));

            AnswersList = new Answer[ChoisesLength];

            for (int i = 0; i < ChoisesLength; i++)
            {
                Console.WriteLine($"Please Enter The Choose {i + 1}");
                Choose = Console.ReadLine();
                AnswersList[i] = new Answer() { AnswerId = i + 1, AnswerText = Choose };
            }


            do
            {
                Console.WriteLine("Enter The Correct Answer Of Question:");
                flag = int.TryParse(Console.ReadLine(), out CorrectAnswerId);
            }
            while (!flag || !(CorrectAnswerId > 0) || !(CorrectAnswerId <= ChoisesLength));
            CorrectAnswer = CorrectAnswerId;

            Console.Clear();

        } 
        #endregion
        public override string ToString()
        {
            return $"QuestionHeader:{QuestionHeader}    QuestionBody:{QuestionBody}";
        }
    }
}
