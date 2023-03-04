namespace String_Reverse_WO_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"\nPlease enter a name you would like to see the reverse order of and to see " +
                $"whether or not it is a palindrome: ");

            string stringInputForward = Convert.ToString(Console.ReadLine()).ToLower();
            Console.WriteLine("\n");

            string forwardLoop = string.Empty;
            string reverseLoop = string.Empty;

            for (int j = 0; j < stringInputForward.Length; j++)
            {
                Console.WriteLine(forwardLoop += stringInputForward[j]);

            }
            Console.WriteLine($"\nThe Forward Loop string results are above.\n");

            for (int k = stringInputForward.Length - 1; k >= 0; k--)
            {
                Console.WriteLine(reverseLoop += stringInputForward[k]);

            }
            Console.WriteLine($"\nThe Reverse Loop string results are above\n");

            if (forwardLoop == reverseLoop)
            {
                Console.WriteLine($"\nFinally this forward string result of {forwardLoop} and the reverse string results of {reverseLoop} are equal which makes the result a palinDrome!");
            }
            else
            {
                Console.WriteLine($"\nThis reverse string results of {reverseLoop} is not a Palindrome of the forward string result of {forwardLoop}");
            }


        }

    }
}