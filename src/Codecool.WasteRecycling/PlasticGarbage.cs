using System;

namespace Codecool.WasteRecycling
{
    public class PlasticGarbage : Garbage
    {
        public static int PlasticCount { get; private set; }
        
        public bool Cleaned { get; private set; }
        public bool Cleanable { get; private set; }

        public PlasticGarbage(string name, bool cleaned, bool cleanable) : base(name)
        {
            Cleaned = cleaned;
            Cleanable = cleanable;
            Clean();

            PlasticCount++;
            Id = PlasticCount;
           
        }

        public void Clean()
        {
            if (Cleaned == false && Cleanable == true)
            {
                Cleaned = true;
            }
            else if (Cleaned == false && Cleanable == false)
            {
                Console.WriteLine("Garbage is not clean and not cleanable");
                PlasticCount--;
            }
        }


    }
}
