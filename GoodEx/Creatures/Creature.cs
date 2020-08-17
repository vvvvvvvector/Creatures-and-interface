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
    }
}
