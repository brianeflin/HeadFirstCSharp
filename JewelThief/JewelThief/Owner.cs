
using System;

namespace JewelThief
{
    class Owner
    {
        private Jewels returnedContents;

        public void ReceiveContents(Jewels safeContents)
        {
            returnedContents = safeContents;
            Console.WriteLine("Thanks you for returning my jewels! " + returnedContents.Sparkle());
        }
    }
}
