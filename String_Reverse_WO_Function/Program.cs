namespace String_Reverse_WO_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine($"\nPlease enter a name you would like to see the reverse order of and to see " +
                $"whether or not it is a palindrome:");
            string stringInput = Convert.ToString(Console.ReadLine()).ToLower();

            char[] stringArray = stringInput.ToCharArray();

            string reverse = String.Empty;


            for (int i = stringArray.Length - 1; i >= 0; i--)
            {
                reverse += stringArray[i];
            }

            if (stringInput == reverse)
            {
                Console.WriteLine($"\nThis is a Palindrome\n");
            }
            else
            {
                Console.WriteLine($"\nIt's not a Palindrome\n");
            }
            Console.WriteLine(reverse);

        }

    }
}