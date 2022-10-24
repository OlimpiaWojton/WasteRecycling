using System;
using System.Collections.Generic;

namespace Codecool.WasteRecycling
{
    public class Dustbin
    {
        public static int HouseWasteCount { get; private set; }

        public static int PlasticCount { get; private set; }

        public static int PaperCount { get; private set; }


        public string ColorOfBin { get; private set; }
        public List<Garbage> ListOfHouseWaste { get; private set; }
        public List<Garbage> ListOfPlasticGarbage { get; private set; }
        public List<Garbage> ListOfPaperGarbage { get; private set; }


        public Dustbin(string color)
        {
            ColorOfBin = color;
            ListOfHouseWaste = new List<Garbage>();
            ListOfPlasticGarbage = new List<Garbage>();
            ListOfPaperGarbage = new List<Garbage>();
        }

        public void ThrowOutGarbage(Garbage garbage)
        {
            try
            {
                if (garbage is HouseWaste)
                {
                    ListOfHouseWaste.Add(garbage);
                    HouseWasteCount++;
                }
                else if (garbage is PlasticGarbage)
                {

                    PlasticGarbage plastic = garbage as PlasticGarbage;
                    if (plastic.Cleaned == true)
                    {
                        ListOfPlasticGarbage.Add(garbage);
                        PlasticCount++;
                    }
                    else
                    {
                        throw new DustbinContentException(garbage.Name);
                    }
                }
                else if (garbage is PaperGarbage)
                {
                    PaperGarbage paper = garbage as PaperGarbage;
                    if (paper.Squeezed == true)
                    {
                        ListOfPaperGarbage.Add(garbage);
                        PaperCount++;
                    }
                    else
                    {
                        throw new DustbinContentException(garbage.Name);
                    }
                }
            }
            catch (DustbinContentException exception)
            {
                DustbinContentException.GarbagesExeptionsList.Add(garbage);
                Console.WriteLine(exception.Message);
            }
        }

        public void PrintTheContent()
        {
            Console.WriteLine($"{ColorOfBin} Dustbin !\n");
       
            WriteOutContent<HouseWaste>(ListOfHouseWaste, "Housewaste", HouseWasteCount);
            WriteOutContent<PlasticGarbage>(ListOfPlasticGarbage, "Plastic", PlasticCount);
            WriteOutContent<PaperGarbage>(ListOfPaperGarbage, "Paper", PaperCount);

            Console.WriteLine($"All content: {AddGarbage()} item(s)");
        }

        public void WriteOutContent<T>(List<Garbage> garbages, string typeOfGarbage, int count)
        {
            Console.WriteLine($"{typeOfGarbage} content: {count} item(s)");
            foreach (Garbage garbage in garbages)
            {
                if (garbage is T)
                {
                    Console.WriteLine($"\t{garbage.Name} nr.{garbage.Id}");
                }

            }
        }
        public int AddGarbage()
        {
            int totalCount = ListOfHouseWaste.Count + ListOfPlasticGarbage.Count + ListOfPaperGarbage.Count;
            return totalCount;
        }

        public void EmptyTheBin()
        {
            ListOfHouseWaste.Clear();
            ListOfPlasticGarbage.Clear();
            ListOfPaperGarbage.Clear();
            HouseWasteCount = 0;
            PlasticCount = 0;
            PaperCount = 0;
        }


        


        public void PrintListOfGarbage(List<Garbage> garbages)
        {
            for (int i = 0; i < garbages.Count; i++)
            {
                Console.WriteLine(garbages[i].Name + " " + garbages[i].Id + " " + (i + 1));
            }
        }

        public void PrintTheContent2()
        {
            Console.WriteLine($"{ColorOfBin} Dustbin !\n");
            Console.WriteLine($"Housewaste content: {ListOfHouseWaste.Count} item(s)");
            foreach (Garbage garbage in ListOfHouseWaste)
            {
                if (garbage is HouseWaste)
                {
                    Console.WriteLine($"\t{garbage.Name} nr.{garbage.Id}");
                }
            }

            Console.WriteLine($"Plastic content: {ListOfPlasticGarbage.Count} item(s)");
            foreach (Garbage garbage in ListOfPlasticGarbage)
            {
                if (garbage is PlasticGarbage)
                {
                    Console.WriteLine($"\t{garbage.Name} nr.{garbage.Id}");
                }
            }
            Console.WriteLine($"Paper content: {ListOfPaperGarbage.Count} item(s)");
            foreach (Garbage garbage in ListOfPaperGarbage)
            {
                if (garbage is PaperGarbage)
                {
                    
                    Console.WriteLine($"\t{garbage.Name} nr.{garbage.Id}");
                }
            }
            Console.WriteLine($"All content: {AddGarbage()} item(s)");
        }
    }
}
