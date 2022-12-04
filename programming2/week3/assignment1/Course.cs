using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Course
    {
        public string Name;
        public int TheoryGrade;
        public PracticalGrade PracticalGrade;

        public PracticalGrade ReadPracticalGrade(string question)
        {
            Console.WriteLine("0. None 1. Absent 2. Insufficient 3. Sufficient 4. Good");
            PracticalGrade practical = (PracticalGrade)ReadInt(question);
            
            return practical;
        }
        public void DisplayPracticalGrade(PracticalGrade practical)
        {
            Console.Write(practical);
        }
        public Course ReadCourse(string question)
        {
            Course course = new Course();

            Console.WriteLine(question);
            course.Name = ReadString("Name of the course: ");
            course.TheoryGrade = ReadInt($"Theory grade for {course.Name}: ");
            course.PracticalGrade = ReadPracticalGrade($"Practical grade for {course.Name}: ");
            Console.WriteLine();

            return course;
        }
        public void DisplayCourse(Course course)
        {
            Console.WriteLine(course.Name);
            Console.WriteLine(course.TheoryGrade);
            Console.WriteLine(course.PracticalGrade);
        }
        public bool Passed()
        {
            return (TheoryGrade >= 55 && (PracticalGrade == PracticalGrade.Sufficient || PracticalGrade == PracticalGrade.Good)); 
        }
        public bool CumLaude()
        {
            return (TheoryGrade >= 80 && PracticalGrade == PracticalGrade.Good);
        }
        int ReadInt(string question)
        {
            Console.Write(question);
            int input = int.Parse(Console.ReadLine());
            return input;
        }
        string ReadString(string question)
        {
            Console.Write(question);
            string name = Console.ReadLine();
            return name;
        }
    }
}
