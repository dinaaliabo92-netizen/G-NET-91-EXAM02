using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_91_EXAM02
{
    internal sealed class McqQuestion : Question
    {
        public McqQuestion()
        {
        }

        public McqQuestion(Answers[] answersList, Answers rightAnswer, Answers useAnwer, string headerOfQuestion, string bodyOfQuestion, int mark) : base(answersList, rightAnswer, useAnwer, headerOfQuestion, bodyOfQuestion, mark)
        {
        }
        public sealed override void DisplayQuestion()
        {
            Console.WriteLine($"{HeaderOfQuestion}\tMark: {Mark}");
            Console.WriteLine($"{BodyOfQuestion}");
            for (int i = 0; i < AnswersList?.Length; i++)
            {
                Console.WriteLine(AnswersList[i]);
            }
        }

    }
}
