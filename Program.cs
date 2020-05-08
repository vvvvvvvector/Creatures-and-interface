using System;

namespace CreaturesAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Creature creature = new Creature();

            Console.WriteLine("What kind of creature would you like to draw: a monster, a bug or a ghost?");
            var choice = Console.ReadLine().Replace(" ", "");
            FullCreature(choice);

            creature.Head = new Monster();
            creature.Head.DrawAHead();
            creature.Body = new Ghost();
            creature.Body.DrawABody();
            creature.Feet = new Bug();
            creature.Feet.DrawAFeet();

            Console.ReadLine();
        }
        public static void FullCreature(string creature) 
        {
            switch (creature.ToUpper()) 
            {
                case "GHOST":
                    Ghost.DrawAGhost();
                    break;
                case "MONSTER":
                    Monster.DrawAMonster();
                    break;
                case "BUG":
                    Bug.DrawABug();
                    break;
                default: Console.WriteLine("You didn't choose a creature!");
                    break;
            }
        }
    }
}
