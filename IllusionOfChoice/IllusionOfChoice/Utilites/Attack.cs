using System;

namespace Utilites
{
    public class Attack
    {
        public static string DisplayAttackResults()
        {
            int playerHp = 100;
            Random hit = new Random();

            int result = hit.Next(1, 20);

            return $"You took {result} of damage leaving you with {playerHp - result} Hp"; // this is the randomly generated attack method for when we or the enemy attack one another.
        }
    }
}
