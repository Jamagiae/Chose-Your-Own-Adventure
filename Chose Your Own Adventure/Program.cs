using System;

namespace Chose_Your_Own_Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");


            Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");


            Console.Write("Type YES or NO:  ");
            string noiseChoice = Console.ReadLine();
            noiseChoice = noiseChoice.ToUpper();
            Console.WriteLine(noiseChoice);

            if (noiseChoice == "NO")
            {
                Console.WriteLine("Ninja jumps through window assassinate everyone");
                Console.WriteLine("THE END");
            }
            else if (noiseChoice == "YES")
            {
                Console.WriteLine("You go to investigate.");
                Console.WriteLine("Hmm... you listen again. But theres no sound ");
                Console.WriteLine("Should you open or knock?");

                            
            }

            Console.WriteLine("Type OPEN or KNOCK");
            string doorChoice = Console.ReadLine();
            doorChoice = doorChoice.ToUpper();

            if (doorChoice == "KNOCK")
            {
                Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \"");
                Console.WriteLine("\"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
                Console.Write("Type your answer: ");
                string riddleAnswer = Console.ReadLine();
                riddleAnswer = riddleAnswer.ToUpper();
                
                if(riddleAnswer == "NOTHING")
                {
                    Console.WriteLine("The door opens and NOTHING is there.");
                    Console.WriteLine("You turn off the light and run back to your room and lock the door.");
                    Console.WriteLine("THE END.");
                }
                else
                {
                    Console.WriteLine("You answered incorrectly. The door doesn't open.");
                    Console.WriteLine("THE END.");
                }
            }
            else if (doorChoice == "OPEN")
            {
                Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                Console.WriteLine("Enter a number (1-3)");

                string keyChoice = Console.ReadLine();
                switch (keyChoice)
                {
                    case "1":
                        Console.WriteLine("You choose the first key. Lucky choice! The door opens and NOTHING is there.Strange... THE END.");                      
                        break;

                    case "2":
                        Console.WriteLine("You choose the second key. The door doesn't open. THE END.");
                        break;

                    case "3":
                        Console.WriteLine("You choose the third key. The door doesn't open. THE END.");
                        break;
                }
            }
        }
    }
}
