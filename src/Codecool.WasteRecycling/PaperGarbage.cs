using System;

namespace Codecool.WasteRecycling
{
    public class PaperGarbage : Garbage
    {
        public static int PaperCount { get; private set; }
        public int PaperId { get; private set; }

        public bool Squeezed { get; private set; }
        public bool Squeezable { get; private set; }

        public PaperGarbage(string name, bool squeezed, bool squeezable) : base(name)
        {
            Squeezed = squeezed;
            Squeezable = squeezable;
            Squeeze();

            PaperCount++;
            PaperId = PaperCount;
            
        }

        public void Squeeze()
        {
            if (Squeezed == false && Squeezable == true)
            {
                Squeezed = true;
            }
            else if (Squeezed == false && Squeezable == false)
            {
                Console.WriteLine("Garbage is not squeezed and not squezzable");
                PaperCount--;
            }
        }
    }
}
