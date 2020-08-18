using System;
using System.Collections.Generic;
using System.Text;

namespace CreaturesAndInterface
{
    class Creature
    {
        public IPart Head { get; set; }
        public IPart Body { get; set; }
        public IPart Feet { get; set; }
        public void DrawACreature()
        {
            Head.DrawAHead();
            Body.DrawABody();
            Feet.DrawAFeet();
        }
        public void DrawAGhost()
        {
            var ghost = new Ghost();
            ghost.DrawAHead();
            ghost.DrawABody();
            ghost.DrawAFeet();
        }
        public void DrawAMonster()
        {
            var monster = new Monster();
            monster.DrawAHead();
            monster.DrawABody();
            monster.DrawAFeet();
        }
        public void DrawABug()
        {
            var bug = new Bug();
            bug.DrawAHead();
            bug.DrawABody();
            bug.DrawAFeet();
        }
    }
}
