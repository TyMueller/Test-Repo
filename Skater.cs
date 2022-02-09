using System;
namespace SkaterBoi
{
    public class Skater
    {
        private int deckSize;
        private bool hasHelmet;
        public Skater()
        {
            deckSize = 8;
            hasHelmet = false;
        }

        public void Skate()
        {
            Console.WriteLine($"I'm skating, my decksize is {deckSize} and helmet {hasHelmet}");
        }
    }
}

