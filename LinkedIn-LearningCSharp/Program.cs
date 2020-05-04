using System;

namespace LinkedIn_LearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            for (int z = 1; z <= 5; z++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }

                for (int i = 10; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }
            }
            
            */
            
            
            /*
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
            */

            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            if(name == "") 
            {
                name = TryAgain();
            }

            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();

            if (age == "")
            {
                age = TryAgain();
            }


            Console.WriteLine("What month were you born?");
            var month = Console.ReadLine();

            if (month == "")
            {
                month = TryAgain();
            }


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

        static string TryAgain()
        {
            Console.WriteLine("You didn't write anything. Please try again.");
            return Console.ReadLine();
        }
    }
}
