/**
* 9/12/2021
* CSC 253
* Group 2

* Group Members: Travis Bivins / Mateo Friend
* This is an expanded version of the text based adventure game from before but taking in what we have learned in the advanced class
* and making a full fledged fleshed out game
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilites;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            Player.PlayerCreate();// calls our player creations prompt for when they launch it
            while (World.exit == false)
            {
                Console.WriteLine(StandardMesages.DisplayRoom(World.index)); // calls the message to display our current room
                Console.WriteLine("");
                Console.WriteLine(RoomDescriptions.RoomInfo(World.index));// sends the room description to the menu now
                Console.WriteLine("");
                Console.WriteLine(StandardMesages.DisplayMenU()); // displays our menu 
                Console.Write(StandardMesages.DisplayMenuPrompt());

                switch (Console.ReadLine().ToLower()) // new switch and case for the user to go through the menus even the ones that aren't stated 
                {
                    case "rooms":
                        ForEach.DisplayValues(World.rooms);
                        break;
                    case "weapons":
                        ForEach.DisplayValues(World.weapons);
                        break;
                    case "potions":
                        ForEach.DisplayValues(World.potions);
                        break;
                    case "treasure":
                        ForEach.DisplayValues(World.treasures);
                        break;
                    case "items":
                        ForEach.DisplayValues(World.items);
                        break;
                    case "mobs": // this section now calls the mob descriptions instead of just the mobs listed
                        MobDescription.Imp();
                        Console.WriteLine("");
                        MobDescription.HellHound();
                        Console.WriteLine("");
                        MobDescription.Grunt();
                        Console.WriteLine("");
                        MobDescription.HeavySoldier();
                        Console.WriteLine("");
                        MobDescription.MechaSoldiers();
                        break;
                    case "north":
                        Movement.MoveNorth(ref World.index); // moves the user up one
                        break;
                    case "n":
                        Movement.MoveNorth(ref World.index); // moves the user up one
                        break;
                    case "south":
                        Movement.MoveSouth(ref World.index); // moves the user down one
                        break;
                    case "s":
                        Movement.MoveSouth(ref World.index); // moves the user down one
                        break;
                    case "exit":
                        World.exit = true; // exits the program
                        break;
                    case "attack":
                        Console.WriteLine(Attack.DisplayAttackResults()); // display the randomly generated attack
                        break;

                    default:
                        Console.WriteLine(StandardMesages.DisplayMenuError());
                        break;
                }
                Console.WriteLine("");
            }
        }
    }
}
