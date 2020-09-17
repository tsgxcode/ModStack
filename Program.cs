using System;

namespace ModStack
{
    class Program
    {
        static void Main()
        {
            /*Mod Stack - Adding Color modules: Green, Blue, Orange, etc. */
            Console.WriteLine("Mod Stack: Add color modules...then remove some!");

            //Creating the mods
            string block1 = "MossGreen";
            string block2 = "Cyan";
            string block3 = "LighGray";

            Console.Write("{3} {0} {1}", block1, block2, block3);
        }
    }
}
