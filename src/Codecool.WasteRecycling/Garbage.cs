namespace Codecool.WasteRecycling
{
    public class Garbage
    {
        public static int totalGarbageCount;
        public int Id { get; set; }
        
        public string Name { get; private set; }

        public Garbage(string name)
        {
            Name = name;

            totalGarbageCount++;
        }

    }
}
