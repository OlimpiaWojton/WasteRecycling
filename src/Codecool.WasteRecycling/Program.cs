using Codecool.WasteRecycling.Enum;
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
            PlasticGarbage pla4 = new("bottle", false, false);
            bin.ThrowOutGarbage(pla4);
            PaperGarbage pap1 = new("dkfk", true, true);
            bin.ThrowOutGarbage(pap1);
            PaperGarbage pap2 = new("bdsbgnsb", true, false);
            bin.ThrowOutGarbage(pap2);
            PaperGarbage pap3 = new("notebook", false, true);
            bin.ThrowOutGarbage(pap3);
            PaperGarbage pap4 = new("box", false, false);
            bin.ThrowOutGarbage(pap4);

            bin.PrintTheContent();
            DustbinContentException.PrintListOfGarbageException();

            //bin.EmptyTheBin();
            //bin.PrintTheContent();
            //bin.PrintListOfGarbage(bin.ListOfHouseWaste);
            PrintStartingMenu();
            ReadAndValidateType();
        }

        public static Dustbin CreateABin()
        {
            Console.WriteLine("Choose the color of the dustbin");
            string name = Console.ReadLine();
            return new Dustbin(name);
        }

        public static void PrintStartingMenu()
        {
            Console.WriteLine("Welcome to the recycling dustbin\n");
            Console.WriteLine("What type of garbage do you want to throw?\n");
            Console.WriteLine("Housewaste press => 1");
            Console.WriteLine("Plastic press => 2");
            Console.WriteLine("Paper press => 3");
        }

        public static string ReadAndValidateType()
        {
            string type = Console.ReadLine();
            while (type != "1" && type != "2" && type != "3")
            {
                Console.WriteLine("Invalid input, try again!");
                type = Console.ReadLine();
            }
            return type;
        }
        public static void CreateAGarbage()
        {
            string type = ReadAndValidateType();
            TypeOfGarbage typeOfGarbage;
            typeOfGarbage = StringToTypeOfGarbageConverter.Convert(type);
            Console.WriteLine("Put the name of garbage");
            string name = Console.ReadLine();
            switch (typeOfGarbage)
            {
                case TypeOfGarbage.HouseWaste:
                    CreateHouseWaste(name);
                    break;
                case TypeOfGarbage.PlasticGarbage:
                    CreatePlasticGarbage(name);
                    break;
                case TypeOfGarbage.PaperGarbage:
                    break;
                //case TypeOfGarbage.UnknownGarbage:
                //    break;
            }
            switch (type)
            {
                case "1":
                    {
                        CreateHouseWaste(name);
                        break;
                    }
                case "2":
                    {
                        CreatePlasticGarbage(name);
                        break;
                    }
                case "3":
                    {
                        break;
                    }
            }
        }

        public static HouseWaste CreateHouseWaste(string name)
        {
            
            return new HouseWaste(name);
        }

        public static PlasticGarbage CreatePlasticGarbage(string name)
        {
            (bool cleaned, bool cleanable) clean = AskAboutCleaningSqueezingOptions(TypeOfGarbage.PlasticGarbage);
            //var clean = AskAboutCleaningOptions();
          
            return new PlasticGarbage(name, clean.cleaned, clean.cleanable);
        }

        public static (bool, bool) AskAboutCleaningSqueezingOptions(TypeOfGarbage type)
        {
            bool cleaned;
            
            Console.WriteLine("Is the plastic garbage clean? Put Y for yes and N for no");
            string clean = Console.ReadLine();
            if (clean == "Y".ToUpper())
            {
                cleaned = true;
            }
            else
            {
                cleaned = false;
            }
            
            bool cleanabled;
            Console.WriteLine("Is the plastic garbage cleanable? Put Y for yes and N for no");
            string cleanable = Console.ReadLine(); 
            if (cleanable == "Y".ToUpper())
            {
                cleanabled = true;
            }
            else
            {
                cleanabled = false;
            }
            return (cleaned, cleanabled);
        }

        public static PaperGarbage CreatePaperGarbage(string name)
        {
            return new PaperGarbage();
        }

    }
}
