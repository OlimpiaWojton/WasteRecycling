using System;

namespace Codecool.WasteRecycling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dustbin bin = CreateABin();
            
            HouseWaste garbage = new("old meat");
            bin.ThrowOutGarbage(garbage);
            PlasticGarbage p = new("dfgjk", false, true);
            bin.ThrowOutGarbage(p);
            PlasticGarbage p3 = new("nsfh", true, true);
            bin.ThrowOutGarbage(p3);
            PaperGarbage p2 = new("dkfk", true, true);
            bin.ThrowOutGarbage(p2);
            PaperGarbage paper = new("bdsbgnsb", true, false);
            bin.ThrowOutGarbage(paper);
            PaperGarbage paper2 = new("notebook", false, true);
            bin.ThrowOutGarbage(paper2);

            bin.PrintTheContent();
            
           
           
        }

        public static Dustbin CreateABin()
        {
            Console.WriteLine("Choose the color of the dustbin");
            string name = Console.ReadLine();
            return new Dustbin(name);
        }


    }
}
