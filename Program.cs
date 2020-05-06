using System;

namespace CreaturesAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Creature creature = new Creature();

            creature.Head = new Ghost();
            creature.Head.DrawAHead();
            creature.Body = new Ghost();
            creature.Body.DrawABody();
            creature.Feet = new Ghost();
            creature.Feet.DrawAFeet();

            creature.Head = new Monster();
            creature.Head.DrawAHead();
            creature.Body = new Monster();
            creature.Body.DrawABody();
            creature.Feet = new Monster();
            creature.Feet.DrawAFeet();

            creature.Head = new Bug();
            creature.Head.DrawAHead();
            creature.Body = new Bug();
            creature.Body.DrawABody();
            creature.Feet = new Bug();
            creature.Feet.DrawAFeet();

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
