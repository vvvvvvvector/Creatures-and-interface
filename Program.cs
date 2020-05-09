using System;

namespace CreaturesAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like to choose: random mode or full creature? 1 - full creature 2 - random creature");
            var choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    Console.WriteLine("What kind of creature would you like to draw: a monster, a bug or a ghost?");
                    var choice = Console.ReadLine().Replace(" ", "");
                    FullCreature(choice);
                    break;
                case "2":
                    RandomeMode();
                    break;
                default: 
                    Console.WriteLine("You didn't choose the mode!");
                    break;
            }

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
                default:
                    Console.WriteLine("You didn't choose a creature!");
                    break;
            }
        }
        public static void RandomeMode()
        {
            var creature = new Creature();
            var randomNumber = new Random();
            switch (randomNumber.Next(1, 4))
            {
                case 1:
                    creature.Head = new Monster();
                    break;
                case 2:
                    creature.Head = new Ghost();
                    break;
                case 3:
                    creature.Head = new Bug();
                    break;
            }
            switch (randomNumber.Next(1, 4))
            {
                case 1:
                    creature.Body = new Monster();
                    break;
                case 2:
                    creature.Body = new Ghost();
                    break;
                case 3:
                    creature.Body = new Bug();
                    break;
            }
            switch (randomNumber.Next(1, 4))
            {
                case 1:
                    creature.Feet = new Monster();
                    break;
                case 2:
                    creature.Feet = new Ghost();
                    break;
                case 3:
                    creature.Feet = new Bug();
                    break;
            }
            creature.Head.DrawAHead();
            creature.Body.DrawABody();
            creature.Feet.DrawAFeet();
        }
    }
}
