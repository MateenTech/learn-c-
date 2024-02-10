using System;


namespace BasicsOfCSharp
{
    class Program
    {
 
        static string GetUserName()
        {
            string userName = Console.ReadLine();
            return userName;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hi this is C#! What's your name? ");
            string fetchUserName = GetUserName();


            Console.WriteLine("Hi " + fetchUserName + "! I am so excited to welcome you to Hello World of C#.");
        }
    }
}