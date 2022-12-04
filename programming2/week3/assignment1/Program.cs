namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            List<Course> gradeList = ReadGradeList(3);
            DisplayGradeList(gradeList);
        }
        List<Course> ReadGradeList(int nrOfCourses)
        {
            Course course = new Course();
            List<Course> gradeList = new List<Course>();

            for (int i = 0; i < nrOfCourses; i++)
            {
                course = course.ReadCourse("Enter a course.");
                gradeList.Add(course);
            }
            return gradeList;
        }
        void DisplayGradeList(List<Course> gradeList)
        {

            int retakes = 0;
            int cumLaude = 0;

            foreach (Course course in gradeList)
            {
                Console.WriteLine($"{course.Name}: {course.TheoryGrade} {course.PracticalGrade}");

                //idk how to do it all in one loop, I will try later, for now this is my cheap solution
                if (!course.Passed())
                    retakes++;
                if (course.CumLaude())
                    cumLaude++;
            }
            if (retakes > 0)
                Console.WriteLine($"Too bad, you did not graduate, you got {retakes} retakes.");
            else
            {
                if (cumLaude == gradeList.Count)
                    Console.WriteLine("Congratulations, you graduated Cum Laude!");
                else
                    Console.WriteLine("Congratulations, you graduated!");
            }
        }
    }
}