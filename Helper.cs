using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_91_EXAM02
{
    internal static class Helper
    {
        public static void PrintSubjectDetails(this Subject subject)
        {
            if (subject != null)
            {
                Console.WriteLine($"\n================ Subject Info ================");
                Console.WriteLine($"ID: {subject.SubjectId} | Name: {subject.SubjectName}");
                Console.WriteLine($"Status: {(subject.SubjectExam != null ? "Exam Prepared" : "No Exam Available")}");
                Console.WriteLine($"===============================================\n");
            }
        }

        public static bool IsExamReady(this Subject subject)
        {
            return subject != null && subject.SubjectExam != null;
        }
    }
}
