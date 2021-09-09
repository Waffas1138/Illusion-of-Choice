using System;
using System.Collections.Generic;
using System.Text;

namespace Utilites
{

        public static class StandardMesages
        {
            // sent all the standard text for the menu here to declutter the main body
            public static string DisplayMenU()
            {
                return "Move North \nMove South \nAttack \nExit";
            }

            public static string DisplayMenuPrompt()
            {
                return "Enter a choice for Example 'Rooms' or 'North'> ";
            }

            public static string DisplayRoom(int index)
            {
                return $"You are in {World.rooms[index]}";
            }

            public static string DisplayMenuError()
            {
                return "Not a valid option!";
            }
        }
}
