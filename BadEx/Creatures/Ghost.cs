using System;
using System.Collections.Generic;
using System.Text;

namespace BadEx
{
    class Ghost
    {
        public GhostPart Head { get; set; }
        public GhostPart Body { get; set; }
        public GhostPart Feet { get; set; }
        public void DrawAGhost() 
        {
            Head.DrawAHead();
            Body.DrawABody();
            Feet.DrawAFeet();
        }
    }
}
