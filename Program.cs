using System;
using System.Threading;

namespace Magic8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomObj = new Random();

            ConsoleColor oldColour = Console.ForegroundColor;
            whatIsThisProgram();

            while (true)
            {

                String questionString = getQuestion();

                int timer = randomObj.Next(5) + 1;
                Console.WriteLine("Thing about your answer...");
                Thread.Sleep(timer * 1000);

                if(questionString.Length == 0)
                {
                    Console.WriteLine("You need to ask a question");
                    continue;
                }


                if(questionString.ToLower() == "quit")
                {
                    break;
                }


                int randomNumber = randomObj.Next(4);

                Console.ForegroundColor = (ConsoleColor)randomNumber;

                switch (randomNumber)
                {
                    case 0:
                        Console.WriteLine("YES!");
                        break;
                    case 1:
                        Console.WriteLine("Hell YES!!!!");
                        break;
                    case 2:
                        Console.WriteLine("NO!");
                        break;
                    case 3:
                        Console.WriteLine("Hell NO!!!!");
                        break;
                }                         
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("bye...");
                
            // Clean up Console
            Console.ForegroundColor = oldColour;
        }
        static void whatIsThisProgram()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Magic 8 Ball ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("(By: Matuesz)");
            Console.ForegroundColor = ConsoleColor.Green;
        }
        
        static String getQuestion()
        {
            // Asks the user a question
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ask a question?: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            String questionString = Console.ReadLine();

            return questionString;
        }
            
    }
}
