using System;

namespace CreaturesAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Creature creature = new Creature();

            Ghost.DrawAGhost();

            Monster.DrawAMonster();

            Bug.DrawABug();

            creature.Head = new Monster();
            creature.Head.DrawAHead();
            creature.Body = new Ghost();
            creature.Body.DrawABody();
            creature.Feet = new Bug();
            creature.Feet.DrawAFeet();

            Console.ReadLine();
        }
    }
}
