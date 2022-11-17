namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter course name: ");
            string courseName = Console.ReadLine();
            Console.Write("Enter number of students: ");
            int numStudents = int.Parse(Console.ReadLine());
            string[] students = new string[numStudents];
            int[] grades = new int[numStudents];
            Console.WriteLine();

            for (int i = 0; i < numStudents; i++)
            {
                Console.Write($"Enter name of student {i + 1}: ");
                students[i] = Console.ReadLine();
            }

            Console.WriteLine();
            int sum = 0;

            for (int i = 0; i < numStudents; i++)
            {
                Console.Write($"Enter grade of {students[i]}: ");
                grades[i] = int.Parse(Console.ReadLine());
                sum += grades[i];
            }

            Console.WriteLine();
            double avg = (double)sum / numStudents;
            Console.WriteLine($"Average grade: {avg:0.0}");

            int indexHighest = 0;
            for (int i = 1;i<numStudents;i++)
            {
                if (grades[indexHighest] < grades[i])
                    indexHighest = i;
                    
            }
            
            Console.WriteLine($"Student {students[indexHighest]} has highest grade: {grades[indexHighest]}\n");

            for (int i = 0; i<numStudents; i++)
            {
                Console.WriteLine($"Grade for student {students[i]} (course {courseName}): {grades[i]}");
            }

        }
    }
}