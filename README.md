# Learn C# with Mara
*As a disclaimer, Mara is also learning C# and is using [W3Schools](https://www.w3schools.com/cs/default.asp) as her wonderful guide - the following Read Me is mostly just notes from W3Schools*

## Development Environment

1. First, make sure that you have [Visual Studio Code](https://code.visualstudio.com/Download)
2. Second, download the `C#` extension in VS Code (the four squares in the left sidebar) and then restart VS Code
3. Also, download [.NET SDK](https://dotnet.microsoft.com/download/dotnet/sdk-for-vs-code?utm_source=vs-code&amp;utm_medium=referral&amp;utm_campaign=sdk-install), it lets you run the apps! Please fully exit out of VS Code before trying to use the command `dotnet`. 
4. Once you're in your preferred folder in VS Code, open your terminal and run `dotnet new console` to create a new .NET app. Test it by using `dotnet run`. It may take a second the first time!
5. Copy `STEP 2` code from this branch or the third step of Enhance the App on this [Microsoft Tutorial](https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code) and `dotnet run`

## Why C#?
Personally, for me, I worked with React apps at my last internship and they used C# as the back-end. I want to learn more so I can prepare myself to become a full stack engineer. As for in general...

C# is similar to C, C++, and Java so it's a relatively easy switch for a lot of programmers. It's a popular language that can be used for mobile, desktop, and web apps, websites, games, and more! *Fun fact: If you like Stardew Valley, you can use C# to make mods*
## Learning C# Syntax

### General File Format

`using System;` means that we can use classes from the System namespace (default)

`namespace LearnCSharp` is the container for our code, like our class!

`class Program` is declaring our class, a container for data and methods

`static void Main(string[] args)` is the code that's going to be executed

A couple things to note:
* Every statement must end with a semicolon `;`
* C# is case-sensitive
* .cs is the file extension
* If you want to comment, simply use `//`

### Printing to the Console
`Console.WriteLine("Hello World!");` prints Hello World to the console

### Variables
* `int` stores integers
* `double` stores floats
* `char` stores single characters
* `string` stores text
* `bool` stores true or false
* `const` isn't a type, but a great way to protect your variable from getting changed in the future

To make an int a string, use `Convert.ToString(IntVariableHere)`

