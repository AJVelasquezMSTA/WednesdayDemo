using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            string userYesMath, userNoMath;
            int x, y;
            x = 7;
            y = x + 3;
      
            userYesMath = "y";
            userNoMath = "n";

            Console.WriteLine("Hello World!");
            Console.WriteLine("Let's start the day with something new!");
            Console.WriteLine("What's your favorite color?");
            string userColor = Console.ReadLine();

            Console.WriteLine("Nice! Your favorite color is {0}", userColor);
            Console.WriteLine("Mine is yellow! Hey, do you like math? [y] or [n]");
            string userMathLover = Console.ReadLine();


            if (userMathLover == userYesMath)
                Console.WriteLine("Cool, me too! I want to show you some math I can do!");
            else if (userMathLover == userNoMath)
                Console.WriteLine("That's okay! I can help you avoid some math work. Let me show you how.");
            else
                Console.WriteLine("Oh, I didn't quite get that. I'll show you what I can do anyways.");

            //Console.WriteLine("I'll store that for later. Let's add some numbers together!");

            Console.WriteLine("I got " + y + " from adding 7 and 3 together. Why don't you tell me the first number you want to add?");
            x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Thanks. Now, what's the second number you want to add to " + x + "?");
            int z = Int32.Parse(Console.ReadLine());

            int userAdd = x + z;

            Console.WriteLine(z + "! Okay, so I will add " + x + " and " + z + " together! This equals " + userAdd);
            string userInput = Console.ReadLine();
            Console.WriteLine(userInput + "? I'm sorry. I don't know why you would say that. Do you think you can rephrase that?");
            string userTries = Console.ReadLine();
            Console.WriteLine(userTries + "... I don't think I like your tone. Maybe I should leave you alone.");
        }
    }
}
