using System;
using System.Collections.Generic;

namespace Codecool.WasteRecycling
{
    public class Dustbin/*<T> where T : class*/
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
            if (garbage is HouseWaste)
            {
                ListOfHouseWaste.Add(garbage);
                HouseWasteCount++;
            }
            else if (garbage is PlasticGarbage)
            {
                PlasticGarbage temp = garbage as PlasticGarbage;
                if (temp.Cleaned == true)
                {
                    ListOfPlasticGarbage.Add(garbage);
                    PlasticCount++;
                }
            }
            else if (garbage is PaperGarbage)
            {
                PaperGarbage temp = garbage as PaperGarbage;
                if (temp.Squeezed == true)
                {
                    ListOfPaperGarbage.Add(garbage);
                    PaperCount++;
                }
            }
        }

        public void PrintTheContent()
        {
            Console.WriteLine($"{ColorOfBin} Dustbin !");
            Console.WriteLine($"Housewast content: {ListOfHouseWaste.Count} item(s)");
            foreach (Garbage garbage in ListOfHouseWaste)
            {
                if (garbage is HouseWaste)
                {
                    HouseWaste temp = garbage as HouseWaste;
                    Console.WriteLine($"\t{garbage.Name} nr.{temp.HouseWasteId}");
                }
            }
           
            Console.WriteLine($"Plastic content: {ListOfPlasticGarbage.Count} item(s)");
            foreach (Garbage garbage in ListOfPlasticGarbage)
            {
                if (garbage is PlasticGarbage)
                {
                    PlasticGarbage temp = garbage as PlasticGarbage;
                    Console.WriteLine($"\t{garbage.Name} nr.{temp.PlasticId}");
                }
            }
           
            Console.WriteLine($"Paper content: {ListOfPaperGarbage.Count} item(s)");
            foreach (Garbage garbage in ListOfPaperGarbage)
            {
                if (garbage is PaperGarbage)
                {
                    PaperGarbage temp = garbage as PaperGarbage;
                    Console.WriteLine($"\t{garbage.Name} nr.{temp.PaperId}");
                }
                
            }
            Console.WriteLine($"All content: {AddGarbage()} item(s)");
        }

        public int AddGarbage()
        {
            int totalCount = ListOfHouseWaste.Count + ListOfPlasticGarbage.Count + ListOfPaperGarbage.Count;
            return totalCount;
        }
        public void PrintTheContent2()
        {
            Console.WriteLine($"Housewast content: {HouseWaste.HouseWasteCount} item(s)");
            Console.WriteLine($"Plastic content: {PlasticGarbage.PlasticCount} item(s)");
            Console.WriteLine($"Paper content: {PaperGarbage.PaperCount} item(s)");
            Console.WriteLine($"All content: {Garbage.totalGarbageCount} item(s)");
        }
    }
}
