using Codecool.WasteRecycling.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
