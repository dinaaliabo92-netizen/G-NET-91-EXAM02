using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_91_EXAM02
{
    internal sealed class FinalExam : Exam
    {
        public FinalExam(int numberOfQuestions, Question[] questionsList, int examDuration)
            : base(numberOfQuestions, questionsList, examDuration)
        {
        }

        public sealed override void ShowExam()
        {
            TakeExam();

            decimal totalMarks = 0;
            decimal userGrade = 0;

            
            Console.Clear();
            Console.WriteLine("=================== Final Exam Results ===================\n");

            for (int i = 0; i < QuestionsList.Length; i++)
            {
                var q = QuestionsList[i];
                totalMarks += q.Mark;
                if (q.RightAnswer != null && q.UserAnswer != null && q.RightAnswer.AnswerId == q.UserAnswer.AnswerId)
                {
                    userGrade += q.Mark;
                }

                Console.WriteLine($"Q{i + 1}: {q.BodyOfQuestion}");
                Console.WriteLine($"Your Answer ID : {q.UserAnswer?.AnswerId}");
                Console.WriteLine($"Right Answer ID: {q.RightAnswer?.AnswerId} ({q.RightAnswer?.AnswerText})");
                Console.WriteLine($"Mark           : {q.Mark}");
                Console.WriteLine("------------------------------------------------");
            }
            Console.WriteLine($"\nYour Grade  : {userGrade} / {totalMarks}");
            Console.WriteLine($"Time Elapsed: {Math.Round(Time, 2)} Minutes");
        }
    }
}
