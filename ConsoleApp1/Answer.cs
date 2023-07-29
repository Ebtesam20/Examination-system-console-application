using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get;set; }

        public Answer() { }
        public Answer(int _AnswerId, string _AnswerText)
        {
            AnswerId = _AnswerId;
            AnswerText = _AnswerText;  
        }
    }
}
