using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_91_EXAM02
{
    internal sealed class TrueFalseQuestion:Question
    {
        public TrueFalseQuestion()
        {
        }

        public TrueFalseQuestion(string headerOfQuestion, string bodyOfQuestion, int mark, Answers rightAnswer) : base(headerOfQuestion, bodyOfQuestion, mark)
        {
            AnswersList = new Answers[]
            {
                new Answers(1, "True"),
                new Answers(2, "False")
            };
            RightAnswer = rightAnswer;
        }

        public sealed override void DisplayQuestion()
        {
            Console.WriteLine($"{HeaderOfQuestion}\tMark: {Mark}");
            Console.WriteLine($"{BodyOfQuestion}");
            foreach (var answer in AnswersList!)
            {
                Console.WriteLine(answer);
            }
        }
    }
}
