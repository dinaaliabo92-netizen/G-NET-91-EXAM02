using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_91_EXAM02
{
    internal abstract class Question:IComparable<Question>,ICloneable
    {
        private string headerOfQuestion = string.Empty;
        private string bodyOfQuestion = string.Empty;
        private int mark;
        public Answers[]? AnswersList { get; set; }
        public Answers? RightAnswer { get; set; }
        public Answers? UserAnswer { get; set; }



        public string HeaderOfQuestion
        {
            get { return headerOfQuestion!; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Question text cannot be empty.");
                    return;
                }
                headerOfQuestion = value;
            }
        }

        public string BodyOfQuestion
        {
            get { return bodyOfQuestion!; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Question text cannot be empty.");
                    return;
                }
                bodyOfQuestion = value;
            }
        }
        public int Mark
        {
            get { return mark; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Mark cannot be negative.");
                    return;
                }
                mark = value;
            }

        }
        public Question(string headerOfQuestion, string bodyOfQuestion, int mark)
        {
            HeaderOfQuestion = headerOfQuestion;
            BodyOfQuestion = bodyOfQuestion;
            Mark = mark;
        }

        public Question(Answers[] answersList, Answers rightAnswer, Answers useAnwer, string headerOfQuestion, string bodyOfQuestion, int mark):this( headerOfQuestion,  bodyOfQuestion,  mark)
        {
            AnswersList = answersList;
            RightAnswer = rightAnswer;
            UserAnswer = useAnwer;
        }

        protected Question()
        {
            AnswersList = null!;
            RightAnswer = null!;
            UserAnswer = null!;
        }

        public abstract  void DisplayQuestion();

        public int CompareTo(Question? other)
        {
            if (other == null) return 1;
            return this.Mark.CompareTo(other.Mark);
        }


        public object Clone()
        {
            Answers[]? clonedAnswers = null;

            if (AnswersList != null)
            {
                clonedAnswers = new Answers[AnswersList.Length];
                for (int i = 0; i < AnswersList.Length; i++)
                {
                    clonedAnswers[i] = (Answers)AnswersList[i].Clone();
                }
            }

            
            var clonedQuestion = (Question)this.MemberwiseClone();
            clonedQuestion.AnswersList = clonedAnswers;

            return clonedQuestion;
        }

        public override string ToString()
        {
            return $"{HeaderOfQuestion}\n{BodyOfQuestion}\tMark: {Mark}";
        }
    }
}
