using System;

namespace Codecool.WasteRecycling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dustbin bin = CreateABin();
            
            HouseWaste houseWaste = new("old meat");
            bin.ThrowOutGarbage(houseWaste);
            HouseWaste houseWaste2 = new("old fish");
            bin.ThrowOutGarbage(houseWaste2);
            PlasticGarbage pla1 = new("dfgjk", false, true);
            bin.ThrowOutGarbage(pla1);
            PlasticGarbage pla2 = new("nsfh", true, true);
            bin.ThrowOutGarbage(pla2);
            PlasticGarbage pla3 = new("plastic", true, false);
            bin.ThrowOutGarbage(pla3);
            PaperGarbage pap1 = new("dkfk", true, true);
            bin.ThrowOutGarbage(pap1);
            PaperGarbage pap2 = new("bdsbgnsb", true, false);
            bin.ThrowOutGarbage(pap2);
            PaperGarbage pap3 = new("notebook", false, true);
            bin.ThrowOutGarbage(pap3);

            bin.PrintTheContent();
            
            //bin.EmptyTheBin();
            //bin.PrintTheContent();
            bin.PrintListOfGarbage(bin.ListOfHouseWaste);
           
        }

        public static Dustbin CreateABin()
        {
            Console.WriteLine("Choose the color of the dustbin");
            string name = Console.ReadLine();
            return new Dustbin(name);
        }


    }
}
