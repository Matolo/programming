namespace assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter weight (kg): ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Enter height (cm): ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Enter gender (male/female): ");
            string gender = Console.ReadLine();

            double bmi = weight / Math.Pow(height/100, 2);
            Console.WriteLine($"\nbmi-value: {bmi:0.0}");

            
            double bmiMax, bmiMin;

            if (gender == "male")
            {
                bmiMin = 20 * Math.Pow(height / 100, 2);
                bmiMax = 25 * Math.Pow(height / 100, 2);

                Console.WriteLine("normal bmi-values (min .. max): 20..25");

            }
            else 
            {
                bmiMin = 19 * Math.Pow(height / 100, 2);
                bmiMax = 24 * Math.Pow(height / 100, 2);

                Console.WriteLine("normal bmi-values (min .. max): 19..24");
                
            }
            Console.WriteLine($"healthy weight range: {bmiMin:0.0} .. {bmiMax:0.0}");
        }
    }
}