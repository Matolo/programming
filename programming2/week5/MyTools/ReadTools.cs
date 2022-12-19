using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTools
{
    public class ReadTools
    {
        public static int ReadInt(string question)
        {
            Console.Write(question);
            int input = int.Parse(Console.ReadLine());
            return input;
        }
        public static int ReadInt(string question, int min, int max)
        {
            int input = ReadInt(question);
            while (input < min || input > max)
                input = ReadInt(question);

            return input;
        }
        public static string ReadString(string question)
        {
            Console.Write(question);
            string name = Console.ReadLine();
            return name;
        }
    }
}
