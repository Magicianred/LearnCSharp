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
            // bool print = true;
            // Console.WriteLine($"{Environment.NewLine}I have {actual} {animal}, but I'd love to have {ideal}");
            // Console. WriteLine(print);

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
            // int i = 0;
            // while (i < 5) {
            //     Console.Write("While:  ");
            //     Console.WriteLine(i);
            //     i++;
            // }
            
            // for (int j = 4; j >= 0; j--) {
            //     Console.Write("For:  ");
            //     Console.WriteLine(j);
            // }

            // CHALLENGE
            /*
            Set up a simple chat bot for your local restaurant
            Ask for their food order and save that as a string "food"
            Ask for their drink order and save that as a string "drink"
            If they want water, ask if they want a lemon with that and save that value as a boolean "lemon"
            No matter the drink, ask if they want ice and save that as a boolean named "ice"
            Ask them how much they want to tip you. Should you use double or int or string?
            Print all of that out in a readable message!
            */
            // Console.WriteLine("What would you like to eat?");
            // string food = Console.ReadLine();
            // Console.WriteLine("What would you like to drink?");
            // string drink = Console.ReadLine();

            // bool ice = false;
            // Console.WriteLine("Would you like ice? y/n");
            // if (Console.ReadLine() == "y" ) {
            //     ice = true;
            // }

            // if (drink.ToLower() == "water") {
            //     bool lemon = false;
            //     Console.WriteLine("Would you like a lemon? y/n");
            //     if (Console.ReadLine() == "y" ) {
            //         lemon = true;
            //     }

            //     if (lemon) {
            //         drink = "water with lemon";
            //     }
            // }

            // if (ice) {
            //     drink = drink + " with ice";
            // }

            // Console.WriteLine("How much would you like to tip?");
            // string tip = Console.ReadLine();

            // Console.WriteLine($"{Environment.NewLine}I'll get your order of {food} and {drink} right away! Thank you for the ${tip} tip.");
        }
    }
}
