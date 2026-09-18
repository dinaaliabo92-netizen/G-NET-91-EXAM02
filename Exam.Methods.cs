using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_91_EXAM02
{
    internal abstract partial class Exam
    {
        protected void TakeExam()
        {
            Console.Clear();
            Console.WriteLine($"=================== Exam Started (Duration: {ExamDuration} Mins) ===================\n");

            startTime = DateTime.Now;
            DateTime maxAllowedTime = startTime.AddMinutes(ExamDuration);

            for (int i = 0; i < QuestionsList.Length; i++)
            {

                if (DateTime.Now >= maxAllowedTime)
                {
                    Console.WriteLine("\n Time's up! The exam has ended.");
                    break;
                }

                Console.WriteLine($"Question {i + 1}:");
                QuestionsList[i].DisplayQuestion();

                int userAnswerId;
                while (true)
                {
                    Console.Write("\nYour Answer (Enter Answer ID): ");
                    if (!int.TryParse(Console.ReadLine(), out userAnswerId))
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                        continue;
                    }


                    bool validAnswer = false;
                    foreach (var ans in QuestionsList[i].AnswersList!)
                    {
                        if (ans.AnswerId == userAnswerId)
                        {
                            validAnswer = true;
                            break;
                        }
                    }

                    if (!validAnswer)
                    {
                        Console.WriteLine("Invalid Answer ID. Please choose from the listed answers.");
                        continue;
                    }

                    break;
                }


                QuestionsList[i].UserAnswer = new Answers(userAnswerId, "");
                Console.WriteLine("\n------------------------------------------------\n");
            }

            endTime = DateTime.Now;
            Console.WriteLine("\n=================== Exam Finished ===================");
        }
        public abstract void ShowExam();
    }
}
