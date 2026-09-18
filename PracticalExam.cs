using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_91_EXAM02
{
    internal sealed class PracticalExam : Exam
    {
        public PracticalExam(int numberOfQuestions, Question[] questionsList, int examDuration) : base(numberOfQuestions, questionsList, examDuration)
        {
        }

        public sealed override void ShowExam()
        {
            TakeExam();

            
            Console.Clear();
            Console.WriteLine("=================== Right Answers ===================\n");

            for (int i = 0; i < QuestionsList.Length; i++)
            {
                var q = QuestionsList[i];
                Console.WriteLine($"Q{i + 1}: {q.BodyOfQuestion}");
                Console.WriteLine($"Right Answer: {q.RightAnswer?.AnswerText} (ID: {q.RightAnswer?.AnswerId})");
                Console.WriteLine("------------------------------------------------");
            }

           
            Console.WriteLine($"\nTime Elapsed: {Math.Round(Time, 2)} Minutes");
        }
    }
}
