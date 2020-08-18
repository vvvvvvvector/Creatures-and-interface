using System;
using System.Collections.Generic;
using System.Text;

namespace BadEx
{
    class Monster
    {
        public MonsterPart Head { get; set; }
        public MonsterPart Body { get; set; }
        public MonsterPart Feet { get; set; }
        public void DrawAMonster()
        {
            Head.DrawAHead();
            Body.DrawABody();
            Feet.DrawAFeet();
        }
    }
}
