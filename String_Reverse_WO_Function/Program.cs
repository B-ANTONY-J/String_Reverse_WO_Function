namespace String_Reverse_WO_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine($"\nPlease enter a name you would like to see the reverse order of and to see " +
                $"whether or not it is a palindrome:");
            StringReverse(Convert.ToString(Console.ReadLine()));

        }
        private static void StringReverse(string stringInput)
        {
            // Reverse using for loop  
            //Convert input string to char array and loop through  
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