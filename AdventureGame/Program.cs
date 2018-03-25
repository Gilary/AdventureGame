/*
 * AdventureGame: Strangers
 * Tilly, 24-3-2018
 *  
 * This work is a derivative of 
 * "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
 * https://creativecommons.org/licenses/by/4.0/
 */

using System;

namespace AdventureGame
{
    public static class Game
    {
        static void Dialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(message);
            Console.ResetColor();
        }

        //character name
        static string CharacterName = "Espen";

        //print out game title and overview
        public static void StartGame()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "ASCII Art";
            string title = @"
------------------------------------------------
      _                                       
     | |                                      
  ___| |_ _ __ __ _ _ __   __ _  ___ _ __ ___ 
 / __| __| '__/ _` | '_ \ / _` |/ _ \ '__/ __|
 \__ \ |_| | | (_| | | | | (_| |  __/ |  \__ \
 |___/\__|_|  \__,_|_| |_|\__, |\___|_|  |___/
                           __/ |              
                          |___/               
-------------------------------------------------
            Press enter to continue...
            ";
            Console.WriteLine(title);
            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("Welcome stranger, are you from around here? You do not look familiar!\n");
            NameCharacter();
            Choice();
        }

        //ask player for a name, and save it
        static void NameCharacter()
        {
            Console.WriteLine("Before we start our adventure you should tell me your name then stranger.\n");
            Dialog("So what is your name stranger?\n");
            CharacterName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(CharacterName + ", what a great name for a stranger!\n");
            Console.WriteLine("So let's get started, " + CharacterName + ".\n");
            Dialog("Press enter to continue...\n");
            Console.ReadKey();
            Console.Clear();
        }
        //Choosing
        static void Choice()
        {
            Console.WriteLine("A stranger approaches. Clearing their throat to get your attention, they ask... \n");
            Console.WriteLine("Have you seen a strange creature around here?\nAbout three feet high, greenish, with fluffy hair?\n");
            Dialog("How do you answer, yes or no?\n");

            string input = "";
            input= Console.ReadLine();
            input = input.ToLower();

            if (input == "yes")
            {
                Console.WriteLine("Great which way did he go, wait nevermind I think I remember where the creature went, bye!\n");
            }
            else if (input == "no")
            {
                Console.WriteLine("Hmmm, i'll ask somebody else, bye\n");
            }
            else
            {
                Console.WriteLine("Are you sure " + CharacterName + " ? I know your name so be carefull mwuahahaha, bye!\n");
            }
            Dialog("Press enter to continue...\n");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("After saying goodbye to the weird stranger, you end up at the front of the imposing building.\nHere you see a weathered old stranger with a cart.\nAs you near, you see the cart is filled with what looks like mostly junk and only a few useful items.\nAll you have on you is piece of a chalk.\n");
            Dialog("You offer it to him, and he says he'll trade a flashlight or an umbrella for it.\nWhich do you choose?\n");

            string inputTwo = "";
            inputTwo = Console.ReadLine();
            inputTwo = inputTwo.ToLower();

            if (inputTwo == "flashlight")
            {
                Console.WriteLine("It is dark. The power in the building has gone out - luckily you have a flashlight!\n You move the light around and a large animal is frightened by the sudden brightness and takes off.\n As you move the light again, something glitters. You reach down and pick up a coin!\n");
            }
    
            else if (inputTwo == "umbrella")
            {
                Console.WriteLine("The power in the building goes out!\nAs you move down the hallway you hear what sounds like a large animal nearby.\nYou move the umbrella in a widening arc in front of you to scare it, and the animal skitters off.\n");
            }
            else
            {
                Console.WriteLine("The power in the building goes out.\nThe weatherd old stranger starts running away with your only piece of chalk, the old stranger is faster then he looks.\n");
            }

            Dialog("Press enter to continue...\n");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("The lights return and you move into a room at the end of the hall. There is a vending machine.\n");
            Dialog("Press enter to continue...\n");
            Console.ReadKey();
        }
        }
    class Item {}
    class Program
    {
        static void Main()
        {
            Game.StartGame();
            Console.ReadKey();
            /* string CharacterName = "Espen";

             Console.WriteLine("----------");
             Console.WriteLine("Strangers");
             Console.WriteLine("----------");
             Console.WriteLine("Welcome stranger, are you from around here? You do not look familiar!");
             Console.WriteLine("Before we start our adventure you should tell me your name then stranger.");
             Console.WriteLine("So what is your name stranger?");
             CharacterName = Console.ReadLine();
             Console.WriteLine(CharacterName + ", what a great name for a stranger!");
             Console.WriteLine("So let's get started " + CharacterName +".");
             Console.Read();*/
        }
    }
}
