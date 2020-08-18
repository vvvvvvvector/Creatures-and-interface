using System;

namespace BadEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating full creatures

            var monster = new Monster();
            monster.Head = new MonsterPart();
            monster.Body = new MonsterPart();
            monster.Feet = new MonsterPart();
            monster.DrawAMonster();

            //Creating random creature

            var ghost = new Ghost();
            ghost.Head = new GhostPart();

            monster = new Monster();
            monster.Body = new MonsterPart();

            var bug = new Bug();
            bug.Feet = new BugPart();

            ghost.Head.DrawAHead();
            monster.Body.DrawABody();
            bug.Feet.DrawAFeet();

            Console.ReadKey();
        }
    }
}
