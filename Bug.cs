using System;
using System.Collections.Generic;
using System.Text;

namespace CreaturesAndInterface
{
    class Bug : IPart
    {
        public void DrawAHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }
        public void DrawABody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }
        public void DrawAFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }
        public static void DrawABug() 
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }
    }
}
