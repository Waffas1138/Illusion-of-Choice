using System;
using System.Collections.Generic;
using System.Text;

namespace Utilites
{
    public class World
    {
        public static bool exit = false;
        public static int index = 0;
        // This keeps all of the lists used in the game as well as set our room to the staring location to get us squared away.
        public static List<string> rooms = new List<string>() { "East wing", "Library", "Main Hall", "Upper Labs", "West Wing" };
        public static List<string> weapons = new List<string>() { "Butterfly Knife", "three round burst revolver", "single shot revolver", "Claymore Sword", "Golden Gun" };
        public static List<string> potions = new List<string>() { "Health Restoration", "Mana Restoration" };
        public static List<string> treasures = new List<string>() { "Mana Up", "Health Up", "Gold" };
        public static List<string> items = new List<string>() { "Magic Bullets", "Silver Bullets", "Plasma Bullets", "Flame Upgrade", "Repair Kits" };
        public static List<string> mobs = new List<string>() { "Mecha Soldiers", "Grunt", "Heavy Soldier", "Hell Hound", "Imp" };
    }
}
