using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public static class Movement
    {
        public static void MoveNorth(ref int index)//Moves us up once at a time through the room list to simulate traveling
        {
            if (index < 4)
            {
                index++;
            }
        }

        public static void MoveSouth(ref int index)//Moves us down once at a time through the room list to simulate traveling
        {
            if (index > 0)
            {
                index--;
            }
        }
    }
}
