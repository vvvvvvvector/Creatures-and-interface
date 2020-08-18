using System;
using System.Collections.Generic;
using System.Text;

namespace BadEx
{
    class Bug
    {
        public BugPart Head { get; set; }
        public BugPart Body { get; set; }
        public BugPart Feet { get; set; }
        public void DrawABug()
        {
            Head.DrawAHead();
            Body.DrawABody();
            Feet.DrawAFeet();
        }
    }
}
