﻿namespace String_Reverse_WO_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"\nPlease enter a name you would like to see the reverse order of and to see " +
                $"whether or not it is a palindrome:");
            string stringInput = Convert.ToString(Console.ReadLine()).ToLower();

           
            string forward = "";

            for (int i = stringInput.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(forward += stringInput[i]);

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