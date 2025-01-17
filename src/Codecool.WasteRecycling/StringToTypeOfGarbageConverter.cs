using Codecool.WasteRecycling.Enum;

namespace Codecool.WasteRecycling
{
    public static class StringToTypeOfGarbageConverter
    {
        public static TypeOfGarbage Convert(string type)
        {
            switch (type)
            {
                case "1":
                    return TypeOfGarbage.HouseWaste;
                case "2":
                    return TypeOfGarbage.PlasticGarbage;
                case "3":
                    return TypeOfGarbage.PaperGarbage;
                default:
                    return TypeOfGarbage.UnknownGarbage;
            }
        }
    }
}
