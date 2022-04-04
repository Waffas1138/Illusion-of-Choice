using System;
using System.Collections.Generic;
using System.Text;
using Utilites;
using System.Linq;


namespace ConsoleUI
{
    class Player
    {
        public static void PlayerCreate()
        {
            string name;
            string ClassName = "";
            string race = "";
            string password = "";
            bool validPassword = false;
            bool validClass = false;
            bool validRace = false;
            // This is used for the player to input their name
            Console.WriteLine("What is your name.");
            Console.Write("> ");
            name = (Console.ReadLine());

            // This is used for the player to input their password for their save
            while (validPassword == false) { 
            Console.WriteLine("Please enter a password, it needs one capital letter, one lowercase letter and one special character:");
            Console.Write("> ");
            password = (Console.ReadLine());
                if (password.Any(char.IsUpper) && password.Any(char.IsLower))
                {
                    validPassword = true;
                }
                else
                {
                    Console.WriteLine("That is an invalid password, please try again");
                }
            }

            while (validClass == false)// setsup the while statement so this will keep running until they enter a valid class option
            {
                Console.WriteLine("What class would you like to be?");

                Console.Write("Warrior, Tank , Rogue > ");
                ClassName = Console.ReadLine().ToLower();
                if (ClassName == "warrior")
                {

                    validClass = true;
                }
                else if (ClassName == "tank")
                {

                    validClass = true;
                }
                else if (ClassName == "rogue")
                {

                    validClass = true;
                }
                else
                {
                    Console.WriteLine("Not a valid class, please enter a valid option");// this is the catch for if they enter an invalid class
                }
            }
            while (validRace == false)// used for selecting the players race as well
            {
                Console.WriteLine("What race would you like?");
                Console.Write("Human, Demon, Dwarf > ");
                race = Console.ReadLine().ToLower();

                if (race == "human")
                {
                    validRace = true;

                }
                else if (race == "demon")
                {
                    validRace = true;

                }
                else if (race == "dwarf")
                {
                    validRace = true;

                }
                else
                {
                    Console.WriteLine("Not a Valid entry, please enter a valid option");// this is another catch incase of an invalid selection for the characters race.
                }
            }
        }
        public static void playerHP()
        {
            int hp = 1000;
            int random atk = new Random(1,100);
            Console.WriteLine(hp - atk);
            console.writeLine("Testing for damage")
                console.writeline("");
        }
    }

}
