using System;
using System.Collections.Generic;
using System.Text;

namespace Utilites
{
    public static class RoomDescriptions
    {
        public static List<string> rooms = new List<string>() { "East wing", "Library", "Main Hall", "Upper Labs", "West Wing" };
        // uses the room list and room index for reference so I am able to pull the room descriptions whenever the index matches the room now.
        public static string RoomInfo(int index)
        {
            if (World.rooms[index] == "East wing")
            {

                Console.WriteLine("You're standing inside the east wing of what looks to be some rundown police station but it's hard to make out exactly " +
                    "where you and how you got here in the first place. It's dimly lit but you only see one way out.");
                Console.WriteLine("Exits: Library.");
                return $"You are still in {World.rooms[index]}";
            }
            if (World.rooms[index] == "Library")
            {
                Console.WriteLine("After making your way through the door you walked into a massive library which if this was an ordinary day would have " +
                    "tons of people in here but now the books and shelves are just thrown around and it looks like its been left alone for months until now");
                Console.WriteLine("Exits: East Wing or Main Hall");
                return $"You are still in {World.rooms[index]}";
            }
            if (World.rooms[index] == "Main Hall")
            {
                Console.WriteLine("Now you have manged to make your way into the Main Hall and can get a better grasp of the building you are in, " +
                    "you notice that there are three floors and right now you are on the second floor of this building. You still don't know how you got here but at least you're " +
                    "getting a better grasp on where you are");
                Console.WriteLine("Exits: Labratory or Upper Labs");
                return $"You are still in {World.rooms[index]}";
            }
            if (World.rooms[index] == "Upper Labs")
            {
                Console.WriteLine("On the third floor now you walk into this room that looked like someone had tried to block anyone from entering and as you walk in you notice that " +
                    "computers are still running and it looks like they are doing tests on the creatures you've encountered in this place while you've been trying to get your bearings. ");
                Console.WriteLine("Exits: Main Hall or West Wing");
                return $"You are still in {World.rooms[index]}";
            }
            if (World.rooms[index] == "West Wing")
            {
                Console.WriteLine("Now on the opposite side of the building you've entered the west wing and everything on this side looks as if someone or something has been destroying everything here" +
                    "so as to hide whatever it was that is going on here, you can hear something coming from outside though and it seems like it is getting closer every second.");
                Console.WriteLine("Exits: Upper Labs");
                return $"You are still in {World.rooms[index]}";
            }
            else
            {
                return $"You are still in {World.rooms[index]}";
            }

        }

    }
}
