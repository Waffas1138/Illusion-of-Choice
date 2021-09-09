using System;
using System.Collections.Generic;
using System.Text;

namespace Utilites
{
    public static class MobDescription // creating the objects for each mob description and being able to call said description in the main section
    {
        public static List<string> mobs = new List<string>() { "Mecha Soldiers", "Grunt", "Heavy Soldier", "Hell Hound", "Imp" };
        public static void Imp()
        {
            Console.WriteLine("The Imp is a very agile enemy that will try to stay at a distance and cast fireballs at you, they are prone to dodge more than most enemies but have lower health.");
        }
        public static void HellHound()
        {
            Console.WriteLine("Hell hounds always come in packs of three and can out speed you so you better keep an eye on them or if they get too close then can inflict bleed on you and you'll slowly lose HP.");
        }
        public static void HeavySoldier()
        {
            Console.WriteLine("The Heavy Soldier is an amored verson of the grunts but they only come in groups of two instead but don't let that fool you." +
                "They have increased health and damage reduction as well as a new ranged attack that will deal double damage to your armor so you best deal with them first when you can.");
        }
        public static void Grunt()
        {
            Console.WriteLine("The Grunts are the easier enemy you'll encounter but to compensate for that they can spawn anywhere from groups of 2-6 at a time. They come equiped with just a pistol" +
                "so they do low damage but can pick you apart if you don't manage them and don't get fooled by their low danger threat.");
        }
        public static void MechaSoldiers()
        {
            Console.WriteLine("When it comes to the Mecha Soldiers you better watch out for them, they will make the fight revolve around them and make you feel like the enemy instead" +
                "they are capable of going right through your armor as well as stopping you from healing for a short while after being hit. Thankfully though their high damage comes with a payoff" +
                "they do move slower than any other enemy so they wont be attack as much but they do take reduced damage so critc and high rolls will be your friend when it comes to taking them out.");
        }
    }
}
