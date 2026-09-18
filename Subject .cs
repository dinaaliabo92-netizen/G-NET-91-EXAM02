using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_91_EXAM02
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }
        public Exam? SubjectExam { get; set; }

        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }
        public void CreateExam()
        {
            int examType, duration, numberOfQuestions;

           
            do
            {
                Console.Write("Enter Exam Type (1 for Final, 2 for Practical): ");
            }
            while (!int.TryParse(Console.ReadLine(), out examType) || (examType != 1 && examType != 2));

            
            do
            {
                Console.Write("Enter Exam Duration in Minutes: ");
            } 
            while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0);

          
            do
            {
                Console.Write("Enter Number of Questions: ");
            }
            while (!int.TryParse(Console.ReadLine(), out numberOfQuestions) || numberOfQuestions <= 0);

            Question[] questions = new Question[numberOfQuestions];

            for (int i = 0; i < numberOfQuestions; i++)
            {
                Console.Clear();
                int questionType = 1;

               
                if (examType == 1)
                {
                    do
                    {
                        Console.Write($"Question {i + 1} Type (1 for MCQ, 2 for True/False): ");
                    }
                    while (!int.TryParse(Console.ReadLine(), out questionType) || (questionType != 1 && questionType != 2));
                }

               
                Console.Write("\nEnter Question Body: ");
                string body = Console.ReadLine() ?? "";

             int mark;
                do
                {
                    Console.Write("Enter Question Mark: ");
                }
                while (!int.TryParse(Console.ReadLine(), out mark) || mark <= 0);

               
                if (questionType == 1) 
                {
                    Answers[] answers = new Answers[4];
                    Console.WriteLine("\nEnter 4 Choices:");
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write($"Choice {j + 1}: ");
                        string choiceText = Console.ReadLine() ?? "";
                        answers[j] = new Answers(j + 1, choiceText);
                    }

                    int rightAnswerId;
                    do
                    {
                        Console.Write("Enter Right Answer ID (1 to 4): ");
                    }
                    while (!int.TryParse(Console.ReadLine(), out rightAnswerId) || rightAnswerId < 1 || rightAnswerId > 4);

                    questions[i] = new McqQuestion
                    {
                        HeaderOfQuestion = "MCQ Question",
                        BodyOfQuestion = body,
                        Mark = mark,
                        AnswersList = answers,
                        RightAnswer = answers[rightAnswerId - 1]
                    };
                }
                else
                {
                    Answers[] answers = new Answers[]
                    {
                        new Answers(1, "True"),
                        new Answers(2, "False")
                    };

                    int rightAnswerId;
                    do
                    {
                        Console.Write("Enter Right Answer ID (1 for True, 2 for False): ");
                    } while (!int.TryParse(Console.ReadLine(), out rightAnswerId) || (rightAnswerId != 1 && rightAnswerId != 2));

                    questions[i] = new TrueFalseQuestion
                    {
                        HeaderOfQuestion = "True/False Question",
                        BodyOfQuestion = body,
                        Mark = mark,
                        AnswersList = answers,
                        RightAnswer = answers[rightAnswerId - 1]
                    };
                }
            }

          
            if (examType == 1)
            {
                SubjectExam = new FinalExam(numberOfQuestions, questions, duration);
            }
            else
            {
                SubjectExam = new PracticalExam(numberOfQuestions, questions, duration);
            }
        }
    }
}
