using System.Diagnostics;

namespace G_NET_91_EXAM02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Subject sub1 = new Subject(101, "C# Programming");

            sub1.PrintSubjectDetails();

            
            sub1.CreateExam();

         
            sub1.PrintSubjectDetails();

            Console.Clear();
            Console.Write("Do You Want To Start The Exam (Y | N): ");
            char choice = char.Parse(Console.ReadLine() ?? "n");

            if (choice == 'y' || choice == 'Y')
            {
                
                if (sub1.IsExamReady())
                {
                    Stopwatch sw = new Stopwatch();
                    sw.Start();

                    
                    sub1.SubjectExam!.ShowExam();

                    sw.Stop();
                    Console.WriteLine($"\nTotal Execution Time: {sw.Elapsed}");
                }
                else
                {
                    Console.WriteLine("No exam has been created yet!");
                }
            }
            else
            {
                Console.WriteLine("\nExam cancelled. Have a great day!");
            }
        }
    }
    }

