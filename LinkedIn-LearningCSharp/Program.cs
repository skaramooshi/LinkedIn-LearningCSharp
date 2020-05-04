using System;

namespace LinkedIn_LearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var password = "";
            
            while (password != "secret")
            {

                Console.WriteLine("Input password");
                password = Console.ReadLine();

                if (password != "secret")
                {
                    Console.WriteLine("Incorrect password");
                }
            }
            Console.WriteLine("that is the correct password");


            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();
             
            Console.WriteLine("What month were you born?");
            var month = Console.ReadLine();

            Console.WriteLine("Your name is {0}", name);
            Console.WriteLine("Your age is {0}", age);
            Console.WriteLine("Your month of birth is {0}", month);

            if (month == "march")
             {
                    Console.WriteLine("You are an Aries.");
             }

            if (month == "April")
            {
                Console.WriteLine("You are an Taurus.");
            }

            if (month == "may")
            {
                Console.WriteLine("You are an Gemini.");
            }
        }
    }
}
