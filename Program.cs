using System;

namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // STEP 1:
            // Console.WriteLine("Hello World!");

            // STEP 2:
            // Console.WriteLine("What is your name?");
            // var name = Console.ReadLine();
            // var date = DateTime.Now;
            // Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {date:d} at {date:t}!"); // The $ lets you use variable names in {}, similar to JavaScript!
            // Console.Write($"{Environment.NewLine}Press any key to exit...");
            // Console.ReadKey(true); // This leaves it open until a key is pressed

            // VARIABLES
            // string animal = "Goose";
            // int actual = 1, ideal = 5;
            // Console.WriteLine($"{Environment.NewLine}I have {actual} {animal}, but I'd love to have {ideal}");

            // USER INPUT
            // Console.WriteLine("What's your favorite food?");
            // string food = Console.ReadLine();
            // Console.WriteLine("Yummy! I love " + food + " too!");

            // IF STATEMENTS 
            // Console.WriteLine("What's your password?");
            // Console.Write(">> ");
            // string password = Console.ReadLine();
            // if (password == "password") {
            //     Console.WriteLine("Well, that's not very secure, huh");
            // } else if (password.Length < 8) {
            //     Console.WriteLine("Your password is way too short!");
            // } else {
            //     Console.WriteLine("Your password looks pretty good to me!");
            // }

            // LOOPS
            int i = 0;
            while (i < 5) {
                Console.Write("While:  ");
                Console.WriteLine(i);
                i++;
            }
            
            for (int j = 4; j >= 0; j--) {
                Console.Write("For:  ");
                Console.WriteLine(j);
            }
        }
    }
}
