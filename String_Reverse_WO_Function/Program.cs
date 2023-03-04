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

            string outerLoop = string.Empty;
            string innerLoop = string.Empty;

            for (int j = 0; j < stringInputForward.Length; j++)

            {
                Console.WriteLine(outerLoop += stringInputForward[j]);

            }
            Console.WriteLine($"\nThe Forward Loop(Outer loop) string results are above.\n");
            {

                for (int k = stringInputForward.Length - 1; k >= 0; k--)
                {
                    Console.WriteLine(innerLoop += stringInputForward[k]);

                }
                Console.WriteLine($"\nThe Reverse Loop(Inner Loop) string results are above\n");
                if (outerLoop == innerLoop)
                {
                    Console.WriteLine($"\nFinally this compares the forward string of {outerLoop} and the reverse string of {innerLoop} which makes the result a palinDrome!");
                }
                else
                {
                    Console.WriteLine($"\nThis reverse string of {innerLoop} is not a Palindrome of the forward string {outerLoop}");
                }
            }

        }

    }
}