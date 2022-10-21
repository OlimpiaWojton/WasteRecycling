namespace Codecool.WasteRecycling
{
    public class HouseWaste : Garbage
    {
        public static int HouseWasteCount { get; private set; }
        public int HouseWasteId { get; private set; }


        public HouseWaste(string name) : base(name)
        {
            HouseWasteCount++;
            HouseWasteId = HouseWasteCount;
        }
    }
}
