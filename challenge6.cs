using System;
using System.Linq;

namespace Challenge6
{
    class Program
    {
        static void Main(string[] args)
        {
            int heroHp = 10;
            int monsterHp = 10;

            while (monsterHp > 0 && heroHp > 0)
            {

                // damage of the hero attack
                Random heroAttack = new Random();
                int heroAttack1 = heroAttack.Next(1, 11);
                monsterHp -= heroAttack1;
             
                // results of damage
                Console.WriteLine($"monster lost: {heroAttack1}");
                Console.WriteLine($"monster has: {monsterHp} health remaining");

                // damage of the monster attack
                Random monsterAttack = new Random();
                int monsterAttack1 = monsterAttack.Next(1, 11);
                if (monsterHp > 0)
                    heroHp -= monsterAttack1;

                // results of damage
                Console.WriteLine($"Hero lost: {monsterAttack1}");
                Console.WriteLine($"Hero has: {heroHp} health remaining");

            }

            if (monsterHp <= 0)
                Console.WriteLine("the monster is dead!!!!");
            if (heroHp <= 0)
                Console.WriteLine("the hero is dead!!!!");
        }
    }
}