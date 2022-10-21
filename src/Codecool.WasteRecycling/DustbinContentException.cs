using System;
using System.Collections.Generic;

namespace Codecool.WasteRecycling
{
    public class DustbinContentException : Exception
    {
        public List<Garbage> GarbagesExeption { get; private set; }
    }
}
