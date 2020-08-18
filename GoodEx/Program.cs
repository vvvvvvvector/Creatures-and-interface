using System;

namespace CreaturesAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would You like to choose: random mode, full creature or own creature? \n1 - Full creature \n2 - Random creature \n3 - Own creature");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("What kind of creature would You like to draw: a monster, a bug or a ghost?");
                    var choice = Console.ReadLine().Replace(" ", "");
                    if (choice.ToUpper() == "MONSTER" || choice.ToUpper() == "BUG" || choice.ToUpper() == "GHOST")
                    {
                        Console.WriteLine($"It is a {choice.ToLower()}: ");
                        FullCreature(choice);
                    }
                    else Console.WriteLine("You didn't choose a creature!"); ;
                    break;
                case "2":
                    Console.WriteLine("It is Your random creature: ");
                    RandomeMode();
                    break;
                case "3":
                    Console.WriteLine("Which head do You choose: a monster, a ghost or a bug head? Press \"Enter\" if You don't care");
                    var head = Console.ReadLine();
                    Console.WriteLine("Which body do You choose: a monster, a ghost or a bug body? Press \"Enter\" if You don't care");
                    var body = Console.ReadLine();
                    Console.WriteLine("Which feet do You choose: a monster, a ghost or a bug feet? Press \"Enter\" if You don't care");
                    var feet = Console.ReadLine();
                    Console.WriteLine("It is Your creature: ");
                    OwnChoiсe(head, body, feet);
                    break;
                default:
                    Console.WriteLine("You didn't choose the mode!");
                    break;
            }
            Console.ReadLine();
        }
        public static void OwnChoiсe(string head, string body, string feet)
        {
            var creature = new Creature();
            switch (head.ToUpper())
            {
                case "MONSTER":
                    creature.Head = new Monster();
                    break;
                case "GHOST":
                    creature.Head = new Ghost();
                    break;
                case "BUG":
                    creature.Head = new Bug();
                    break;
                default:
                    switch (new Random().Next(1, 4))
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
                    break;
            }
            switch (body.ToUpper())
            {
                case "MONSTER":
                    creature.Body = new Monster();
                    break;
                case "GHOST":
                    creature.Body = new Ghost();
                    break;
                case "BUG":
                    creature.Body = new Bug();
                    break;
                default:
                    switch (new Random().Next(1, 4))
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
                    break;
            }
            switch (feet.ToUpper())
            {
                case "MONSTER":
                    creature.Feet = new Monster();
                    break;
                case "GHOST":
                    creature.Feet = new Ghost();
                    break;
                case "BUG":
                    creature.Feet = new Bug();
                    break;
                default:
                    switch (new Random().Next(1, 4))
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
                    break;
            }
            creature.DrawACreature();
        }
        public static void FullCreature(string creature)
        {
            var fullCreature = new Creature();
            switch (creature.ToUpper())
            {
                case "GHOST":
                    fullCreature.DrawAGhost();
                    break;
                case "MONSTER":
                    fullCreature.DrawAMonster();
                    break;
                case "BUG":
                    fullCreature.DrawABug();
                    break;
            }
        }
        public static void RandomeMode()
        {
            var creature = new Creature();
            switch (new Random().Next(1, 4))
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
            switch (new Random().Next(1, 4))
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
            switch (new Random().Next(1, 4))
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
            creature.DrawACreature();
        }
    }
}
