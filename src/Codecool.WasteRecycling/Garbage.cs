namespace Codecool.WasteRecycling
{
    public class Garbage
    {
        public static int totalGarbageCount;

        
        public string Name { get; private set; }

        public Garbage(string name)
        {
            Name = name;

            totalGarbageCount++;
        }

       

        public void ThrowOutGarbage(Dustbin bin, Garbage garbage)
        {
            bin.ListOfHouseWaste.Add(garbage);
        }
    }
}
