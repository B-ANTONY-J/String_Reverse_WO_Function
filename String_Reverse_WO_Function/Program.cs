namespace String_Reverse_WO_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"\nPlease enter a name you would like to see the reverse order of and to see " +
                $"whether or not it is a palindrome:");
            string stringInput = Convert.ToString(Console.ReadLine()).ToLower();

            string justAString = stringInput;

            //string reverse = String.Empty;
            string forward = "";

           // string reverseWord = forward.Reverse().ToString();
            //string stringArray = stringInput.Reverse().ToString();


            for (int i = justAString.Length - 1; i >= 0; i--)
            // forward loop for (int i = 0; i >= justAString.Length - 1; i++)
            //for (int i = 0; i >= justAString.Length -1; i--)
            {
                //reverse += stringArray[i];
                Console.WriteLine(forward += justAString[i]);

            }
            if (forward == stringInput)
            {
                Console.WriteLine(forward);
                Console.WriteLine($"\nThis is a Palindrome\n");
            }
            else
            {
                Console.WriteLine($"\nThis is not a Palindrome\n");
            }
            Console.WriteLine(forward);
            


        }

    }
}