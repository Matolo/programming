namespace Assignment1
{
    internal class Program
    {
        const string standardAlphabet = "abcdefghijklmnopqrstuvwxyz";
        static void Main(string[] args)
        {
            Program myProgram= new Program();
            myProgram.Start();
        }
        void Start()
        {
            Console.Write("Enter a message: ");
            string message = Console.ReadLine();
            Console.Write("Enter the secret key: ");
            string key = Console.ReadLine();

            string substitutionAlphabet = CreateSubstitutionAlphabet(key, standardAlphabet);

            string encryptedMessage = ReplaceText(message, standardAlphabet, substitutionAlphabet);
            Console.WriteLine($"encrypted message: {encryptedMessage}");
            string decryptedMessage = ReplaceText(encryptedMessage, substitutionAlphabet, standardAlphabet);
            Console.WriteLine($"decrypted message: {decryptedMessage}");

        }
        string CreateSubstitutionAlphabet(string key, string standardAlphabet)
        {
            string subAlphabet = "";
            foreach (char c in key)
            {
                if(!subAlphabet.Contains(c))
                    subAlphabet = subAlphabet + c;
            }
            foreach(char c in standardAlphabet)
            {
                if(!subAlphabet.Contains(c))
                    subAlphabet = subAlphabet + c;
            }
            return subAlphabet;
        }
        string ReplaceText(string input, string standardAlphabet, string substitutionalAlphabet)
        {
            string output = "";

            int index;
            for (int i = 0; i < input.Length; i++)
            {
                if (!standardAlphabet.Contains(input[i]))
                {
                    output = output + input[i];
                }
                else
                {
                    index = standardAlphabet.IndexOf(input[i]);
                    output = output + substitutionalAlphabet[index];
                }
            }
            return output;
        }
    }
}