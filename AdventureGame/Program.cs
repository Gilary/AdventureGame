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
    class Program
    {
        static void Main()
        {
            string CharacterName = "Espen";

            Console.WriteLine("----------");
            Console.WriteLine("Strangers");
            Console.WriteLine("----------");
            Console.WriteLine("Welcome stranger, are you from around here? You do not look familiar!");
            Console.WriteLine("Before we start our adventure you should tell me your name then stranger.");
            Console.WriteLine("So what is your name stranger?");
            CharacterName = Console.ReadLine();
            Console.WriteLine(CharacterName + ", what a great name for a stranger!");
            Console.WriteLine("So let's get started " + CharacterName +".");
            Console.Read();
        }
    }
    class Game {}
    class Item {}
}
