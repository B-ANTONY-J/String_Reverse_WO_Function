﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace String_Reverse_WO_Function
{
    public static class UIMethods
    {
        public static void UserDisplay()
        {
            Console.WriteLine("Lets begin this String Game!\n");
            Console.WriteLine($"\nPlease enter a name you would like to see the reverse order of and to see " +
                $"whether or not it is a palindrome: ");
        }

        public static void StringInputLoop()
        {

            string stringInputForward = Console.ReadLine().ToLower();
            string reverseLoop = string.Empty;

            for (int j = 0; j < stringInputForward.Length; j++)


                reverseLoop += stringInputForward[stringInputForward.Length - j - 1];

            Console.WriteLine($"\nThe reverse string of the input string is: ");
            Console.WriteLine($"{reverseLoop}\n");

            if (reverseLoop == stringInputForward)
            {
                Console.WriteLine($"\nFinally this reverse string result of {reverseLoop} matches the string input of {stringInputForward} which makes the result a palinDrome!\n");
            }
            else
            {
                Console.WriteLine($"\nThis reverse string result of {reverseLoop} is not a Palindrome of the input string {stringInputForward}\n");
            }
            Console.WriteLine("\n");
        }



    }
}

