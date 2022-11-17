namespace assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            int score = int.Parse(Console.ReadLine());

            /*if (score >= 90)
            {
                Console.WriteLine("Grade: A");
                Console.WriteLine("course passed");
            }
            else if (score >= 80 && score <= 89)
            {
                Console.WriteLine("Grade: B");
                Console.WriteLine("course passed");
            }
            else if (score >= 70 && score <= 79)
            {
                Console.WriteLine("Grade: C");
                Console.WriteLine("course passed");
            }
            else if (score >= 60 && score <= 69)
            {
                Console.WriteLine("Grade: D");
                Console.WriteLine("course not passed");
            }
            else if (score < 60)
            {
                Console.WriteLine("Grade: F");
                Console.WriteLine("course not passed");
            }*/

            switch (score)
            {
                case >= 90:
                    Console.WriteLine("Grade: A");
                    Console.WriteLine("course passed");
                    break;
                case  >= 80 and <= 89:
                    Console.WriteLine("Grade: B");
                    Console.WriteLine("course passed");
                    break;
                case >= 70 and <= 79:
                    Console.WriteLine("Grade: C");
                    Console.WriteLine("course passed");
                    break;
                case >= 60 and <= 69:
                    Console.WriteLine("Grade: D");
                    Console.WriteLine("course not passed");
                    break;
                default:
                    Console.WriteLine("Grade: F");
                    Console.WriteLine("course not passed");
                    break;
                }

        }
    }
}