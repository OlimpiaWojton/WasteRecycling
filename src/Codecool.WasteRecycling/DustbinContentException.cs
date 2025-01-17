using System;
using System.Collections.Generic;

namespace Codecool.WasteRecycling
{
    public class DustbinContentException : Exception
    {
        public static List<Garbage> GarbagesExeptionsList { get; set; } = new List<Garbage>();

        public DustbinContentException(string name) : base(String.Format($"Exception : Can't throw {name} to Dustbin"))
        {
            
        }

        public static void PrintListOfGarbageException()
        {
            Console.WriteLine("List of garbage exception:");
            for (int i = 0; i < GarbagesExeptionsList.Count; i++)
            {
                Console.WriteLine($"No. {i + 1}: {GarbagesExeptionsList[i].Name}");
            }
        }
    }
}
