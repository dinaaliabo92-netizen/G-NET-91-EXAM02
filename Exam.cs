using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_91_EXAM02
{
    internal abstract partial class Exam
    {

        private DateTime startTime;
        private DateTime endTime;
        public int NumberOfQuestions { get; set; }
        public Question[] QuestionsList { get; set; }
        public int ExamDuration {  get; private set; }
        public double Time { 
            get 
            {
                if (startTime == DateTime.MinValue)
                {
                    return 0;
                }
                else if (endTime == DateTime.MinValue) {
                    return (DateTime.Now - startTime).TotalMinutes;
                }
                return (endTime - startTime).TotalMinutes;
            }
        }
        public Exam(int numberOfQuestions, Question[] questionsList, int examDuration)
        {
            NumberOfQuestions = numberOfQuestions;
            QuestionsList = questionsList;
            ExamDuration = examDuration;
        }
        
    }
}
