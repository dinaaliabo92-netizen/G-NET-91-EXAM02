using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_91_EXAM02
{
    internal class Answers :ICloneable
    {
        public Answers()
        {
        }

        public Answers(int answerId, string? answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }

        public int AnswerId { get; set; }
        public string? AnswerText {  get; set; }

        public object Clone()
        {
            return new Answers(this.AnswerId, this.AnswerText);
        }
        public override string ToString()
        {
            return $"{AnswerText} {AnswerId}";
        }
    }
}
