using Codecool.WasteRecycling.Enum;
using System;
using System.Threading;

namespace Codecool.WasteRecycling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Dustbin bin = CreateABin();

            //HouseWaste houseWaste = new("old meat");
            //bin.ThrowOutGarbage(houseWaste);
            //HouseWaste houseWaste2 = new("old fish");
            //bin.ThrowOutGarbage(houseWaste2);
            //PlasticGarbage pla1 = new("dfgjk", false, true);
            //bin.ThrowOutGarbage(pla1);
            //PlasticGarbage pla2 = new("nsfh", true, true);
            //bin.ThrowOutGarbage(pla2);
            //PlasticGarbage pla3 = new("plastic", true, false);
            //bin.ThrowOutGarbage(pla3);
            //PlasticGarbage pla4 = new("bottle", false, false);
            //bin.ThrowOutGarbage(pla4);
            //PaperGarbage pap1 = new("dkfk", true, true);
            //bin.ThrowOutGarbage(pap1);
            //PaperGarbage pap2 = new("bdsbgnsb", true, false);
            //bin.ThrowOutGarbage(pap2);
            //PaperGarbage pap3 = new("notebook", false, true);
            //bin.ThrowOutGarbage(pap3);
            //PaperGarbage pap4 = new("box", false, false);
            //bin.ThrowOutGarbage(pap4);

            //bin.PrintTheContent();
            //DustbinContentException.PrintListOfGarbageException();

            //bin.EmptyTheBin();
            //bin.PrintTheContent();
            ////bin.PrintListOfGarbage(bin.ListOfHouseWaste);

            ////ReadAndValidateType();
            //Console.WriteLine("\n\n");

            do
            {
                Console.Clear();
                Dustbin dustbin = CreateABin();
                SleepAndClear();
                PrintStartingMenu(dustbin);
                PrintTheDustbinContent(dustbin);
            } while (AskUserToContinue());



        }
        public static bool AskUserToContinue()
        {
            SleepAndClear();
            Console.WriteLine("Do you want to create a new dustbin?");
            Console.WriteLine("For yes press \" Y \" or another button to exit");
            string answear = Console.ReadLine().ToUpper();
            if(answear == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static void SleepAndClear()
        {
            Thread.Sleep(1000);
            Console.Clear();
        }

        public static Dustbin CreateABin()
        {
            Console.WriteLine("Welcome to the recycling dustbin\n");
            Console.WriteLine("Choose the color of the dustbin");
            string name = Console.ReadLine();
            return new Dustbin(name);
        }

        public static void PrintStartingMenu(Dustbin bin)
        {
            
            do
            {
                SleepAndClear();
                Console.WriteLine("What type of garbage do you want to throw?\n");
                Console.WriteLine("Housewaste press => 1");
                Console.WriteLine("Plastic press => 2");
                Console.WriteLine("Paper press => 3\n");
                CreateAGarbage(bin);
                
                SleepAndClear();
                Console.WriteLine("Do you have another garbage to throw? Press \"Y\" for yes or another button for no");
                string anotherGarbage = Console.ReadLine().ToUpper();
                if (anotherGarbage != "Y")
                {
                    break;
                }
            } while (true);
        }

        public static void PrintTheDustbinContent(Dustbin bin)
        {
            Console.WriteLine("Show the content of the bin press => 1\n");
            string print = Console.ReadLine();
            if (print == "1")
            {
                bin.PrintTheContent();
            }
            Console.WriteLine("\nEmpty the bin press => 2\n");
            string empty = Console.ReadLine();
            if (empty == "2")
            {
                bin.EmptyTheBin();
                bin.PrintTheContent();
            }
            Console.WriteLine();
            DustbinContentException.PrintListOfGarbageException();
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
        public static void CreateAGarbage(Dustbin bin)
        {
            string type = ReadAndValidateType();
            TypeOfGarbage typeOfGarbage;
            typeOfGarbage = StringToTypeOfGarbageConverter.Convert(type);
            Console.WriteLine("Put the name of garbage");
            string name = Console.ReadLine();
            switch (typeOfGarbage)
            {
                case TypeOfGarbage.HouseWaste:
                    bin.ThrowOutGarbage(CreateHouseWaste(name));
                    break;
                case TypeOfGarbage.PlasticGarbage:
                    bin.ThrowOutGarbage(CreatePlasticGarbage(name));
                    break;
                case TypeOfGarbage.PaperGarbage:
                    bin.ThrowOutGarbage(CreatePaperGarbage(name));
                    break;
                //case TypeOfGarbage.UnknownGarbage:
                //    break;
            }
            //switch (type)
            //{
            //    case "1":
            //        {
            //            CreateHouseWaste(name);
            //            break;
            //        }
            //    case "2":
            //        {
            //            CreatePlasticGarbage(name);
            //            break;
            //        }
            //    case "3":
            //        {
            //            break;
            //        }
            //}
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
            bool cleanedSqueezed;
            AskIfCleanOrSqueezed(type);

            string cleanOrSquezzed = Console.ReadLine().ToUpper();
            if (cleanOrSquezzed == "Y")
            {
                cleanedSqueezed = true;
            }
            else
            {
                cleanedSqueezed = false;
            }

            bool cleanabledSqueezabled;
            AskIfCleanalbeOrSqueezable(type);

            string cleanableOrSqueezable = Console.ReadLine().ToUpper();
            if (cleanableOrSqueezable == "Y")
            {
                cleanabledSqueezabled = true;
            }
            else
            {
                cleanabledSqueezabled = false;
            }
            return (cleanedSqueezed, cleanabledSqueezabled);
        }

        private static void AskIfCleanOrSqueezed(TypeOfGarbage type)
        {
            if (type == TypeOfGarbage.PlasticGarbage)
            {
                Console.WriteLine("Is the plastic garbage clean? Put Y for yes and N for no");
            }
            else if (type == TypeOfGarbage.PaperGarbage)
            {
                Console.WriteLine("Is the paper garbage squeezed? Put Y for yes and N for no");
            }
        }

        private static void AskIfCleanalbeOrSqueezable(TypeOfGarbage type)
        {
            if (type == TypeOfGarbage.PlasticGarbage)
            {
                Console.WriteLine("Is the plastic garbage cleanable? Put Y for yes and N for no");
            }
            else if (type == TypeOfGarbage.PaperGarbage)
            {
                Console.WriteLine("Is the paper garbage squeezable? Put Y for yes and N for no");
            }
        }

        public static PaperGarbage CreatePaperGarbage(string name)
        {
            (bool squeezed, bool squeezable) squeeze = AskAboutCleaningSqueezingOptions(TypeOfGarbage.PaperGarbage);
            return new PaperGarbage(name, squeeze.squeezed, squeeze.squeezable);
        }

    }
}
