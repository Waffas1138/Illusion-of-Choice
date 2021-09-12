using System;


namespace Utilites
{
    public class Attack
    {
        public static string DisplayAttackResults()
        {
            int playerMaxHp = 100;
            Random hit = new Random();
            int result = hit.Next(1, 20);
            int playerCurrentHP = playerMaxHp - result;

            Random enemyhit = new Random();
            int enemyresult = enemyhit.Next(1, 20);
            int enemyMaxHP = 150;
            int enemyCurrentHP = enemyMaxHP - enemyresult;
            return $"You took {result} hit points of damage and your Current HP is at {playerCurrentHP} \nand The enemy took {enemyresult} hit points of damage as well and are now left at { enemyCurrentHP}";
           // this is the randomly generated attack method for when we or the enemy attack one another.            
        } 
    }
      
}

