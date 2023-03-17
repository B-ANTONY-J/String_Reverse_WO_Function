namespace String_Reverse_WO_Function
{   //This code will be restructed to have the UI methods placed in a different file
   
    internal class Program
    {
        static void Main(string[] args)

        {
            //Method to call userDisplay Console.WrilteLine
            UIMethods.UserDisplay();
          
            //Method called to iterate user input through a for loop and then compares the output to the conditional statements
            UIMethods.StringInputLoop();
      
           //UIMethods.IfElseInput();
            
        }

    }
}